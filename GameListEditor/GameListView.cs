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
        /// Fill all the data and control elements of the form with data from currently selected game
        /// </summary>
        private void FillDataFields()
        {
            if (gameListEntrys.Length > 0)
            {

                //Fill all Text Boxes
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

                //Fill Hidden Checkbox
                hiddenCheckBox.Checked = gameListEntrys[currentEntry].Hidden;

                //Set info text ion status bar
                toolStripStatusLabel.Text = "ID=" + gameListEntrys[currentEntry].ID + " (" + gameListEntrys[currentEntry].Datasource+")";

                //Select current game in Listbox 
                codeTriggered = true; //preventing actions in SelectedIndexChanged event
                gameEntrysListBox.SelectedIndex = currentEntry;
                codeTriggered = false;


                //If no image for the current game exists -> show info label
                if (String.IsNullOrEmpty(gameListEntrys[currentEntry].Image))
                {
                    artworkPictureBox.Image = null;
                    artworkDropLabel.Text = "Drag an image file or image link here";
                    artworkDropLabel.Visible = true;
                }
                else //if an image exists -> try to load
                {
                    try
                    {

                        using (var imgTemp = new Bitmap(localImagePath + "\\" + gameListEntrys[currentEntry].Image))
                        {
                            artworkPictureBox.Image = new Bitmap(imgTemp);
                            artworkDropLabel.Visible = false;
                        }
                    }
                    catch //error handling if unable to load image
                    {
                        MessageBox.Show("Error loading imagefile:\n" + localImagePath + "\\" + gameListEntrys[currentEntry].Image);
                        artworkPictureBox.Image = null;
                        artworkDropLabel.Text = "Drag an image file or image link here";
                        artworkDropLabel.Visible = true;
                    }
                }  //end of load image try


                //enable or disable prev and next buttons based on current position in gamelist
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
                //disable prev and next button if gamelist is empty
                this.prevButton.Enabled = false;
                this.nextButton.Enabled = false;
            }

        }

        /// <summary>
        /// nextButton_Click event -> select next game entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            currentEntry++;            
            FillDataFields();
        }

        /// <summary>
        /// prevButton_Click event -> select previous game entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prevButton_Click(object sender, EventArgs e)
        {
            currentEntry--;            
            FillDataFields();
        }

        /// <summary>
        /// GameEntrysListBox_SelectedIndexChanged -> select entry choosen in ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameEntrysListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //act only if codeTrigered value is false 
            if (!codeTriggered)
            {
                currentEntry = gameEntrysListBox.SelectedIndex;                
                FillDataFields();
            }
            
        }

        /// <summary>
        /// nameTextBox_TextChanged event -> apply entered text to name property of currently selected game entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Name = nameTextBox.Text;
        }

        /// <summary>
        /// descriptionTextBox_TextChanged event -> apply entered text to description property of currently selected game entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Description = descriptionTextBox.Text;
        }

        /// <summary>
        /// imageTextBox_TextChanged event -> apply entered text to image property of currently selected game entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Image = imageTextBox.Text;
        }

        /// <summary>
        /// ratingTextBox_TextChanged event -> apply entered text to rating property of currently selected game entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ratingTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Rating = ratingTextBox.Text;
        }

        /// <summary>
        /// releaseTextBox_TextChanged event -> apply entered text to ReleaseDate property of currently selected game entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void releaseTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].ReleaseDate = releaseTextBox.Text;
        }

        /// <summary>
        /// developerTextBox_TextChanged event -> apply entered text to Developer property of currently selected game entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void developerTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Developer = developerTextBox.Text;
        }

        /// <summary>
        /// PublishertextBox_TextChanged event -> apply entered text to Publisher property of currently selected game entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PublishertextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Publisher = publisherTextBox.Text;
        }

        /// <summary>
        /// genreTextBox_TextChanged event -> apply entered text to Genre property of currently selected game entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genreTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Genre = genreTextBox.Text;
        }

        /// <summary>
        /// playersTextBox_TextChanged event -> apply entered text to Players property of currently selected game entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playersTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Players = playersTextBox.Text;
        }

        /// <summary>
        /// artworkPictureBox_DragEnter event
        /// 
        /// Look for allowed Drag & Drop effects of DragEvent.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void artworkPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            //If copy is allowed set drag effect to copy
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;

            //If link is allowed set drag effect to link
            if ((e.AllowedEffect & DragDropEffects.Link) == DragDropEffects.Link)
                e.Effect = DragDropEffects.Link;
        }

        /// <summary>
        /// Load an image from an url to the PictureBox
        /// </summary>
        /// <param name="imageURL">url of image to load</param>
        /// <returns>returns true on succesful load</returns>
        private bool LoadImageFromURL (string imageURL)
        {
            try //try to load the image
            {
                artworkPictureBox.Image = null; //clean PictureBox

                //Show loading text
                artworkDropLabel.Text = "Loading image...";  
                artworkDropLabel.Visible = true;
                artworkDropLabel.Update();

                //load the image
                artworkPictureBox.Load(imageURL);

                //hide loading text
                artworkDropLabel.Visible = false;
                return true;

            }
            catch //Error handling if something goes wrong while trying to load image
            {
                //Show error in text of artwork box label
                artworkDropLabel.Text = "Error loading image\n" + imageURL;
                return false;
            }
        }

        /// <summary>
        /// Saves the content of the artwork PictureBox to a filename derived from the rom name
        /// </summary>
        private void SaveImageboxToFile()
        {
            bool okToSave = false;
            bool successfullySaved = false;
            string outFilename = localImagePath + "\\" + System.IO.Path.GetFileNameWithoutExtension(gameListEntrys[currentEntry].Path) + "-image.jpg";


            //If file already exists ask user for overwrite OK
            if (System.IO.File.Exists(outFilename))
            {
                DialogResult result;
                result = MessageBox.Show(this, "File " + outFilename + " already exists. Overwrite?", "Warning", MessageBoxButtons.YesNo);

                //If OK to overwrite -> try to delete old file
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        System.IO.File.Delete(outFilename);
                        okToSave = true; //if old file succesfully deleted -> ok to save new file
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("Can't overwrite file " + outFilename + "\n" + exp.ToString());
                    }
                }
            }
            else
            {
                okToSave = true; //if file does not exist -> ok to save new file
            }



            //If ok to save -> try to save new image
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
            else //if not ok to save -> FillDataFields to show old or empty image again
            {
                FillDataFields();
            }

            //if successfully saved -> update Image property in currently selected GameListEntry
            if (successfullySaved)
            {

                gameListEntrys[currentEntry].Image = System.IO.Path.GetFileNameWithoutExtension(gameListEntrys[currentEntry].Path) + "-image.jpg";
                FillDataFields();
            }
        }

        /// <summary>
        /// Drop event wich encounters on Dropping something on the Artwork-PictureBox. Picturebox is filled with an
        /// image if drop event arguments contain an image-filename or an image-url 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void artworkPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            string filename = String.Empty;
            string imageURL = String.Empty;
            bool successfullyLoaded = false;

            //if drop contains a filename, try to load an image from that file
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
            else if (e.Data.GetDataPresent("UnicodeText")) //if drop contains an url dragged from an browser try to load image from that url
            {
                successfullyLoaded = LoadImageFromURL(((IDataObject)e.Data).GetData("UnicodeText").ToString());
            }

            //if an image was succesfully loaded -> try to save that image as new artwork image for the currently selected game
            if (successfullyLoaded)
            {
                SaveImageboxToFile();
            }



        }


        /// <summary>
        /// Resizes an image to a specific width. The height will be determinated automatically to match aspect ratio
        /// </summary>
        /// <param name="image">Source image to resize</param>
        /// <param name="width">Target width for new image</param>
        /// <returns>Returns the resized image</returns>
        private static Bitmap ResizeImageToWidth(Image image, int width)
        {

            //determine new height, create an rectangle and an empty image with the new dimansions
            int height = (int)((float)image.Height / image.Width * width);
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            //set dpi of new image to same dpi as in the old one
            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //do the resize
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

            //return resized Image
            return destImage;
        }


        /// <summary>
        /// Fills the data fields of the form and the properties of currently selected game entry with
        /// data from the game database
        /// </summary>
        /// <param name="gameID">game id for database lookup</param>
        private void FillFormWithGameInfoByID(string gameID)
        {
            //Set info text on status bar
            toolStripStatusLabel.Text = "Lookup game information - please wait";
            this.Update();

            //do the request
            GameEntry tempEntry = GameDatabaseRequest.GetGameEntryByID(gameID);

            //if request was successful -> fill properties and data fields
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

                //if databaseentry contains an image url -> load this image to artwork box and save it locally
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


        /// <summary>
        /// Click event handler for menu item Search->Enter Game ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enterGameIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enterIDForm.ShowDialog();

            if (!enterIDForm.canceled)
            {
                FillFormWithGameInfoByID(enterIDForm.enteredID);
            } 

        }

        /// <summary>
        /// Click event handler for menu item File -> Save gamelist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveGamelistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.SaveGamelist(gameListEntrys, relativeImagePath, gamelistFile);
        }


        /// <summary>
        /// Click event handler for menu item Search -> Search game info in database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchGameInfoInDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //use the rom name of current entry as default Search String
            string searchQuery = System.IO.Path.GetFileNameWithoutExtension(gameListEntrys[currentEntry].Path);

            //if rom name contains a '(' cut off this an everything beyond
            int cutPoint = searchQuery.IndexOf("(");            
            if (cutPoint > 0)
                searchQuery = searchQuery.Substring(0, cutPoint);

            //if remaining string contains a '[' cut off this an everything beyond
            cutPoint = searchQuery.IndexOf("[");
            if (cutPoint > 0)
                searchQuery = searchQuery.Substring(0, cutPoint);

            //use resulting string as default search query
            searchForm.SetSearchQuery(searchQuery);

            //Bring up the form
            searchForm.ShowDialog();

            //if user selected a search result, get the data based on the selected result game id
            if (searchForm.resultSelected)
            {
                FillFormWithGameInfoByID(searchForm.selectedResultID);
            }

        }

        /// <summary>
        /// event handler for "hidden" checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hiddenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            gameListEntrys[currentEntry].Hidden = hiddenCheckBox.Checked;
        }

        

       


    }
}
