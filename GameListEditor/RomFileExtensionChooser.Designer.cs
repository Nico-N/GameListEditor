namespace GameListEditor
{
    partial class RomFileExtensionChooser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RomFileExtensionChooser));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.extensionListView = new System.Windows.Forms.ListView();
            this.SystemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RomFileExtensions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.selectNoneButton = new System.Windows.Forms.Button();
            this.invertSelectionButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.okButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.extensionListView, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.warningLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(651, 359);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.Location = new System.Drawing.Point(3, 327);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(645, 29);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // extensionListView
            // 
            this.extensionListView.CheckBoxes = true;
            this.extensionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SystemName,
            this.RomFileExtensions});
            this.extensionListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extensionListView.GridLines = true;
            this.extensionListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.extensionListView.Location = new System.Drawing.Point(3, 108);
            this.extensionListView.Name = "extensionListView";
            this.extensionListView.Size = new System.Drawing.Size(645, 213);
            this.extensionListView.TabIndex = 2;
            this.extensionListView.UseCompatibleStateImageBehavior = false;
            this.extensionListView.View = System.Windows.Forms.View.Details;
            // 
            // SystemName
            // 
            this.SystemName.Width = 230;
            // 
            // RomFileExtensions
            // 
            this.RomFileExtensions.Width = 390;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // warningLabel
            // 
            this.warningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(3, 56);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(645, 13);
            this.warningLabel.TabIndex = 3;
            this.warningLabel.Text = "Warning - Default values used. If you provide an es_systems.cfg file, rom extensi" +
    "ons provided from this file will be used.";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.invertSelectionButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.selectNoneButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.selectAllButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 75);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(651, 30);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // selectAllButton
            // 
            this.selectAllButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectAllButton.Location = new System.Drawing.Point(3, 3);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(210, 24);
            this.selectAllButton.TabIndex = 0;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // selectNoneButton
            // 
            this.selectNoneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectNoneButton.Location = new System.Drawing.Point(219, 3);
            this.selectNoneButton.Name = "selectNoneButton";
            this.selectNoneButton.Size = new System.Drawing.Size(210, 24);
            this.selectNoneButton.TabIndex = 1;
            this.selectNoneButton.Text = "Select None";
            this.selectNoneButton.UseVisualStyleBackColor = true;
            this.selectNoneButton.Click += new System.EventHandler(this.selectNoneButton_Click);
            // 
            // invertSelectionButton
            // 
            this.invertSelectionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invertSelectionButton.Location = new System.Drawing.Point(435, 3);
            this.invertSelectionButton.Name = "invertSelectionButton";
            this.invertSelectionButton.Size = new System.Drawing.Size(213, 24);
            this.invertSelectionButton.TabIndex = 2;
            this.invertSelectionButton.Text = "Invert Selection";
            this.invertSelectionButton.UseVisualStyleBackColor = true;
            this.invertSelectionButton.Click += new System.EventHandler(this.invertSelectionButton_Click);
            // 
            // RomFileExtensionChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 359);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RomFileExtensionChooser";
            this.Text = "Choose rom file extensions...";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ListView extensionListView;
        private System.Windows.Forms.ColumnHeader SystemName;
        private System.Windows.Forms.ColumnHeader RomFileExtensions;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button invertSelectionButton;
        private System.Windows.Forms.Button selectNoneButton;
        private System.Windows.Forms.Button selectAllButton;
    }
}