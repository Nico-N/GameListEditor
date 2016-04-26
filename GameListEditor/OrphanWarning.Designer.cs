namespace GameListEditor
{
    partial class OrphanWarning
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.romListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.okButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.warningLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.romListView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 405);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.Location = new System.Drawing.Point(3, 372);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(328, 30);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK, I understand";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warningLabel.Location = new System.Drawing.Point(3, 0);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(328, 129);
            this.warningLabel.TabIndex = 1;
            this.warningLabel.Text = "The existing gamelist.xml file contains information about one or more rom(s) wich" +
    " are not part of the rom directory. ";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // romListView
            // 
            this.romListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.romListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.romListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.romListView.Location = new System.Drawing.Point(3, 132);
            this.romListView.Name = "romListView";
            this.romListView.Size = new System.Drawing.Size(328, 234);
            this.romListView.TabIndex = 2;
            this.romListView.UseCompatibleStateImageBehavior = false;
            this.romListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "rom name";
            this.columnHeader1.Width = 300;
            // 
            // OrphanWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 405);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrphanWarning";
            this.Text = "Warning - Possible Data Loss";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.ListView romListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;

    }
}