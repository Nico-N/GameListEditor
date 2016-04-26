using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameListEditor
{
    public partial class GameSearchForm : Form
    {

        public bool resultSelected { get; set; }
        public string selectedResultID { get; set; }

        public GameSearchForm()
        {
            InitializeComponent();

            resultSelected = false;

            systemComboBox.Items.Add("All Platforms");
            systemComboBox.Items.Add("3DO");
            systemComboBox.Items.Add("Amiga");
            systemComboBox.Items.Add("Amiga CD32");
            systemComboBox.Items.Add("Amstrad CPC");
            systemComboBox.Items.Add("Apple II");
            systemComboBox.Items.Add("Arcade");
            systemComboBox.Items.Add("Atari 2600");
            systemComboBox.Items.Add("Atari 5200");
            systemComboBox.Items.Add("Atari 7800");
            systemComboBox.Items.Add("Atari Jaguar");
            systemComboBox.Items.Add("Atari Jaguar CD");
            systemComboBox.Items.Add("Atari Lynx");
            systemComboBox.Items.Add("Atari ST");
            systemComboBox.Items.Add("Atari XE");
            systemComboBox.Items.Add("Commodore 64");
            systemComboBox.Items.Add("Dragon 32/64");
            systemComboBox.Items.Add("Intellivision");
            systemComboBox.Items.Add("Magnavox Odyssey 2");
            systemComboBox.Items.Add("MSX");
            systemComboBox.Items.Add("Neo Geo Pocket");
            systemComboBox.Items.Add("Neo Geo Pocket Color");
            systemComboBox.Items.Add("NeoGeo");
            systemComboBox.Items.Add("Nintendo 64");
            systemComboBox.Items.Add("Nintendo DS");
            systemComboBox.Items.Add("Nintendo Entertainment System (NES)");
            systemComboBox.Items.Add("Nintendo Game Boy");
            systemComboBox.Items.Add("Nintendo Game Boy Advance");
            systemComboBox.Items.Add("Nintendo Game Boy Color");
            systemComboBox.Items.Add("Nintendo Virtual Boy");
            systemComboBox.Items.Add("PC");
            systemComboBox.Items.Add("Sega 32X");
            systemComboBox.Items.Add("Sega CD");
            systemComboBox.Items.Add("Sega Dreamcast");
            systemComboBox.Items.Add("Sega Game Gear");
            systemComboBox.Items.Add("Sega Genesis");
            systemComboBox.Items.Add("Sega Master System");
            systemComboBox.Items.Add("Sega Mega Drive");
            systemComboBox.Items.Add("Sega Saturn");
            systemComboBox.Items.Add("SEGA SG-1000");
            systemComboBox.Items.Add("Sinclair ZX Spectrum");
            systemComboBox.Items.Add("Sony Playstation");
            systemComboBox.Items.Add("Sony PSP");
            systemComboBox.Items.Add("Super Nintendo (SNES)");
            systemComboBox.Items.Add("TRS-80 Color Computer");
            systemComboBox.Items.Add("Turbo Grafx 16 CD");
            systemComboBox.Items.Add("TurboGrafx 16");
            systemComboBox.Items.Add("Vectrex");
            systemComboBox.Items.Add("WonderSwan");
            systemComboBox.Items.Add("WonderSwan Color");

            systemComboBox.Text = "All Platforms";



        }

        public void SetSearchQuery(string searchQuery)
        {
            searchQueryTextBox.Text = searchQuery;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            searchButton.Text = "Searching...";
            searchButton.Enabled = false;
            searchButton.Update();

            searchResultListView.Items.Clear();

            string searchString = searchQueryTextBox.Text;
            string[] tempListItem = new string[4];

            GameSearchItem[] searchResult;

            if (systemComboBox.Text == "All Platforms")
                searchResult = GameDatabaseRequest.GetSearchQueryResult(searchString, null);
            else
                searchResult = GameDatabaseRequest.GetSearchQueryResult(searchString, systemComboBox.Text);


            if (searchResult.Length > 0)
            {
                foreach (GameSearchItem item in searchResult)
                {
                    tempListItem[0] = item.ID;
                    tempListItem[1] = item.Name;
                    tempListItem[2] = item.ReleaseDate;
                    tempListItem[3] = item.Platform;

                    ListViewItem itm = new ListViewItem(tempListItem);
                    searchResultListView.Items.Add(itm);
                }
            }
            else
            {
                tempListItem[0] = "";
                tempListItem[1] = "Nothing found :-(";
                tempListItem[2] = "";
                tempListItem[3] = "";

                ListViewItem itm = new ListViewItem(tempListItem);
                searchResultListView.Items.Add(itm);
            }

            searchButton.Text = "Search";
            searchButton.Enabled = true;

        }

        private void GameSearchForm_Activated(object sender, EventArgs e)
        {
            
        }

        private void GameSearchForm_Shown(object sender, EventArgs e)
        {
            searchResultListView.Items.Clear();
            resultSelected = false;
        }

        private void searchResultListView_DoubleClick(object sender, EventArgs e)
        {
            if (searchResultListView.SelectedItems.Count > 0)
            {
                ListViewItem item = searchResultListView.SelectedItems[0];
                selectedResultID = item.SubItems[0].Text;

                if (!String.IsNullOrEmpty(selectedResultID))
                {
                    resultSelected = true;
                    this.Close();
                }
            }
        }
    }
}
