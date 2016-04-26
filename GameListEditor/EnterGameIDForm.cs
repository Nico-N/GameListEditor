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
    public partial class EnterGameIDForm : Form
    {

        public bool canceled { get; set; }
        public string enteredID { get; set; }

        public EnterGameIDForm()
        {
            InitializeComponent();
            canceled = false;            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            canceled = true;
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            canceled = false;
            enteredID = idTextbox.Text;
            this.Close();
        }

        private void EnterGameIDForm_Activated(object sender, EventArgs e)
        {
            this.ActiveControl = idTextbox;
        }
    }
}
