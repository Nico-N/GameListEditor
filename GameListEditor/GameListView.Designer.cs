namespace GameListEditor
{
    partial class GameListView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGamelistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterGameIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchGameInfoInDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.developerTextBox = new System.Windows.Forms.TextBox();
            this.releaseTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.playersTextBox = new System.Windows.Forms.TextBox();
            this.hiddenCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.gameEntrysListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.artworkDropLabel = new System.Windows.Forms.Label();
            this.artworkPictureBox = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artworkPictureBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGamelistToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveGamelistToolStripMenuItem
            // 
            this.saveGamelistToolStripMenuItem.Name = "saveGamelistToolStripMenuItem";
            this.saveGamelistToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveGamelistToolStripMenuItem.Text = "Save Gamelist";
            this.saveGamelistToolStripMenuItem.Click += new System.EventHandler(this.saveGamelistToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterGameIDToolStripMenuItem,
            this.searchGameInfoInDatabaseToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // enterGameIDToolStripMenuItem
            // 
            this.enterGameIDToolStripMenuItem.Name = "enterGameIDToolStripMenuItem";
            this.enterGameIDToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.enterGameIDToolStripMenuItem.Text = "Enter Game ID";
            this.enterGameIDToolStripMenuItem.Click += new System.EventHandler(this.enterGameIDToolStripMenuItem_Click);
            // 
            // searchGameInfoInDatabaseToolStripMenuItem
            // 
            this.searchGameInfoInDatabaseToolStripMenuItem.Name = "searchGameInfoInDatabaseToolStripMenuItem";
            this.searchGameInfoInDatabaseToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.searchGameInfoInDatabaseToolStripMenuItem.Text = "Search Game Info in Database";
            this.searchGameInfoInDatabaseToolStripMenuItem.Click += new System.EventHandler(this.searchGameInfoInDatabaseToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(811, 412);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.genreTextBox, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.publisherTextBox, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.developerTextBox, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.releaseTextBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.ratingTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.imageTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.descriptionTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.nameTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.pathTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 9);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.663998F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.663998F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.02401F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.663998F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.663998F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.663998F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.663998F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.663998F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.663998F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.663998F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(467, 406);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // genreTextBox
            // 
            this.genreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.genreTextBox.Location = new System.Drawing.Point(98, 345);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(366, 20);
            this.genreTextBox.TabIndex = 18;
            this.genreTextBox.TextChanged += new System.EventHandler(this.genreTextBox_TextChanged);
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.publisherTextBox.Location = new System.Drawing.Point(98, 319);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(366, 20);
            this.publisherTextBox.TabIndex = 17;
            this.publisherTextBox.TextChanged += new System.EventHandler(this.PublishertextBox_TextChanged);
            // 
            // developerTextBox
            // 
            this.developerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.developerTextBox.Location = new System.Drawing.Point(98, 293);
            this.developerTextBox.Name = "developerTextBox";
            this.developerTextBox.Size = new System.Drawing.Size(366, 20);
            this.developerTextBox.TabIndex = 16;
            this.developerTextBox.TextChanged += new System.EventHandler(this.developerTextBox_TextChanged);
            // 
            // releaseTextBox
            // 
            this.releaseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.releaseTextBox.Location = new System.Drawing.Point(98, 267);
            this.releaseTextBox.Name = "releaseTextBox";
            this.releaseTextBox.Size = new System.Drawing.Size(366, 20);
            this.releaseTextBox.TabIndex = 15;
            this.releaseTextBox.TextChanged += new System.EventHandler(this.releaseTextBox_TextChanged);
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ratingTextBox.Location = new System.Drawing.Point(98, 241);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(366, 20);
            this.ratingTextBox.TabIndex = 14;
            this.ratingTextBox.TextChanged += new System.EventHandler(this.ratingTextBox_TextChanged);
            // 
            // imageTextBox
            // 
            this.imageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imageTextBox.Location = new System.Drawing.Point(98, 215);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(366, 20);
            this.imageTextBox.TabIndex = 13;
            this.imageTextBox.TextChanged += new System.EventHandler(this.imageTextBox_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(98, 55);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(366, 154);
            this.descriptionTextBox.TabIndex = 12;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(98, 29);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(366, 20);
            this.nameTextBox.TabIndex = 11;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 160);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Image";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rating";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Release Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Developer";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "Publisher";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "Genre";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 26);
            this.label10.TabIndex = 9;
            this.label10.Text = "Players";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextBox.Location = new System.Drawing.Point(98, 3);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(366, 20);
            this.pathTextBox.TabIndex = 10;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel5.Controls.Add(this.playersTextBox, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.hiddenCheckBox, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label11, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(95, 368);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(372, 26);
            this.tableLayoutPanel5.TabIndex = 19;
            // 
            // playersTextBox
            // 
            this.playersTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersTextBox.Location = new System.Drawing.Point(3, 3);
            this.playersTextBox.Name = "playersTextBox";
            this.playersTextBox.Size = new System.Drawing.Size(146, 20);
            this.playersTextBox.TabIndex = 19;
            this.playersTextBox.TextChanged += new System.EventHandler(this.playersTextBox_TextChanged);
            // 
            // hiddenCheckBox
            // 
            this.hiddenCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hiddenCheckBox.AutoSize = true;
            this.hiddenCheckBox.Location = new System.Drawing.Point(205, 6);
            this.hiddenCheckBox.Name = "hiddenCheckBox";
            this.hiddenCheckBox.Size = new System.Drawing.Size(14, 14);
            this.hiddenCheckBox.TabIndex = 20;
            this.hiddenCheckBox.UseVisualStyleBackColor = true;
            this.hiddenCheckBox.CheckedChanged += new System.EventHandler(this.hiddenCheckBox_CheckedChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(225, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Hide rom in gamelist";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.gameEntrysListBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(476, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(332, 406);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.nextButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.prevButton, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 363);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(326, 34);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.Location = new System.Drawing.Point(166, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(157, 28);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Next >>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prevButton.Location = new System.Drawing.Point(3, 3);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(157, 28);
            this.prevButton.TabIndex = 1;
            this.prevButton.Text = "<< Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // gameEntrysListBox
            // 
            this.gameEntrysListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameEntrysListBox.FormattingEnabled = true;
            this.gameEntrysListBox.Location = new System.Drawing.Point(3, 183);
            this.gameEntrysListBox.Name = "gameEntrysListBox";
            this.gameEntrysListBox.Size = new System.Drawing.Size(326, 173);
            this.gameEntrysListBox.TabIndex = 1;
            this.gameEntrysListBox.SelectedIndexChanged += new System.EventHandler(this.GameEntrysListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.artworkDropLabel);
            this.panel1.Controls.Add(this.artworkPictureBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 174);
            this.panel1.TabIndex = 2;
            // 
            // artworkDropLabel
            // 
            this.artworkDropLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.artworkDropLabel.Location = new System.Drawing.Point(0, 0);
            this.artworkDropLabel.Name = "artworkDropLabel";
            this.artworkDropLabel.Size = new System.Drawing.Size(326, 47);
            this.artworkDropLabel.TabIndex = 2;
            this.artworkDropLabel.Text = "Drag an image file or image link here";
            this.artworkDropLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.artworkDropLabel.Visible = false;
            // 
            // artworkPictureBox
            // 
            this.artworkPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artworkPictureBox.Location = new System.Drawing.Point(0, 0);
            this.artworkPictureBox.Name = "artworkPictureBox";
            this.artworkPictureBox.Size = new System.Drawing.Size(326, 174);
            this.artworkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.artworkPictureBox.TabIndex = 1;
            this.artworkPictureBox.TabStop = false;
            this.artworkPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.artworkPictureBox_DragDrop);
            this.artworkPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.artworkPictureBox_DragEnter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(829, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // GameListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 451);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameListView";
            this.Text = "GameListView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.artworkPictureBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGamelistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox playersTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox developerTextBox;
        private System.Windows.Forms.TextBox releaseTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.ListBox gameEntrysListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox artworkPictureBox;
        private System.Windows.Forms.Label artworkDropLabel;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterGameIDToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem searchGameInfoInDatabaseToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox hiddenCheckBox;
        private System.Windows.Forms.Label label11;
    }
}