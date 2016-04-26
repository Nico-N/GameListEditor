using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameListEditor
{ 

    public partial class GameListEditor : Form
    {

        private RomFileExtensionChooser extChooser;

        public GameListEditor()
        {
            InitializeComponent();

            extChooser = new RomFileExtensionChooser();
        }

        private void EditGamelist(string gamelistFile, string romPath, string localImagePath, string relativeImagePath, int resizeWidth)
        {
            List<GameEntry> gameList = new List<GameEntry>();

            GameListFile glFile = new GameListFile(gamelistFile);

            string[] fileArray;

            string extensionList = Helper.GetExtensionList(romFileExtensionsTextBox.Text);

            if (String.IsNullOrEmpty(extensionList))
            {
                fileArray = Directory.GetFiles(romPath);
            }
            else
            {
                string extensionFilter = extensionList;
                fileArray = Directory.GetFiles(romPath, "*.*").Where(s => extensionList.Contains(Path.GetExtension(s).ToLower())).ToArray();
            }
            
            foreach (string filename in fileArray)
            {
                gameList.Add(glFile.GetGameByPath(Path.GetFileName(filename)));
            }


            GameEntry[] gameListArray = gameList.ToArray();

            string[] glFileRoms = glFile.GetAllRoms();
            List<string> orphanRoms = new List<string>();
            foreach (string rom in glFileRoms)
            {
                if (!RomIsInArray(rom, gameListArray))
                    orphanRoms.Add(rom);
            }

            if (orphanRoms.Count > 0)
            {
                OrphanWarning warning = new OrphanWarning(orphanRoms);
                warning.ShowDialog();
            }            

            GameListView gl = new GameListView(gamelistFile, gameListArray, localImagePath, relativeImagePath, 375);

            gl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EditGamelist(@"c:\mastersystem\gamelist_new.xml",@"c:\mastersystem",@"C:\mastersystem\images","./images",375);

            /*
            List<GameEntry> gameList = new List<GameEntry>();

            GameListFile glFile = new GameListFile(@"c:\mastersystem\gamelist_ne.xml");
            string[] fileArray = Directory.GetFiles(@"c:\mastersystem", "*.zip");

            foreach (string filename in fileArray)
            {
                gameList.Add(glFile.GetGameByPath(Path.GetFileName(filename)));
            }


            GameEntry[] gameListArray = gameList.ToArray();

            string[] glFileRoms = glFile.GetAllRoms();
            List<string> orphanRoms = new List<string>();
            foreach(string rom in glFileRoms)
            {
                if (!RomIsInArray(rom, gameListArray))
                    orphanRoms.Add(rom);
            }

            if (orphanRoms.Count>0)
            {
                OrphanWarning warning = new OrphanWarning(orphanRoms);
                warning.ShowDialog();
            }

            GameListView gl = new GameListView(gameListArray,@"C:\mastersystem\images",375);

            gl.Show();*/
        }

        private bool RomIsInArray(string str,GameEntry[] arr)
        {            
            foreach (GameEntry tempEntry in arr)
            {
                if (tempEntry.Path == str) return true;
            }
            return false;
                
        }

        private void romPathChooseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                romPathTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void gamelisXmlChooseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog pickFileDialog1 = new OpenFileDialog();
            pickFileDialog1.Filter = "Gamelist.xml file|*.xml";
            pickFileDialog1.Title = "Pick a gamelist file...";
            pickFileDialog1.CheckFileExists = false;
            pickFileDialog1.ShowDialog();
    
            if(pickFileDialog1.FileName != "")
            {
                gamelistFileTextBox.Text = pickFileDialog1.FileName;
            }
        }

        private void localImagePathChooseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                localImagePathTextbox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void autofill_CheckedChanged(object sender, EventArgs e)
        {

            if(autofillCheckBox.Checked)
            {
                localImagePathTextbox.Enabled = false;
                localImagePathChooseButton.Enabled = false;
                gamelistFileTextBox.Enabled = false;
                gamelistFileChooseButton.Enabled = false;                
            }
            else
            {
                localImagePathTextbox.Enabled = true;
                localImagePathChooseButton.Enabled = true;
                gamelistFileTextBox.Enabled = true;
                gamelistFileChooseButton.Enabled = true;  
            }


        }

        private void romPathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (autofillCheckBox.Checked) autofillFields();
        }

        private void autofillFields()
        {
            localImagePathTextbox.Text = Helper.RemoveAppendedSlash(romPathTextBox.Text) + "\\images";
            gamelistFileTextBox.Text = Helper.RemoveAppendedSlash(romPathTextBox.Text) + "\\gamelist.xml";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(romPathTextBox.Text))
            {

                string romPath;
                string gamelistFile = gamelistFileTextBox.Text;
                string localImagePath;
                int resizeWitdth;
                string relativeImagePath = Helper.RemoveAppendedSlash(relativeImagePathTextbox.Text);

                romPath = romPathTextBox.Text;

                if (!System.IO.File.Exists(gamelistFileTextBox.Text))
                {
                    MessageBox.Show("Gamelist file " + gamelistFile + " does not exist.\nEditor will start with an empty gamlist.");
                }

                bool imageDirOK = false;

                if (System.IO.Directory.Exists(localImagePathTextbox.Text))
                {
                    imageDirOK = true;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Local image path " + localImagePathTextbox.Text + " does not exist. Create directory?\n(Local image path is needed to store new images.)", "Create empty image directory?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            System.IO.Directory.CreateDirectory(localImagePathTextbox.Text);
                            imageDirOK = true;
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.Message, "Error creating directory");               
                        }
                    }                    
                }

                if (imageDirOK)
                    localImagePath = localImagePathTextbox.Text;
                else
                    localImagePath = null;

                try
                {
                    resizeWitdth = Int32.Parse(resizeWidthTextbox.Text);
                }
                catch
                {
                    MessageBox.Show("Resize width value not acceptable. Default value 375 will be used.","Warning");
                    resizeWitdth = 375;
                }

                EditGamelist(gamelistFile, romPath, localImagePath, relativeImagePath, resizeWitdth);


            }
            else
            {
                MessageBox.Show("Rom path does not exist", "Error");
            }
        }

        private void romFileExtensionsChooseButton_Click(object sender, EventArgs e)
        {
            
            extChooser.ShowDialog();
            romFileExtensionsTextBox.Text = extChooser.SelectedExtensionList;

        }





    }
}
