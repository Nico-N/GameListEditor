using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameListEditor
{

    /// <summary>
    /// Form for view and edit a number of GameEntrys
    /// </summary>
    public partial class GameListView : Form
    {

        private int currentEntry = 0; //current selected GameEntry in array
        private string gamelistFile; //gamelist.xml file to edit
        private GameEntry[] gameListEntrys; //the array that hold all GameEntrys
        private string localImagePath; //the path where images are stored on the local machine
        private string relativeImagePath; //the path that is used in the gamelist.xml for all image entrys
        private int resizeWidth; //the width all newly added images will be resized to
        private bool codeTriggered = false; //helper var to determine if an event is envoked by code or by user interaction
        private EnterGameIDForm enterIDForm;
        private GameSearchForm searchForm;


    
        /// <summary>
        /// Constructor Method - will create a new Form with GameEntrys
        /// </summary>
        /// <param name="gamelistFile">filename of gamelist.xml file to edit</param>
        /// <param name="gameList">The array of GameEntry elements to display and edit</param>
        /// <param name="localImagePath">the path where images are stored on the local machine</param>
        /// <param name="resizeWidth">the width all newly added images will be resized to</param>
        public GameListView(string gamelistFile, GameEntry[] gameList, string localImagePath, string relativeImagePath, int resizeWidth)
        {

            InitializeComponent();

            //set class members
            this.localImagePath = localImagePath;
            this.relativeImagePath = relativeImagePath;
            this.resizeWidth = resizeWidth;
            this.gamelistFile = gamelistFile;
            gameListEntrys = gameList;
            currentEntry = 0;
            enterIDForm = new EnterGameIDForm();
            searchForm = new GameSearchForm();
            
            
            //fill the listbox with GameEntrys
            for (int i = 0; i < gameList.Length; i++)
            {
                gameEntrysListBox.Items.Add(gameListEntrys[i].Path);
            }

            //Fill all Form Fields with Data
            FillDataFields();

            //Let the picturebox recieve Drag and Drop events
            artworkPictureBox.AllowDrop = true;

        }
        
        /// <summary>
        /// 
        /// </summary>
        private void FillDataFields()
        {
            if (gameListEntrys.Length > 0)
            {
                pathTextBox.Text = gameListEntrys[currentEntry].Path;
                nameTextBox.Text = gameListEntrys[currentEntry].Name;
                descriptionTextBox.Text = gameListEntrys[currentEntry].Description;
                imageTextBox.Text = gameListEntrys[currentEntry].Image;
                ratingTextBox.Text = gameListEntrys[currentEntry].Rating;
                releaseTextBox.Text = gameListEntrys[currentEntry].ReleaseDate;
                developerTextBox.Text = gameListEntrys[currentEntry].Developer;
                publisherTextBox.Text = gameListEntrys[currentEntry].Publisher;
                genreTextBox.Text = gameListEntrys[currentEntry].Genre;
                playersTextBox.Text = gameListEntrys[currentEntry].Players;
                hiddenCheckBox.Checked = gameListEntrys[currentEntry].Hidden;
                toolStripStatusLabel.Text = "ID=" + gameListEntrys[currentEntry].ID + " (" + gameListEntrys[currentEntry].Datasource+")";

                codeTriggered = true;
                gameEntrysListBox.SelectedIndex = currentEntry;
                codeTriggered = false;

                if (String.IsNullOrEmpty(gameListEntrys[currentEntry].Image))
                {
                    artworkPictureBox.Image = null;
                    artworkDropLabel.Text = "Drag an image file or image link here";
                    artworkDropLabel.Visible = true;
                }
                else
                {
                    try
                    {

                        using (var imgTemp = new Bitmap(localImagePath + "\\" + gameListEntrys[currentEntry].Image))
                        {
                            artworkPictureBox.Image = new Bitmap(imgTemp);
                            artworkDropLabel.Visible = false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error loading imagefile:\n" + localImagePath + "\\" + gameListEntrys[currentEntry].Image);
                        artworkPictureBox.Image = null;
                        artworkDropLabel.Text = "Drag an image file or image link here";
                        artworkDropLabel.Visible = true;
                    }
                }

                if (currentEntry == 0)
                    this.prevButton.Enabled = false;
                else
                    this.prevButton.Enabled = true;

                if (currentEntry >= gameListEntrys.Length - 1)
                    this.nextButton.Enabled = false;
                else
                    this.nextButton.Enabled = true;
              
            }  //end of if(gameListEntrys.Length > 0)
            else
            {
                this.prevButton.Enabled = false;
                this.nextButton.Enabled = false;
            }

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            currentEntry++;            
            FillDataFields();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            currentEntry--;            
            FillDataFields();
        }

        private void GameEntrysListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!codeTriggered)
            {
                currentEntry = gameEntrysListBox.SelectedIndex;                
                FillDataFields();
            }
            
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Name = nameTextBox.Text;
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Description = descriptionTextBox.Text;
        }

        private void imageTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Image = imageTextBox.Text;
        }

        private void ratingTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Rating = ratingTextBox.Text;
        }

        private void releaseTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].ReleaseDate = releaseTextBox.Text;
        }

        private void developerTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Developer = developerTextBox.Text;
        }

        private void PublishertextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Publisher = publisherTextBox.Text;
        }

        private void genreTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Genre = genreTextBox.Text;
        }

        private void playersTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Players = playersTextBox.Text;
        }

        private void artworkPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;

            if ((e.AllowedEffect & DragDropEffects.Link) == DragDropEffects.Link)
                e.Effect = DragDropEffects.Link;
        }

        private bool LoadImageFromURL (string imageURL)
        {
            try
            {
                artworkPictureBox.Image = null;
                artworkDropLabel.Text = "Loading image...";
                artworkDropLabel.Visible = true;
                artworkDropLabel.Update();
                artworkPictureBox.Load(imageURL);
                artworkDropLabel.Visible = false;
                return true;

            }
            catch
            {
                artworkDropLabel.Text = "Error loading image\n" + imageURL;
                return false;
            }
        }

        private void SaveImageboxToFile()
        {
            bool okToSave = false;
                bool successfullySaved = false;
                string outFilename = localImagePath + "\\" + System.IO.Path.GetFileNameWithoutExtension(gameListEntrys[currentEntry].Path) + "-image.jpg";

                if (System.IO.File.Exists(outFilename))
                {
                    DialogResult result;
                    result = MessageBox.Show(this, "File " + outFilename + " already exists. Overwrite?", "Warning", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            System.IO.File.Delete(outFilename);
                            okToSave = true;
                        }
                        catch (Exception exp)
                        {

                            MessageBox.Show("Can't overwrite file " + outFilename + "\n" + exp.ToString());
                        }
                    }
                }
                else
                {
                    okToSave = true;
                }



                if (okToSave)
                {
                    try
                    {
                        Bitmap resizedImage = ResizeImageToWidth(artworkPictureBox.Image, resizeWidth);
                        resizedImage.Save(outFilename, System.Drawing.Imaging.ImageFormat.Png);
                        successfullySaved = true;
                        resizedImage.Dispose();
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("Error saving new image to\n" + outFilename + "\n" + exp.ToString());
                        successfullySaved = false;
                    }
                }
                else
                {
                    FillDataFields();
                }

                if (successfullySaved)
                {

                    gameListEntrys[currentEntry].Image = System.IO.Path.GetFileNameWithoutExtension(gameListEntrys[currentEntry].Path) + "-image.jpg";
                    FillDataFields();
                }
        }

        private void artworkPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            string filename = String.Empty;
            string imageURL = String.Empty;
            bool successfullyLoaded = false;

            if (e.Data.GetDataPresent("Filename"))
            {

                Array data = ((IDataObject)e.Data).GetData("FileName") as Array;

                filename = ((string[])data)[0];

                try
                {
                    artworkPictureBox.Image = null;
                    artworkDropLabel.Text = "Loading image...";
                    artworkDropLabel.Visible = true;
                    artworkDropLabel.Update();
                    artworkPictureBox.Image = new Bitmap(filename);                   
                    artworkDropLabel.Visible = false;
                    successfullyLoaded = true;

                }
                catch
                {
                    artworkDropLabel.Text = "Error loading image\n" + filename;
                    successfullyLoaded = false;

                }

            }
            else if (e.Data.GetDataPresent("UnicodeText"))
            {
                successfullyLoaded = LoadImageFromURL(((IDataObject)e.Data).GetData("UnicodeText").ToString());
            }

            if (successfullyLoaded)
            {
                SaveImageboxToFile();
            }



        }

        private static Bitmap ResizeImageToWidth(Image image, int width)
        {

            int height = (int)((float)image.Height / image.Width * width);
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void FillFormWithGameInfoByID(string gameID)
        {
            toolStripStatusLabel.Text = "Lookup game information - please wait";
            this.Update();

            GameEntry tempEntry = GameDatabaseRequest.GetGameEntryByID(gameID);

            if (tempEntry != null)
            {
                gameListEntrys[currentEntry].Name = tempEntry.Name;
                gameListEntrys[currentEntry].Description = tempEntry.Description;
                gameListEntrys[currentEntry].Rating = tempEntry.Rating;
                gameListEntrys[currentEntry].ReleaseDate = tempEntry.ReleaseDate;
                gameListEntrys[currentEntry].Developer = tempEntry.Developer;
                gameListEntrys[currentEntry].Publisher = tempEntry.Publisher;
                gameListEntrys[currentEntry].Genre = tempEntry.Genre;
                gameListEntrys[currentEntry].Players = tempEntry.Players;
                gameListEntrys[currentEntry].ID = tempEntry.ID;
                gameListEntrys[currentEntry].Datasource = tempEntry.Datasource;
                FillDataFields();

                if (!String.IsNullOrEmpty(tempEntry.ImageURL))
                {
                    bool successfullyLoaded = LoadImageFromURL(tempEntry.ImageURL);
                    if (successfullyLoaded) SaveImageboxToFile();
                    FillDataFields();
                }

                toolStripStatusLabel.Text = "Game information found";


            }
            else
            {
                toolStripStatusLabel.Text = "No game information found";
            }
        }

        private void enterGameIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enterIDForm.ShowDialog();

            if (!enterIDForm.canceled)
            {
                FillFormWithGameInfoByID(enterIDForm.enteredID);
            } 

        }

        private void saveGamelistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.SaveGamelist(gameListEntrys, relativeImagePath, gamelistFile);
        }

        private void searchGameInfoInDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            

            string searchQuery = System.IO.Path.GetFileNameWithoutExtension(gameListEntrys[currentEntry].Path);

            int cutPoint = searchQuery.IndexOf("(");            
            if (cutPoint > 0)
                searchQuery = searchQuery.Substring(0, cutPoint);

            cutPoint = searchQuery.IndexOf("[");
            if (cutPoint > 0)
                searchQuery = searchQuery.Substring(0, cutPoint);

            searchForm.SetSearchQuery(searchQuery);

            searchForm.ShowDialog();

            if (searchForm.resultSelected)
            {
                FillFormWithGameInfoByID(searchForm.selectedResultID);
            }

        }

        private void hiddenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Hidden = hiddenCheckBox.Checked;
        }

        

       


    }
}
