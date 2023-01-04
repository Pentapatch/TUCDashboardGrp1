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
            this.label_edit_rooms = new System.Windows.Forms.Label();
            this.btn_read_roomsXML = new System.Windows.Forms.Button();
            this.btn_edit_rooms = new System.Windows.Forms.Button();
            this.btn_settings_openInExplorer = new System.Windows.Forms.Button();
            this.label_settings = new System.Windows.Forms.Label();
            this.tab_edit_rooms = new System.Windows.Forms.TabPage();
            this.btn_editrooms_clear = new System.Windows.Forms.Button();
            this.btn_editrooms_back = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit_room = new System.Windows.Forms.Button();
            this.btn_remove_all = new System.Windows.Forms.Button();
            this.btn_add_room = new System.Windows.Forms.Button();
            this.label_room_type = new System.Windows.Forms.Label();
            this.checkb_is_lecture = new System.Windows.Forms.CheckBox();
            this.checkb_is_group = new System.Windows.Forms.CheckBox();
            this.label_is_lecture = new System.Windows.Forms.Label();
            this.textBox_room_name = new System.Windows.Forms.TextBox();
            this.label_room_name = new System.Windows.Forms.Label();
            this.listView_edit_rooms = new System.Windows.Forms.ListView();
            this.col_room_name = new System.Windows.Forms.ColumnHeader();
            this.col_room_type = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_feed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_feed_preview)).BeginInit();
            this.tab_booking.SuspendLayout();
            this.tab_settings.SuspendLayout();
            this.tab_edit_rooms.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(233, 992);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // feedToolStripMenuItem
            // 
            this.feedToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.feedToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.feedToolStripMenuItem.Name = "feedToolStripMenuItem";
            this.feedToolStripMenuItem.Size = new System.Drawing.Size(220, 49);
            this.feedToolStripMenuItem.Tag = "0";
            this.feedToolStripMenuItem.Text = "&Flöde";
            this.feedToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(220, 49);
            this.bookingsToolStripMenuItem.Tag = "1";
            this.bookingsToolStripMenuItem.Text = "&Bokningar";
            this.bookingsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(220, 49);
            this.settingsToolStripMenuItem.Tag = "2";
            this.settingsToolStripMenuItem.Text = "Inställninga&r";
            this.settingsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_feed);
            this.tabControl1.Controls.Add(this.tab_booking);
            this.tabControl1.Controls.Add(this.tab_settings);
            this.tabControl1.Controls.Add(this.tab_edit_rooms);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(233, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2031, 992);
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
            this.tab_feed.Location = new System.Drawing.Point(8, 46);
            this.tab_feed.Name = "tab_feed";
            this.tab_feed.Padding = new System.Windows.Forms.Padding(3);
            this.tab_feed.Size = new System.Drawing.Size(2015, 938);
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
            this.listview_feed.Location = new System.Drawing.Point(598, 19);
            this.listview_feed.Margin = new System.Windows.Forms.Padding(5);
            this.listview_feed.Name = "listview_feed";
            this.listview_feed.Size = new System.Drawing.Size(1404, 890);
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
            this.btn_feed_clear.Location = new System.Drawing.Point(284, 866);
            this.btn_feed_clear.Name = "btn_feed_clear";
            this.btn_feed_clear.Size = new System.Drawing.Size(177, 46);
            this.btn_feed_clear.TabIndex = 5;
            this.btn_feed_clear.Text = "&Rensa form";
            this.btn_feed_clear.UseVisualStyleBackColor = true;
            this.btn_feed_clear.Click += new System.EventHandler(this.Feed_ClearForm_Click);
            // 
            // btn_feed_clearImage
            // 
            this.btn_feed_clearImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_feed_clearImage.Location = new System.Drawing.Point(284, 346);
            this.btn_feed_clearImage.Name = "btn_feed_clearImage";
            this.btn_feed_clearImage.Size = new System.Drawing.Size(176, 45);
            this.btn_feed_clearImage.TabIndex = 3;
            this.btn_feed_clearImage.Text = "R&ensa bild..";
            this.btn_feed_clearImage.UseVisualStyleBackColor = true;
            this.btn_feed_clearImage.Click += new System.EventHandler(this.Feed_ClearImage_Click);
            // 
            // btn_feed_submit
            // 
            this.btn_feed_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_feed_submit.Location = new System.Drawing.Point(128, 866);
            this.btn_feed_submit.Name = "btn_feed_submit";
            this.btn_feed_submit.Size = new System.Drawing.Size(150, 46);
            this.btn_feed_submit.TabIndex = 4;
            this.btn_feed_submit.Text = "&Lägg till";
            this.btn_feed_submit.UseVisualStyleBackColor = true;
            this.btn_feed_submit.Click += new System.EventHandler(this.Feed_Submit_Click);
            // 
            // picturebox_feed_preview
            // 
            this.picturebox_feed_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picturebox_feed_preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picturebox_feed_preview.Location = new System.Drawing.Point(128, 411);
            this.picturebox_feed_preview.Name = "picturebox_feed_preview";
            this.picturebox_feed_preview.Size = new System.Drawing.Size(439, 432);
            this.picturebox_feed_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox_feed_preview.TabIndex = 6;
            this.picturebox_feed_preview.TabStop = false;
            // 
            // btn_feed_browseForImage
            // 
            this.btn_feed_browseForImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_feed_browseForImage.Location = new System.Drawing.Point(128, 346);
            this.btn_feed_browseForImage.Name = "btn_feed_browseForImage";
            this.btn_feed_browseForImage.Size = new System.Drawing.Size(150, 45);
            this.btn_feed_browseForImage.TabIndex = 2;
            this.btn_feed_browseForImage.Text = "&Bläddra..";
            this.btn_feed_browseForImage.UseVisualStyleBackColor = true;
            this.btn_feed_browseForImage.Click += new System.EventHandler(this.Feed_BrowseForImage_Click);
            // 
            // textbox_feed_content
            // 
            this.textbox_feed_content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textbox_feed_content.Location = new System.Drawing.Point(128, 83);
            this.textbox_feed_content.Multiline = true;
            this.textbox_feed_content.Name = "textbox_feed_content";
            this.textbox_feed_content.Size = new System.Drawing.Size(436, 228);
            this.textbox_feed_content.TabIndex = 1;
            this.textbox_feed_content.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Feed_Textboxes_KeyDown);
            // 
            // textbox_feed_header
            // 
            this.textbox_feed_header.Location = new System.Drawing.Point(128, 19);
            this.textbox_feed_header.Name = "textbox_feed_header";
            this.textbox_feed_header.Size = new System.Drawing.Size(436, 39);
            this.textbox_feed_header.TabIndex = 0;
            this.textbox_feed_header.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Feed_Textboxes_KeyDown);
            // 
            // label_feed_img
            // 
            this.label_feed_img.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_feed_img.AutoSize = true;
            this.label_feed_img.Location = new System.Drawing.Point(23, 352);
            this.label_feed_img.Name = "label_feed_img";
            this.label_feed_img.Size = new System.Drawing.Size(59, 32);
            this.label_feed_img.TabIndex = 2;
            this.label_feed_img.Text = "Bild:";
            // 
            // label_feed_content
            // 
            this.label_feed_content.AutoSize = true;
            this.label_feed_content.Location = new System.Drawing.Point(23, 83);
            this.label_feed_content.Name = "label_feed_content";
            this.label_feed_content.Size = new System.Drawing.Size(104, 32);
            this.label_feed_content.TabIndex = 1;
            this.label_feed_content.Text = "&Innehåll:";
            // 
            // label_feed_header
            // 
            this.label_feed_header.AutoSize = true;
            this.label_feed_header.Location = new System.Drawing.Point(23, 27);
            this.label_feed_header.Name = "label_feed_header";
            this.label_feed_header.Size = new System.Drawing.Size(87, 32);
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
            this.tab_booking.Location = new System.Drawing.Point(8, 46);
            this.tab_booking.Name = "tab_booking";
            this.tab_booking.Padding = new System.Windows.Forms.Padding(3);
            this.tab_booking.Size = new System.Drawing.Size(2015, 938);
            this.tab_booking.TabIndex = 1;
            this.tab_booking.Text = "Bokningar";
            this.tab_booking.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sluttid:";
            // 
            // dateTimePicker_stop
            // 
            this.dateTimePicker_stop.CustomFormat = "HH:mm";
            this.dateTimePicker_stop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_stop.Location = new System.Drawing.Point(185, 267);
            this.dateTimePicker_stop.Name = "dateTimePicker_stop";
            this.dateTimePicker_stop.ShowUpDown = true;
            this.dateTimePicker_stop.Size = new System.Drawing.Size(128, 39);
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
            this.listview_bookings.Location = new System.Drawing.Point(598, 19);
            this.listview_bookings.Margin = new System.Windows.Forms.Padding(5);
            this.listview_bookings.Name = "listview_bookings";
            this.listview_bookings.Size = new System.Drawing.Size(1404, 890);
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
            this.btn_booking_reset.Location = new System.Drawing.Point(356, 410);
            this.btn_booking_reset.Name = "btn_booking_reset";
            this.btn_booking_reset.Size = new System.Drawing.Size(211, 46);
            this.btn_booking_reset.TabIndex = 7;
            this.btn_booking_reset.Text = "Rensa form";
            this.btn_booking_reset.UseVisualStyleBackColor = true;
            this.btn_booking_reset.Click += new System.EventHandler(this.Booking_Reset_Click);
            // 
            // textBox_booked_for
            // 
            this.textBox_booked_for.Location = new System.Drawing.Point(188, 24);
            this.textBox_booked_for.Name = "textBox_booked_for";
            this.textBox_booked_for.Size = new System.Drawing.Size(376, 39);
            this.textBox_booked_for.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bokad för:";
            // 
            // btn_booking_submit
            // 
            this.btn_booking_submit.Location = new System.Drawing.Point(185, 410);
            this.btn_booking_submit.Name = "btn_booking_submit";
            this.btn_booking_submit.Size = new System.Drawing.Size(164, 46);
            this.btn_booking_submit.TabIndex = 6;
            this.btn_booking_submit.Text = "Boka";
            this.btn_booking_submit.UseVisualStyleBackColor = true;
            this.btn_booking_submit.Click += new System.EventHandler(this.Booking_Submit_Click);
            // 
            // label_room
            // 
            this.label_room.AutoSize = true;
            this.label_room.Location = new System.Drawing.Point(23, 341);
            this.label_room.Name = "label_room";
            this.label_room.Size = new System.Drawing.Size(122, 32);
            this.label_room.TabIndex = 7;
            this.label_room.Text = "Rum / Sal:";
            // 
            // combobox_room
            // 
            this.combobox_room.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_room.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_room.FormattingEnabled = true;
            this.combobox_room.Location = new System.Drawing.Point(185, 341);
            this.combobox_room.Name = "combobox_room";
            this.combobox_room.Size = new System.Drawing.Size(379, 40);
            this.combobox_room.TabIndex = 5;
            this.combobox_room.Text = "Välj ett rum..";
            this.combobox_room.Enter += new System.EventHandler(this.Booking_Room_Enter);
            // 
            // label_stop_time
            // 
            this.label_stop_time.AutoSize = true;
            this.label_stop_time.Location = new System.Drawing.Point(23, 222);
            this.label_stop_time.Name = "label_stop_time";
            this.label_stop_time.Size = new System.Drawing.Size(95, 32);
            this.label_stop_time.TabIndex = 5;
            this.label_stop_time.Text = "Starttid:";
            // 
            // label_start_time
            // 
            this.label_start_time.AutoSize = true;
            this.label_start_time.Location = new System.Drawing.Point(23, 165);
            this.label_start_time.Name = "label_start_time";
            this.label_start_time.Size = new System.Drawing.Size(91, 32);
            this.label_start_time.TabIndex = 4;
            this.label_start_time.Text = "Datum:";
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.CustomFormat = "HH:mm";
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_start.Location = new System.Drawing.Point(185, 214);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.ShowUpDown = true;
            this.dateTimePicker_start.Size = new System.Drawing.Size(128, 39);
            this.dateTimePicker_start.TabIndex = 3;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_date.Location = new System.Drawing.Point(185, 160);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(277, 39);
            this.dateTimePicker_date.TabIndex = 2;
            // 
            // textBox_booked_by
            // 
            this.textBox_booked_by.Location = new System.Drawing.Point(185, 91);
            this.textBox_booked_by.Name = "textBox_booked_by";
            this.textBox_booked_by.Size = new System.Drawing.Size(379, 39);
            this.textBox_booked_by.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(23, 91);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(116, 32);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Bokad av:";
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.label_edit_rooms);
            this.tab_settings.Controls.Add(this.btn_read_roomsXML);
            this.tab_settings.Controls.Add(this.btn_edit_rooms);
            this.tab_settings.Controls.Add(this.btn_settings_openInExplorer);
            this.tab_settings.Controls.Add(this.label_settings);
            this.tab_settings.Location = new System.Drawing.Point(8, 46);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_settings.Size = new System.Drawing.Size(2015, 938);
            this.tab_settings.TabIndex = 2;
            this.tab_settings.Text = "Inställningar";
            this.tab_settings.UseVisualStyleBackColor = true;
            // 
            // label_edit_rooms
            // 
            this.label_edit_rooms.AutoSize = true;
            this.label_edit_rooms.Location = new System.Drawing.Point(110, 266);
            this.label_edit_rooms.Name = "label_edit_rooms";
            this.label_edit_rooms.Size = new System.Drawing.Size(153, 32);
            this.label_edit_rooms.TabIndex = 4;
            this.label_edit_rooms.Text = "Hantera rum:";
            // 
            // btn_read_roomsXML
            // 
            this.btn_read_roomsXML.Location = new System.Drawing.Point(456, 259);
            this.btn_read_roomsXML.Name = "btn_read_roomsXML";
            this.btn_read_roomsXML.Size = new System.Drawing.Size(184, 46);
            this.btn_read_roomsXML.TabIndex = 3;
            this.btn_read_roomsXML.Text = "Hämta från fil";
            this.btn_read_roomsXML.UseVisualStyleBackColor = true;
            // 
            // btn_edit_rooms
            // 
            this.btn_edit_rooms.Location = new System.Drawing.Point(286, 259);
            this.btn_edit_rooms.Name = "btn_edit_rooms";
            this.btn_edit_rooms.Size = new System.Drawing.Size(150, 46);
            this.btn_edit_rooms.TabIndex = 2;
            this.btn_edit_rooms.Text = "Ändra..";
            this.btn_edit_rooms.UseVisualStyleBackColor = true;
            this.btn_edit_rooms.Click += new System.EventHandler(this.btn_edit_rooms_Click);
            // 
            // btn_settings_openInExplorer
            // 
            this.btn_settings_openInExplorer.Location = new System.Drawing.Point(114, 136);
            this.btn_settings_openInExplorer.Margin = new System.Windows.Forms.Padding(5);
            this.btn_settings_openInExplorer.Name = "btn_settings_openInExplorer";
            this.btn_settings_openInExplorer.Size = new System.Drawing.Size(252, 46);
            this.btn_settings_openInExplorer.TabIndex = 1;
            this.btn_settings_openInExplorer.Text = "Ö&ppna i explorer";
            this.btn_settings_openInExplorer.UseVisualStyleBackColor = true;
            this.btn_settings_openInExplorer.Click += new System.EventHandler(this.btn_settings_openInExplorer_Click);
            // 
            // label_settings
            // 
            this.label_settings.AutoSize = true;
            this.label_settings.Location = new System.Drawing.Point(114, 82);
            this.label_settings.Name = "label_settings";
            this.label_settings.Size = new System.Drawing.Size(344, 32);
            this.label_settings.TabIndex = 0;
            this.label_settings.Text = "Inställningar är tom för tillfället";
            // 
            // tab_edit_rooms
            // 
            this.tab_edit_rooms.Controls.Add(this.btn_editrooms_clear);
            this.tab_edit_rooms.Controls.Add(this.btn_editrooms_back);
            this.tab_edit_rooms.Controls.Add(this.btn_remove);
            this.tab_edit_rooms.Controls.Add(this.btn_edit_room);
            this.tab_edit_rooms.Controls.Add(this.btn_remove_all);
            this.tab_edit_rooms.Controls.Add(this.btn_add_room);
            this.tab_edit_rooms.Controls.Add(this.label_room_type);
            this.tab_edit_rooms.Controls.Add(this.checkb_is_lecture);
            this.tab_edit_rooms.Controls.Add(this.checkb_is_group);
            this.tab_edit_rooms.Controls.Add(this.label_is_lecture);
            this.tab_edit_rooms.Controls.Add(this.textBox_room_name);
            this.tab_edit_rooms.Controls.Add(this.label_room_name);
            this.tab_edit_rooms.Controls.Add(this.listView_edit_rooms);
            this.tab_edit_rooms.Location = new System.Drawing.Point(8, 46);
            this.tab_edit_rooms.Name = "tab_edit_rooms";
            this.tab_edit_rooms.Padding = new System.Windows.Forms.Padding(3);
            this.tab_edit_rooms.Size = new System.Drawing.Size(2015, 938);
            this.tab_edit_rooms.TabIndex = 3;
            this.tab_edit_rooms.Text = "Redigera rum";
            this.tab_edit_rooms.UseVisualStyleBackColor = true;
            // 
            // btn_editrooms_clear
            // 
            this.btn_editrooms_clear.Location = new System.Drawing.Point(358, 302);
            this.btn_editrooms_clear.Name = "btn_editrooms_clear";
            this.btn_editrooms_clear.Size = new System.Drawing.Size(150, 46);
            this.btn_editrooms_clear.TabIndex = 10;
            this.btn_editrooms_clear.Text = "Rensa";
            this.btn_editrooms_clear.UseVisualStyleBackColor = true;
            this.btn_editrooms_clear.Click += new System.EventHandler(this.btn_editrooms_clear_Click);
            // 
            // btn_editrooms_back
            // 
            this.btn_editrooms_back.Location = new System.Drawing.Point(22, 812);
            this.btn_editrooms_back.Name = "btn_editrooms_back";
            this.btn_editrooms_back.Size = new System.Drawing.Size(150, 46);
            this.btn_editrooms_back.TabIndex = 6;
            this.btn_editrooms_back.Text = "Tillbaka";
            this.btn_editrooms_back.UseVisualStyleBackColor = true;
            this.btn_editrooms_back.Click += new System.EventHandler(this.btn_editrooms_back_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(1848, 877);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(150, 46);
            this.btn_remove.TabIndex = 9;
            this.btn_remove.Text = "Ta bort";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit_room
            // 
            this.btn_edit_room.Location = new System.Drawing.Point(1669, 877);
            this.btn_edit_room.Name = "btn_edit_room";
            this.btn_edit_room.Size = new System.Drawing.Size(150, 46);
            this.btn_edit_room.TabIndex = 8;
            this.btn_edit_room.Text = "Redigera";
            this.btn_edit_room.UseVisualStyleBackColor = true;
            this.btn_edit_room.Click += new System.EventHandler(this.btn_edit_room_Click);
            // 
            // btn_remove_all
            // 
            this.btn_remove_all.Location = new System.Drawing.Point(1489, 877);
            this.btn_remove_all.Name = "btn_remove_all";
            this.btn_remove_all.Size = new System.Drawing.Size(150, 46);
            this.btn_remove_all.TabIndex = 7;
            this.btn_remove_all.Text = "Ta bort alla";
            this.btn_remove_all.UseVisualStyleBackColor = true;
            this.btn_remove_all.Click += new System.EventHandler(this.btn_remove_all_Click);
            // 
            // btn_add_room
            // 
            this.btn_add_room.Location = new System.Drawing.Point(180, 302);
            this.btn_add_room.Name = "btn_add_room";
            this.btn_add_room.Size = new System.Drawing.Size(150, 46);
            this.btn_add_room.TabIndex = 5;
            this.btn_add_room.Text = "Lägg till";
            this.btn_add_room.UseVisualStyleBackColor = true;
            this.btn_add_room.Click += new System.EventHandler(this.btn_add_room_Click);
            // 
            // label_room_type
            // 
            this.label_room_type.AutoSize = true;
            this.label_room_type.Location = new System.Drawing.Point(22, 160);
            this.label_room_type.Name = "label_room_type";
            this.label_room_type.Size = new System.Drawing.Size(112, 32);
            this.label_room_type.TabIndex = 7;
            this.label_room_type.Text = "Rumstyp:";
            // 
            // checkb_is_lecture
            // 
            this.checkb_is_lecture.AutoSize = true;
            this.checkb_is_lecture.Location = new System.Drawing.Point(180, 222);
            this.checkb_is_lecture.Name = "checkb_is_lecture";
            this.checkb_is_lecture.Size = new System.Drawing.Size(77, 36);
            this.checkb_is_lecture.TabIndex = 4;
            this.checkb_is_lecture.Text = "Sal";
            this.checkb_is_lecture.UseVisualStyleBackColor = true;
            this.checkb_is_lecture.Click += new System.EventHandler(this.checkb_is_lecture_Click);
            // 
            // checkb_is_group
            // 
            this.checkb_is_group.AutoSize = true;
            this.checkb_is_group.Location = new System.Drawing.Point(180, 160);
            this.checkb_is_group.Name = "checkb_is_group";
            this.checkb_is_group.Size = new System.Drawing.Size(155, 36);
            this.checkb_is_group.TabIndex = 3;
            this.checkb_is_group.Text = "Grupprum";
            this.checkb_is_group.UseVisualStyleBackColor = true;
            this.checkb_is_group.Click += new System.EventHandler(this.checkb_is_group_Click);
            // 
            // label_is_lecture
            // 
            this.label_is_lecture.AutoSize = true;
            this.label_is_lecture.Location = new System.Drawing.Point(264, 148);
            this.label_is_lecture.Name = "label_is_lecture";
            this.label_is_lecture.Size = new System.Drawing.Size(0, 32);
            this.label_is_lecture.TabIndex = 4;
            // 
            // textBox_room_name
            // 
            this.textBox_room_name.Location = new System.Drawing.Point(180, 53);
            this.textBox_room_name.Name = "textBox_room_name";
            this.textBox_room_name.Size = new System.Drawing.Size(328, 39);
            this.textBox_room_name.TabIndex = 2;
            // 
            // label_room_name
            // 
            this.label_room_name.AutoSize = true;
            this.label_room_name.Location = new System.Drawing.Point(22, 56);
            this.label_room_name.Name = "label_room_name";
            this.label_room_name.Size = new System.Drawing.Size(139, 32);
            this.label_room_name.TabIndex = 1;
            this.label_room_name.Text = "Rumsnamn:";
            // 
            // listView_edit_rooms
            // 
            this.listView_edit_rooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_room_name,
            this.col_room_type});
            this.listView_edit_rooms.FullRowSelect = true;
            this.listView_edit_rooms.Location = new System.Drawing.Point(584, 3);
            this.listView_edit_rooms.Name = "listView_edit_rooms";
            this.listView_edit_rooms.Size = new System.Drawing.Size(1425, 855);
            this.listView_edit_rooms.TabIndex = 0;
            this.listView_edit_rooms.UseCompatibleStateImageBehavior = false;
            this.listView_edit_rooms.View = System.Windows.Forms.View.Details;
            this.listView_edit_rooms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_edit_rooms_KeyDown);
            this.listView_edit_rooms.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_edit_rooms_MouseDoubleClick);
            // 
            // col_room_name
            // 
            this.col_room_name.Text = "Rumsnamn";
            this.col_room_name.Width = 300;
            // 
            // col_room_type
            // 
            this.col_room_type.Text = "Rumstyp";
            this.col_room_type.Width = 300;
            // 
            // AdminTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2264, 992);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "AdminTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminTools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminTools_FormClosing);
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
            this.tab_edit_rooms.ResumeLayout(false);
            this.tab_edit_rooms.PerformLayout();
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
        private Label label_edit_rooms;
        private Button btn_read_roomsXML;
        private Button btn_edit_rooms;
        private TabPage tab_edit_rooms;
        private Button btn_add_room;
        private Label label_room_type;
        private CheckBox checkb_is_lecture;
        private CheckBox checkb_is_group;
        private Label label_is_lecture;
        private TextBox textBox_room_name;
        private Label label_room_name;
        private ListView listView_edit_rooms;
        private ColumnHeader col_room_name;
        private ColumnHeader col_room_type;
        private Button btn_remove;
        private Button btn_edit_room;
        private Button btn_remove_all;
        private Button btn_editrooms_back;
        private Button btn_editrooms_clear;
    }
}