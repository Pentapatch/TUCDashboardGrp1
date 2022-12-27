namespace TUCDashboardGrp1
{
    partial class AdminTools
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
            this.feedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_feed = new System.Windows.Forms.TabPage();
            this.listview_feed = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btn_feed_clear = new System.Windows.Forms.Button();
            this.btn_feed_clearImage = new System.Windows.Forms.Button();
            this.btn_feed_submit = new System.Windows.Forms.Button();
            this.picturebox_feed_preview = new System.Windows.Forms.PictureBox();
            this.btn_feed_browseForImage = new System.Windows.Forms.Button();
            this.textbox_feed_content = new System.Windows.Forms.TextBox();
            this.textbox_feed_header = new System.Windows.Forms.TextBox();
            this.label_feed_img = new System.Windows.Forms.Label();
            this.label_feed_content = new System.Windows.Forms.Label();
            this.label_feed_header = new System.Windows.Forms.Label();
            this.tab_booking = new System.Windows.Forms.TabPage();
            this.textBox_booked_for = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_confirm_booking = new System.Windows.Forms.Button();
            this.label_room = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_stop_time = new System.Windows.Forms.Label();
            this.label_start_time = new System.Windows.Forms.Label();
            this.dateTimePicker_stop = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.textBox_booked_by = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.btn_settings_openInExplorer = new System.Windows.Forms.Button();
            this.label_settings = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_feed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_feed_preview)).BeginInit();
            this.tab_booking.SuspendLayout();
            this.tab_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feedToolStripMenuItem,
            this.bookingsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(149, 620);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // feedToolStripMenuItem
            // 
            this.feedToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.feedToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.feedToolStripMenuItem.Name = "feedToolStripMenuItem";
            this.feedToolStripMenuItem.Size = new System.Drawing.Size(140, 32);
            this.feedToolStripMenuItem.Tag = "0";
            this.feedToolStripMenuItem.Text = "&Flöde";
            this.feedToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(140, 32);
            this.bookingsToolStripMenuItem.Tag = "1";
            this.bookingsToolStripMenuItem.Text = "&Bokningar";
            this.bookingsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(140, 32);
            this.settingsToolStripMenuItem.Tag = "2";
            this.settingsToolStripMenuItem.Text = "Inställninga&r";
            this.settingsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_feed);
            this.tabControl1.Controls.Add(this.tab_booking);
            this.tabControl1.Controls.Add(this.tab_settings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(149, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1244, 620);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_feed
            // 
            this.tab_feed.Controls.Add(this.listview_feed);
            this.tab_feed.Controls.Add(this.btn_feed_clear);
            this.tab_feed.Controls.Add(this.btn_feed_clearImage);
            this.tab_feed.Controls.Add(this.btn_feed_submit);
            this.tab_feed.Controls.Add(this.picturebox_feed_preview);
            this.tab_feed.Controls.Add(this.btn_feed_browseForImage);
            this.tab_feed.Controls.Add(this.textbox_feed_content);
            this.tab_feed.Controls.Add(this.textbox_feed_header);
            this.tab_feed.Controls.Add(this.label_feed_img);
            this.tab_feed.Controls.Add(this.label_feed_content);
            this.tab_feed.Controls.Add(this.label_feed_header);
            this.tab_feed.Location = new System.Drawing.Point(4, 29);
            this.tab_feed.Margin = new System.Windows.Forms.Padding(2);
            this.tab_feed.Name = "tab_feed";
            this.tab_feed.Padding = new System.Windows.Forms.Padding(2);
            this.tab_feed.Size = new System.Drawing.Size(1236, 587);
            this.tab_feed.TabIndex = 0;
            this.tab_feed.Text = "Flöde";
            this.tab_feed.UseVisualStyleBackColor = true;
            // 
            // listview_feed
            // 
            this.listview_feed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listview_feed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listview_feed.FullRowSelect = true;
            this.listview_feed.Location = new System.Drawing.Point(368, 12);
            this.listview_feed.Name = "listview_feed";
            this.listview_feed.Size = new System.Drawing.Size(860, 558);
            this.listview_feed.TabIndex = 12;
            this.listview_feed.UseCompatibleStateImageBehavior = false;
            this.listview_feed.View = System.Windows.Forms.View.Details;
            this.listview_feed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Feed_ListView_KeyDown);
            this.listview_feed.Leave += new System.EventHandler(this.Feed_ListView_Leave);
            this.listview_feed.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FeedListView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rubrik";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Innehåll";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bild";
            this.columnHeader3.Width = 400;
            // 
            // btn_feed_clear
            // 
            this.btn_feed_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_feed_clear.Location = new System.Drawing.Point(175, 541);
            this.btn_feed_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_feed_clear.Name = "btn_feed_clear";
            this.btn_feed_clear.Size = new System.Drawing.Size(109, 29);
            this.btn_feed_clear.TabIndex = 5;
            this.btn_feed_clear.Text = "&Rensa form";
            this.btn_feed_clear.UseVisualStyleBackColor = true;
            this.btn_feed_clear.Click += new System.EventHandler(this.Feed_ClearForm_Click);
            // 
            // btn_feed_clearImage
            // 
            this.btn_feed_clearImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_feed_clearImage.Location = new System.Drawing.Point(175, 216);
            this.btn_feed_clearImage.Margin = new System.Windows.Forms.Padding(2);
            this.btn_feed_clearImage.Name = "btn_feed_clearImage";
            this.btn_feed_clearImage.Size = new System.Drawing.Size(108, 28);
            this.btn_feed_clearImage.TabIndex = 3;
            this.btn_feed_clearImage.Text = "R&ensa bild..";
            this.btn_feed_clearImage.UseVisualStyleBackColor = true;
            this.btn_feed_clearImage.Click += new System.EventHandler(this.Feed_ClearImage_Click);
            // 
            // btn_feed_submit
            // 
            this.btn_feed_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_feed_submit.Location = new System.Drawing.Point(79, 541);
            this.btn_feed_submit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_feed_submit.Name = "btn_feed_submit";
            this.btn_feed_submit.Size = new System.Drawing.Size(92, 29);
            this.btn_feed_submit.TabIndex = 4;
            this.btn_feed_submit.Text = "&Lägg till";
            this.btn_feed_submit.UseVisualStyleBackColor = true;
            this.btn_feed_submit.Click += new System.EventHandler(this.Feed_Submit_Click);
            // 
            // picturebox_feed_preview
            // 
            this.picturebox_feed_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picturebox_feed_preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picturebox_feed_preview.Location = new System.Drawing.Point(79, 257);
            this.picturebox_feed_preview.Margin = new System.Windows.Forms.Padding(2);
            this.picturebox_feed_preview.Name = "picturebox_feed_preview";
            this.picturebox_feed_preview.Size = new System.Drawing.Size(270, 270);
            this.picturebox_feed_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox_feed_preview.TabIndex = 6;
            this.picturebox_feed_preview.TabStop = false;
            // 
            // btn_feed_browseForImage
            // 
            this.btn_feed_browseForImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_feed_browseForImage.Location = new System.Drawing.Point(79, 216);
            this.btn_feed_browseForImage.Margin = new System.Windows.Forms.Padding(2);
            this.btn_feed_browseForImage.Name = "btn_feed_browseForImage";
            this.btn_feed_browseForImage.Size = new System.Drawing.Size(92, 28);
            this.btn_feed_browseForImage.TabIndex = 2;
            this.btn_feed_browseForImage.Text = "&Bläddra..";
            this.btn_feed_browseForImage.UseVisualStyleBackColor = true;
            this.btn_feed_browseForImage.Click += new System.EventHandler(this.Feed_BrowseForImage_Click);
            // 
            // textbox_feed_content
            // 
            this.textbox_feed_content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textbox_feed_content.Location = new System.Drawing.Point(79, 52);
            this.textbox_feed_content.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_feed_content.Multiline = true;
            this.textbox_feed_content.Name = "textbox_feed_content";
            this.textbox_feed_content.Size = new System.Drawing.Size(270, 144);
            this.textbox_feed_content.TabIndex = 1;
            this.textbox_feed_content.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Feed_Textboxes_KeyDown);
            // 
            // textbox_feed_header
            // 
            this.textbox_feed_header.Location = new System.Drawing.Point(79, 12);
            this.textbox_feed_header.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_feed_header.Name = "textbox_feed_header";
            this.textbox_feed_header.Size = new System.Drawing.Size(270, 27);
            this.textbox_feed_header.TabIndex = 0;
            this.textbox_feed_header.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Feed_Textboxes_KeyDown);
            // 
            // label_feed_img
            // 
            this.label_feed_img.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_feed_img.AutoSize = true;
            this.label_feed_img.Location = new System.Drawing.Point(14, 220);
            this.label_feed_img.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_feed_img.Name = "label_feed_img";
            this.label_feed_img.Size = new System.Drawing.Size(38, 20);
            this.label_feed_img.TabIndex = 2;
            this.label_feed_img.Text = "Bild:";
            // 
            // label_feed_content
            // 
            this.label_feed_content.AutoSize = true;
            this.label_feed_content.Location = new System.Drawing.Point(14, 52);
            this.label_feed_content.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_feed_content.Name = "label_feed_content";
            this.label_feed_content.Size = new System.Drawing.Size(64, 20);
            this.label_feed_content.TabIndex = 1;
            this.label_feed_content.Text = "&Innehåll:";
            // 
            // label_feed_header
            // 
            this.label_feed_header.AutoSize = true;
            this.label_feed_header.Location = new System.Drawing.Point(14, 17);
            this.label_feed_header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_feed_header.Name = "label_feed_header";
            this.label_feed_header.Size = new System.Drawing.Size(54, 20);
            this.label_feed_header.TabIndex = 0;
            this.label_feed_header.Text = "R&ubrik:";
            // 
            // tab_booking
            // 
            this.tab_booking.Controls.Add(this.textBox_booked_for);
            this.tab_booking.Controls.Add(this.label1);
            this.tab_booking.Controls.Add(this.button_confirm_booking);
            this.tab_booking.Controls.Add(this.label_room);
            this.tab_booking.Controls.Add(this.comboBox1);
            this.tab_booking.Controls.Add(this.label_stop_time);
            this.tab_booking.Controls.Add(this.label_start_time);
            this.tab_booking.Controls.Add(this.dateTimePicker_stop);
            this.tab_booking.Controls.Add(this.dateTimePicker_start);
            this.tab_booking.Controls.Add(this.textBox_booked_by);
            this.tab_booking.Controls.Add(this.label_name);
            this.tab_booking.Location = new System.Drawing.Point(4, 29);
            this.tab_booking.Margin = new System.Windows.Forms.Padding(2);
            this.tab_booking.Name = "tab_booking";
            this.tab_booking.Padding = new System.Windows.Forms.Padding(2);
            this.tab_booking.Size = new System.Drawing.Size(1236, 587);
            this.tab_booking.TabIndex = 1;
            this.tab_booking.Text = "Bokningar";
            this.tab_booking.UseVisualStyleBackColor = true;
            // 
            // textBox_booked_for
            // 
            this.textBox_booked_for.Location = new System.Drawing.Point(116, 15);
            this.textBox_booked_for.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_booked_for.Name = "textBox_booked_for";
            this.textBox_booked_for.Size = new System.Drawing.Size(125, 27);
            this.textBox_booked_for.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bokad för:";
            // 
            // button_confirm_booking
            // 
            this.button_confirm_booking.Location = new System.Drawing.Point(114, 345);
            this.button_confirm_booking.Margin = new System.Windows.Forms.Padding(2);
            this.button_confirm_booking.Name = "button_confirm_booking";
            this.button_confirm_booking.Size = new System.Drawing.Size(101, 29);
            this.button_confirm_booking.TabIndex = 8;
            this.button_confirm_booking.Text = "Boka";
            this.button_confirm_booking.UseVisualStyleBackColor = true;
            // 
            // label_room
            // 
            this.label_room.AutoSize = true;
            this.label_room.Location = new System.Drawing.Point(14, 249);
            this.label_room.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_room.Name = "label_room";
            this.label_room.Size = new System.Drawing.Size(72, 20);
            this.label_room.TabIndex = 7;
            this.label_room.Text = "Rum/ Sal:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "G1",
            "G2",
            "G3",
            "G4",
            "G5",
            "G6",
            "G7",
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "A8",
            "A9"});
            this.comboBox1.Location = new System.Drawing.Point(114, 249);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Välj rum..";
            // 
            // label_stop_time
            // 
            this.label_stop_time.AutoSize = true;
            this.label_stop_time.Location = new System.Drawing.Point(14, 177);
            this.label_stop_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_stop_time.Name = "label_stop_time";
            this.label_stop_time.Size = new System.Drawing.Size(32, 20);
            this.label_stop_time.TabIndex = 5;
            this.label_stop_time.Text = "Till:";
            // 
            // label_start_time
            // 
            this.label_start_time.AutoSize = true;
            this.label_start_time.Location = new System.Drawing.Point(14, 126);
            this.label_start_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_start_time.Name = "label_start_time";
            this.label_start_time.Size = new System.Drawing.Size(40, 20);
            this.label_start_time.TabIndex = 4;
            this.label_start_time.Text = "Från:";
            // 
            // dateTimePicker_stop
            // 
            this.dateTimePicker_stop.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker_stop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_stop.Location = new System.Drawing.Point(114, 173);
            this.dateTimePicker_stop.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_stop.Name = "dateTimePicker_stop";
            this.dateTimePicker_stop.Size = new System.Drawing.Size(248, 27);
            this.dateTimePicker_stop.TabIndex = 3;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_start.Location = new System.Drawing.Point(114, 123);
            this.dateTimePicker_start.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(248, 27);
            this.dateTimePicker_start.TabIndex = 2;
            // 
            // textBox_booked_by
            // 
            this.textBox_booked_by.Location = new System.Drawing.Point(114, 68);
            this.textBox_booked_by.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_booked_by.Name = "textBox_booked_by";
            this.textBox_booked_by.Size = new System.Drawing.Size(125, 27);
            this.textBox_booked_by.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(14, 68);
            this.label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(73, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Bokad av:";
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.btn_settings_openInExplorer);
            this.tab_settings.Controls.Add(this.label_settings);
            this.tab_settings.Location = new System.Drawing.Point(4, 29);
            this.tab_settings.Margin = new System.Windows.Forms.Padding(2);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(2);
            this.tab_settings.Size = new System.Drawing.Size(1236, 587);
            this.tab_settings.TabIndex = 2;
            this.tab_settings.Text = "Inställningar";
            this.tab_settings.UseVisualStyleBackColor = true;
            // 
            // btn_settings_openInExplorer
            // 
            this.btn_settings_openInExplorer.Location = new System.Drawing.Point(70, 85);
            this.btn_settings_openInExplorer.Name = "btn_settings_openInExplorer";
            this.btn_settings_openInExplorer.Size = new System.Drawing.Size(155, 29);
            this.btn_settings_openInExplorer.TabIndex = 1;
            this.btn_settings_openInExplorer.Text = "Ö&ppna i explorer";
            this.btn_settings_openInExplorer.UseVisualStyleBackColor = true;
            this.btn_settings_openInExplorer.Click += new System.EventHandler(this.btn_settings_openInExplorer_Click);
            // 
            // label_settings
            // 
            this.label_settings.AutoSize = true;
            this.label_settings.Location = new System.Drawing.Point(70, 51);
            this.label_settings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_settings.Name = "label_settings";
            this.label_settings.Size = new System.Drawing.Size(216, 20);
            this.label_settings.TabIndex = 0;
            this.label_settings.Text = "Inställningar är tom för tillfället";
            // 
            // AdminTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 620);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "AdminTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminTools";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_feed.ResumeLayout(false);
            this.tab_feed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_feed_preview)).EndInit();
            this.tab_booking.ResumeLayout(false);
            this.tab_booking.PerformLayout();
            this.tab_settings.ResumeLayout(false);
            this.tab_settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem feedToolStripMenuItem;
        private ToolStripMenuItem bookingsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tab_feed;
        private TabPage tab_booking;
        private Button btn_feed_submit;
        private PictureBox picturebox_feed_preview;
        private Button btn_feed_browseForImage;
        private TextBox textbox_feed_content;
        private TextBox textbox_feed_header;
        private Label label_feed_img;
        private Label label_feed_content;
        private Label label_feed_header;
        private TextBox textBox_booked_by;
        private Label label_name;
        private DateTimePicker dateTimePicker_start;
        private DateTimePicker dateTimePicker_stop;
        private Label label_stop_time;
        private Label label_start_time;
        private ComboBox comboBox1;
        private Button button_confirm_booking;
        private Label label_room;
        private TabPage tab_settings;
        private Label label_settings;
        private TextBox textBox_booked_for;
        private Label label1;
        private Button btn_feed_clearImage;
        private Button btn_feed_clear;
        private ListView listview_feed;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btn_settings_openInExplorer;
    }
}