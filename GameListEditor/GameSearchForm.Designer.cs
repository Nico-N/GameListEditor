namespace GameListEditor
{
    partial class GameSearchForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchQueryTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.systemComboBox = new System.Windows.Forms.ComboBox();
            this.searchResultListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Release = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Platform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchResultListView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(823, 391);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel2.Controls.Add(this.searchButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(817, 49);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Location = new System.Drawing.Point(699, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(115, 43);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchQueryTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 43);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search query";
            // 
            // searchQueryTextBox
            // 
            this.searchQueryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchQueryTextBox.Location = new System.Drawing.Point(3, 16);
            this.searchQueryTextBox.Name = "searchQueryTextBox";
            this.searchQueryTextBox.Size = new System.Drawing.Size(336, 20);
            this.searchQueryTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.systemComboBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(351, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 43);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Platform";
            // 
            // systemComboBox
            // 
            this.systemComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.systemComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.systemComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.systemComboBox.FormattingEnabled = true;
            this.systemComboBox.Location = new System.Drawing.Point(3, 16);
            this.systemComboBox.Name = "systemComboBox";
            this.systemComboBox.Size = new System.Drawing.Size(336, 21);
            this.systemComboBox.TabIndex = 0;
            // 
            // searchResultListView
            // 
            this.searchResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Title,
            this.Release,
            this.Platform});
            this.searchResultListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResultListView.FullRowSelect = true;
            this.searchResultListView.GridLines = true;
            this.searchResultListView.Location = new System.Drawing.Point(3, 58);
            this.searchResultListView.MultiSelect = false;
            this.searchResultListView.Name = "searchResultListView";
            this.searchResultListView.Size = new System.Drawing.Size(817, 330);
            this.searchResultListView.TabIndex = 1;
            this.searchResultListView.UseCompatibleStateImageBehavior = false;
            this.searchResultListView.View = System.Windows.Forms.View.Details;
            this.searchResultListView.DoubleClick += new System.EventHandler(this.searchResultListView_DoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 388;
            // 
            // Release
            // 
            this.Release.Text = "Release";
            this.Release.Width = 100;
            // 
            // Platform
            // 
            this.Platform.Text = "Platform";
            this.Platform.Width = 246;
            // 
            // GameSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 391);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameSearchForm";
            this.Text = "Search Game";
            this.Activated += new System.EventHandler(this.GameSearchForm_Activated);
            this.Shown += new System.EventHandler(this.GameSearchForm_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchQueryTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox systemComboBox;
        private System.Windows.Forms.ListView searchResultListView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Release;
        private System.Windows.Forms.ColumnHeader Platform;
    }
}