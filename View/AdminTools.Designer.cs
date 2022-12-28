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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_stop = new System.Windows.Forms.DateTimePicker();
            this.listview_bookings = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.btn_booking_reset = new System.Windows.Forms.Button();
            this.textBox_booked_for = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_booking_submit = new System.Windows.Forms.Button();
            this.label_room = new System.Windows.Forms.Label();
            this.combobox_room = new System.Windows.Forms.ComboBox();
            this.label_stop_time = new System.Windows.Forms.Label();
            this.label_start_time = new System.Windows.Forms.Label();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
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
            this.menuStrip1.Size = new System.Drawing.Size(123, 465);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // feedToolStripMenuItem
            // 
            this.feedToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.feedToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.feedToolStripMenuItem.Name = "feedToolStripMenuItem";
            this.feedToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
            this.feedToolStripMenuItem.Tag = "0";
            this.feedToolStripMenuItem.Text = "&Flöde";
            this.feedToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
            this.bookingsToolStripMenuItem.Tag = "1";
            this.bookingsToolStripMenuItem.Text = "&Bokningar";
            this.bookingsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
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
            this.tabControl1.Location = new System.Drawing.Point(123, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1096, 465);
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
            this.tab_feed.Location = new System.Drawing.Point(4, 24);
            this.tab_feed.Margin = new System.Windows.Forms.Padding(2);
            this.tab_feed.Name = "tab_feed";
            this.tab_feed.Padding = new System.Windows.Forms.Padding(2);
            this.tab_feed.Size = new System.Drawing.Size(1088, 437);
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
            this.listview_feed.Location = new System.Drawing.Point(322, 9);
            this.listview_feed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listview_feed.Name = "listview_feed";
            this.listview_feed.Size = new System.Drawing.Size(761, 420);
            this.listview_feed.TabIndex = 12;
            this.listview_feed.UseCompatibleStateImageBehavior = false;
            this.listview_feed.View = System.Windows.Forms.View.Details;
            this.listview_feed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Feed_ListView_KeyDown);
            this.listview_feed.Leave += new System.EventHandler(this.Feed_ListView_Leave);
            this.listview_feed.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Feed_ListView_MouseDoubleClick);
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
            this.btn_feed_clear.Location = new System.Drawing.Point(153, 406);
            this.btn_feed_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_feed_clear.Name = "btn_feed_clear";
            this.btn_feed_clear.Size = new System.Drawing.Size(95, 22);
            this.btn_feed_clear.TabIndex = 5;
            this.btn_feed_clear.Text = "&Rensa form";
            this.btn_feed_clear.UseVisualStyleBackColor = true;
            this.btn_feed_clear.Click += new System.EventHandler(this.Feed_ClearForm_Click);
            // 
            // btn_feed_clearImage
            // 
            this.btn_feed_clearImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_feed_clearImage.Location = new System.Drawing.Point(153, 162);
            this.btn_feed_clearImage.Margin = new System.Windows.Forms.Padding(2);
            this.btn_feed_clearImage.Name = "btn_feed_clearImage";
            this.btn_feed_clearImage.Size = new System.Drawing.Size(94, 21);
            this.btn_feed_clearImage.TabIndex = 3;
            this.btn_feed_clearImage.Text = "R&ensa bild..";
            this.btn_feed_clearImage.UseVisualStyleBackColor = true;
            this.btn_feed_clearImage.Click += new System.EventHandler(this.Feed_ClearImage_Click);
            // 
            // btn_feed_submit
            // 
            this.btn_feed_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_feed_submit.Location = new System.Drawing.Point(69, 406);
            this.btn_feed_submit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_feed_submit.Name = "btn_feed_submit";
            this.btn_feed_submit.Size = new System.Drawing.Size(80, 22);
            this.btn_feed_submit.TabIndex = 4;
            this.btn_feed_submit.Text = "&Lägg till";
            this.btn_feed_submit.UseVisualStyleBackColor = true;
            this.btn_feed_submit.Click += new System.EventHandler(this.Feed_Submit_Click);
            // 
            // picturebox_feed_preview
            // 
            this.picturebox_feed_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picturebox_feed_preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picturebox_feed_preview.Location = new System.Drawing.Point(69, 193);
            this.picturebox_feed_preview.Margin = new System.Windows.Forms.Padding(2);
            this.picturebox_feed_preview.Name = "picturebox_feed_preview";
            this.picturebox_feed_preview.Size = new System.Drawing.Size(236, 202);
            this.picturebox_feed_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox_feed_preview.TabIndex = 6;
            this.picturebox_feed_preview.TabStop = false;
            // 
            // btn_feed_browseForImage
            // 
            this.btn_feed_browseForImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_feed_browseForImage.Location = new System.Drawing.Point(69, 162);
            this.btn_feed_browseForImage.Margin = new System.Windows.Forms.Padding(2);
            this.btn_feed_browseForImage.Name = "btn_feed_browseForImage";
            this.btn_feed_browseForImage.Size = new System.Drawing.Size(80, 21);
            this.btn_feed_browseForImage.TabIndex = 2;
            this.btn_feed_browseForImage.Text = "&Bläddra..";
            this.btn_feed_browseForImage.UseVisualStyleBackColor = true;
            this.btn_feed_browseForImage.Click += new System.EventHandler(this.Feed_BrowseForImage_Click);
            // 
            // textbox_feed_content
            // 
            this.textbox_feed_content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textbox_feed_content.Location = new System.Drawing.Point(69, 39);
            this.textbox_feed_content.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_feed_content.Multiline = true;
            this.textbox_feed_content.Name = "textbox_feed_content";
            this.textbox_feed_content.Size = new System.Drawing.Size(237, 109);
            this.textbox_feed_content.TabIndex = 1;
            this.textbox_feed_content.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Feed_Textboxes_KeyDown);
            // 
            // textbox_feed_header
            // 
            this.textbox_feed_header.Location = new System.Drawing.Point(69, 9);
            this.textbox_feed_header.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_feed_header.Name = "textbox_feed_header";
            this.textbox_feed_header.Size = new System.Drawing.Size(237, 23);
            this.textbox_feed_header.TabIndex = 0;
            this.textbox_feed_header.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Feed_Textboxes_KeyDown);
            // 
            // label_feed_img
            // 
            this.label_feed_img.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_feed_img.AutoSize = true;
            this.label_feed_img.Location = new System.Drawing.Point(12, 165);
            this.label_feed_img.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_feed_img.Name = "label_feed_img";
            this.label_feed_img.Size = new System.Drawing.Size(30, 15);
            this.label_feed_img.TabIndex = 2;
            this.label_feed_img.Text = "Bild:";
            // 
            // label_feed_content
            // 
            this.label_feed_content.AutoSize = true;
            this.label_feed_content.Location = new System.Drawing.Point(12, 39);
            this.label_feed_content.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_feed_content.Name = "label_feed_content";
            this.label_feed_content.Size = new System.Drawing.Size(52, 15);
            this.label_feed_content.TabIndex = 1;
            this.label_feed_content.Text = "&Innehåll:";
            // 
            // label_feed_header
            // 
            this.label_feed_header.AutoSize = true;
            this.label_feed_header.Location = new System.Drawing.Point(12, 13);
            this.label_feed_header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_feed_header.Name = "label_feed_header";
            this.label_feed_header.Size = new System.Drawing.Size(44, 15);
            this.label_feed_header.TabIndex = 0;
            this.label_feed_header.Text = "R&ubrik:";
            // 
            // tab_booking
            // 
            this.tab_booking.Controls.Add(this.label2);
            this.tab_booking.Controls.Add(this.dateTimePicker_stop);
            this.tab_booking.Controls.Add(this.listview_bookings);
            this.tab_booking.Controls.Add(this.btn_booking_reset);
            this.tab_booking.Controls.Add(this.textBox_booked_for);
            this.tab_booking.Controls.Add(this.label1);
            this.tab_booking.Controls.Add(this.btn_booking_submit);
            this.tab_booking.Controls.Add(this.label_room);
            this.tab_booking.Controls.Add(this.combobox_room);
            this.tab_booking.Controls.Add(this.label_stop_time);
            this.tab_booking.Controls.Add(this.label_start_time);
            this.tab_booking.Controls.Add(this.dateTimePicker_start);
            this.tab_booking.Controls.Add(this.dateTimePicker_date);
            this.tab_booking.Controls.Add(this.textBox_booked_by);
            this.tab_booking.Controls.Add(this.label_name);
            this.tab_booking.Location = new System.Drawing.Point(4, 24);
            this.tab_booking.Margin = new System.Windows.Forms.Padding(2);
            this.tab_booking.Name = "tab_booking";
            this.tab_booking.Padding = new System.Windows.Forms.Padding(2);
            this.tab_booking.Size = new System.Drawing.Size(1088, 437);
            this.tab_booking.TabIndex = 1;
            this.tab_booking.Text = "Bokningar";
            this.tab_booking.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sluttid:";
            // 
            // dateTimePicker_stop
            // 
            this.dateTimePicker_stop.CustomFormat = "HH:mm";
            this.dateTimePicker_stop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_stop.Location = new System.Drawing.Point(100, 125);
            this.dateTimePicker_stop.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_stop.Name = "dateTimePicker_stop";
            this.dateTimePicker_stop.ShowUpDown = true;
            this.dateTimePicker_stop.Size = new System.Drawing.Size(70, 23);
            this.dateTimePicker_stop.TabIndex = 4;
            // 
            // listview_bookings
            // 
            this.listview_bookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listview_bookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader9,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listview_bookings.FullRowSelect = true;
            this.listview_bookings.Location = new System.Drawing.Point(322, 9);
            this.listview_bookings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listview_bookings.Name = "listview_bookings";
            this.listview_bookings.Size = new System.Drawing.Size(761, 420);
            this.listview_bookings.TabIndex = 8;
            this.listview_bookings.UseCompatibleStateImageBehavior = false;
            this.listview_bookings.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bokad för";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Bokad av";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Datum";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Starttid";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Sluttid";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Rum / Sal";
            this.columnHeader8.Width = 180;
            // 
            // btn_booking_reset
            // 
            this.btn_booking_reset.Location = new System.Drawing.Point(192, 192);
            this.btn_booking_reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_booking_reset.Name = "btn_booking_reset";
            this.btn_booking_reset.Size = new System.Drawing.Size(114, 22);
            this.btn_booking_reset.TabIndex = 7;
            this.btn_booking_reset.Text = "Rensa form";
            this.btn_booking_reset.UseVisualStyleBackColor = true;
            this.btn_booking_reset.Click += new System.EventHandler(this.Booking_Reset_Click);
            // 
            // textBox_booked_for
            // 
            this.textBox_booked_for.Location = new System.Drawing.Point(102, 11);
            this.textBox_booked_for.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_booked_for.Name = "textBox_booked_for";
            this.textBox_booked_for.Size = new System.Drawing.Size(204, 23);
            this.textBox_booked_for.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bokad för:";
            // 
            // btn_booking_submit
            // 
            this.btn_booking_submit.Location = new System.Drawing.Point(100, 192);
            this.btn_booking_submit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_booking_submit.Name = "btn_booking_submit";
            this.btn_booking_submit.Size = new System.Drawing.Size(88, 22);
            this.btn_booking_submit.TabIndex = 6;
            this.btn_booking_submit.Text = "Boka";
            this.btn_booking_submit.UseVisualStyleBackColor = true;
            this.btn_booking_submit.Click += new System.EventHandler(this.Booking_Submit_Click);
            // 
            // label_room
            // 
            this.label_room.AutoSize = true;
            this.label_room.Location = new System.Drawing.Point(12, 160);
            this.label_room.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_room.Name = "label_room";
            this.label_room.Size = new System.Drawing.Size(61, 15);
            this.label_room.TabIndex = 7;
            this.label_room.Text = "Rum / Sal:";
            // 
            // combobox_room
            // 
            this.combobox_room.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_room.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_room.FormattingEnabled = true;
            this.combobox_room.Items.AddRange(new object[] {
            "G1 Roxen",
            "G2 Stångån",
            "G3 Glan",
            "G4 Berga",
            "G5 Norrköping",
            "G6 Finspång",
            "G7 Söderköping",
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "A8",
            "A9"});
            this.combobox_room.Location = new System.Drawing.Point(100, 160);
            this.combobox_room.Margin = new System.Windows.Forms.Padding(2);
            this.combobox_room.Name = "combobox_room";
            this.combobox_room.Size = new System.Drawing.Size(206, 23);
            this.combobox_room.TabIndex = 5;
            this.combobox_room.Text = "Välj ett rum..";
            this.combobox_room.Enter += new System.EventHandler(this.Booking_Room_Enter);
            // 
            // label_stop_time
            // 
            this.label_stop_time.AutoSize = true;
            this.label_stop_time.Location = new System.Drawing.Point(12, 104);
            this.label_stop_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_stop_time.Name = "label_stop_time";
            this.label_stop_time.Size = new System.Drawing.Size(48, 15);
            this.label_stop_time.TabIndex = 5;
            this.label_stop_time.Text = "Starttid:";
            // 
            // label_start_time
            // 
            this.label_start_time.AutoSize = true;
            this.label_start_time.Location = new System.Drawing.Point(12, 77);
            this.label_start_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_start_time.Name = "label_start_time";
            this.label_start_time.Size = new System.Drawing.Size(46, 15);
            this.label_start_time.TabIndex = 4;
            this.label_start_time.Text = "Datum:";
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.CustomFormat = "HH:mm";
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_start.Location = new System.Drawing.Point(100, 100);
            this.dateTimePicker_start.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.ShowUpDown = true;
            this.dateTimePicker_start.Size = new System.Drawing.Size(70, 23);
            this.dateTimePicker_start.TabIndex = 3;
            this.dateTimePicker_start.ValueChanged += new System.EventHandler(this.dateTimePicker_start_ValueChanged);
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_date.Location = new System.Drawing.Point(100, 75);
            this.dateTimePicker_date.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(151, 23);
            this.dateTimePicker_date.TabIndex = 2;
            // 
            // textBox_booked_by
            // 
            this.textBox_booked_by.Location = new System.Drawing.Point(100, 43);
            this.textBox_booked_by.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_booked_by.Name = "textBox_booked_by";
            this.textBox_booked_by.Size = new System.Drawing.Size(206, 23);
            this.textBox_booked_by.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 43);
            this.label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(58, 15);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Bokad av:";
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.btn_settings_openInExplorer);
            this.tab_settings.Controls.Add(this.label_settings);
            this.tab_settings.Location = new System.Drawing.Point(4, 24);
            this.tab_settings.Margin = new System.Windows.Forms.Padding(2);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(2);
            this.tab_settings.Size = new System.Drawing.Size(1088, 437);
            this.tab_settings.TabIndex = 2;
            this.tab_settings.Text = "Inställningar";
            this.tab_settings.UseVisualStyleBackColor = true;
            // 
            // btn_settings_openInExplorer
            // 
            this.btn_settings_openInExplorer.Location = new System.Drawing.Point(61, 64);
            this.btn_settings_openInExplorer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_settings_openInExplorer.Name = "btn_settings_openInExplorer";
            this.btn_settings_openInExplorer.Size = new System.Drawing.Size(136, 22);
            this.btn_settings_openInExplorer.TabIndex = 1;
            this.btn_settings_openInExplorer.Text = "Ö&ppna i explorer";
            this.btn_settings_openInExplorer.UseVisualStyleBackColor = true;
            this.btn_settings_openInExplorer.Click += new System.EventHandler(this.btn_settings_openInExplorer_Click);
            // 
            // label_settings
            // 
            this.label_settings.AutoSize = true;
            this.label_settings.Location = new System.Drawing.Point(61, 38);
            this.label_settings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_settings.Name = "label_settings";
            this.label_settings.Size = new System.Drawing.Size(170, 15);
            this.label_settings.TabIndex = 0;
            this.label_settings.Text = "Inställningar är tom för tillfället";
            // 
            // AdminTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 465);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private DateTimePicker dateTimePicker_date;
        private DateTimePicker dateTimePicker_start;
        private Label label_stop_time;
        private Label label_start_time;
        private ComboBox combobox_room;
        private Button btn_booking_submit;
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
        private Button btn_booking_reset;
        private ListView listview_bookings;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label label2;
        private DateTimePicker dateTimePicker_stop;
        private ColumnHeader columnHeader9;
    }
}