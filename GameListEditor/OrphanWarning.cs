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
    public partial class OrphanWarning : Form
    {
        public OrphanWarning(List<string> orphanRoms)
        {
            InitializeComponent();

            warningLabel.Text = "The existing gamelist.xml file contains information about one or more rom(s) wich are not part of the rom directory.\n\nWhen saving the gamelist only existing roms will be saved to the new gamelist file.\n\nInformation about the roms listed below will be discarded.";

            foreach (string rom in orphanRoms)
                romListView.Items.Add(rom);
            


        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
