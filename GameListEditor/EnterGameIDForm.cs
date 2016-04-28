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
    /// <summary>
    /// Dialog form for entering a game id. 
    /// If user enters a game id property eneredID will be set to this id.
    /// If user cancels input property canceled will be set true
    /// </summary>
    public partial class EnterGameIDForm : Form
    {

        public bool canceled { get; set; } //indicates that the user canceled the dialog
        public string enteredID { get; set; } //property wich holds the user input

        /// <summary>
        /// Constructor for the dialog
        /// </summary>
        public EnterGameIDForm()
        {
            InitializeComponent();
            canceled = false;            
        }

        /// <summary>
        /// Event handler for cancel click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            canceled = true;
            this.Close();
        }

        /// <summary>
        /// Event handler for ok click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            canceled = false;
            enteredID = idTextbox.Text;
            this.Close();
        }

        /// <summary>
        /// Event handler called when dialog is activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterGameIDForm_Activated(object sender, EventArgs e)
        {
            //set idTextbox as active control
            this.ActiveControl = idTextbox;
        }
    }
}
