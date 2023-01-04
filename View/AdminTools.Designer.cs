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
            this.feedPanel1 = new TUCDashboardGrp1.FeedPanel();
            this.tab_booking = new System.Windows.Forms.TabPage();
            this.bookingPanel1 = new TUCDashboardGrp1.View.BookingPanel();
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.label_edit_rooms = new System.Windows.Forms.Label();
            this.btn_read_roomsXML = new System.Windows.Forms.Button();
            this.btn_edit_rooms = new System.Windows.Forms.Button();
            this.btn_settings_openInExplorer = new System.Windows.Forms.Button();
            this.label_settings = new System.Windows.Forms.Label();
            this.tab_edit_rooms = new System.Windows.Forms.TabPage();
            this.label_is_lecture = new System.Windows.Forms.Label();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.roomPanel1 = new TUCDashboardGrp1.View.RoomPanel();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_feed.SuspendLayout();
            this.tab_booking.SuspendLayout();
            this.tab_settings.SuspendLayout();
            this.tab_edit_rooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(122, 465);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // feedToolStripMenuItem
            // 
            this.feedToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.feedToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.feedToolStripMenuItem.Name = "feedToolStripMenuItem";
            this.feedToolStripMenuItem.Size = new System.Drawing.Size(115, 25);
            this.feedToolStripMenuItem.Tag = "0";
            this.feedToolStripMenuItem.Text = "&Flöde";
            this.feedToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(115, 25);
            this.bookingsToolStripMenuItem.Tag = "1";
            this.bookingsToolStripMenuItem.Text = "&Bokningar";
            this.bookingsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(115, 25);
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
            this.tabControl1.Location = new System.Drawing.Point(122, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1097, 465);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_feed
            // 
            this.tab_feed.Controls.Add(this.feedPanel1);
            this.tab_feed.Location = new System.Drawing.Point(4, 24);
            this.tab_feed.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tab_feed.Name = "tab_feed";
            this.tab_feed.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tab_feed.Size = new System.Drawing.Size(1089, 437);
            this.tab_feed.TabIndex = 0;
            this.tab_feed.Text = "Flöde";
            this.tab_feed.UseVisualStyleBackColor = true;
            // 
            // feedPanel1
            // 
            this.feedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedPanel1.Location = new System.Drawing.Point(2, 1);
            this.feedPanel1.Name = "feedPanel1";
            this.feedPanel1.Size = new System.Drawing.Size(1085, 435);
            this.feedPanel1.TabIndex = 0;
            // 
            // tab_booking
            // 
            this.tab_booking.Controls.Add(this.bookingPanel1);
            this.tab_booking.Location = new System.Drawing.Point(4, 24);
            this.tab_booking.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tab_booking.Name = "tab_booking";
            this.tab_booking.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tab_booking.Size = new System.Drawing.Size(1089, 437);
            this.tab_booking.TabIndex = 1;
            this.tab_booking.Text = "Bokningar";
            this.tab_booking.UseVisualStyleBackColor = true;
            // 
            // bookingPanel1
            // 
            this.bookingPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingPanel1.Location = new System.Drawing.Point(2, 1);
            this.bookingPanel1.Name = "bookingPanel1";
            this.bookingPanel1.Size = new System.Drawing.Size(1085, 435);
            this.bookingPanel1.TabIndex = 0;
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.label_edit_rooms);
            this.tab_settings.Controls.Add(this.btn_read_roomsXML);
            this.tab_settings.Controls.Add(this.btn_edit_rooms);
            this.tab_settings.Controls.Add(this.btn_settings_openInExplorer);
            this.tab_settings.Controls.Add(this.label_settings);
            this.tab_settings.Location = new System.Drawing.Point(4, 24);
            this.tab_settings.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tab_settings.Size = new System.Drawing.Size(1089, 437);
            this.tab_settings.TabIndex = 2;
            this.tab_settings.Text = "Inställningar";
            this.tab_settings.UseVisualStyleBackColor = true;
            // 
            // label_edit_rooms
            // 
            this.label_edit_rooms.AutoSize = true;
            this.label_edit_rooms.Location = new System.Drawing.Point(59, 125);
            this.label_edit_rooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_edit_rooms.Name = "label_edit_rooms";
            this.label_edit_rooms.Size = new System.Drawing.Size(77, 15);
            this.label_edit_rooms.TabIndex = 4;
            this.label_edit_rooms.Text = "Hantera rum:";
            // 
            // btn_read_roomsXML
            // 
            this.btn_read_roomsXML.Location = new System.Drawing.Point(246, 121);
            this.btn_read_roomsXML.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_read_roomsXML.Name = "btn_read_roomsXML";
            this.btn_read_roomsXML.Size = new System.Drawing.Size(99, 22);
            this.btn_read_roomsXML.TabIndex = 3;
            this.btn_read_roomsXML.Text = "Hämta från fil";
            this.btn_read_roomsXML.UseVisualStyleBackColor = true;
            // 
            // btn_edit_rooms
            // 
            this.btn_edit_rooms.Location = new System.Drawing.Point(154, 121);
            this.btn_edit_rooms.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_edit_rooms.Name = "btn_edit_rooms";
            this.btn_edit_rooms.Size = new System.Drawing.Size(81, 22);
            this.btn_edit_rooms.TabIndex = 2;
            this.btn_edit_rooms.Text = "Ändra..";
            this.btn_edit_rooms.UseVisualStyleBackColor = true;
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
            // tab_edit_rooms
            // 
            this.tab_edit_rooms.Controls.Add(this.roomPanel1);
            this.tab_edit_rooms.Controls.Add(this.label_is_lecture);
            this.tab_edit_rooms.Location = new System.Drawing.Point(4, 24);
            this.tab_edit_rooms.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tab_edit_rooms.Name = "tab_edit_rooms";
            this.tab_edit_rooms.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tab_edit_rooms.Size = new System.Drawing.Size(1089, 437);
            this.tab_edit_rooms.TabIndex = 3;
            this.tab_edit_rooms.Text = "Redigera rum";
            this.tab_edit_rooms.UseVisualStyleBackColor = true;
            // 
            // label_is_lecture
            // 
            this.label_is_lecture.AutoSize = true;
            this.label_is_lecture.Location = new System.Drawing.Point(142, 69);
            this.label_is_lecture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_is_lecture.Name = "label_is_lecture";
            this.label_is_lecture.Size = new System.Drawing.Size(0, 15);
            this.label_is_lecture.TabIndex = 4;
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
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // roomPanel1
            // 
            this.roomPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomPanel1.Location = new System.Drawing.Point(2, 1);
            this.roomPanel1.Name = "roomPanel1";
            this.roomPanel1.Size = new System.Drawing.Size(1085, 435);
            this.roomPanel1.TabIndex = 5;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminTools_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_feed.ResumeLayout(false);
            this.tab_booking.ResumeLayout(false);
            this.tab_settings.ResumeLayout(false);
            this.tab_settings.PerformLayout();
            this.tab_edit_rooms.ResumeLayout(false);
            this.tab_edit_rooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
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
        private TabPage tab_settings;
        private Label label_settings;
        private Button btn_settings_openInExplorer;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Label label_edit_rooms;
        private Button btn_read_roomsXML;
        private Button btn_edit_rooms;
        private TabPage tab_edit_rooms;
        private FileSystemWatcher fileSystemWatcher1;
        private FeedPanel feedPanel1;
        private FileSystemWatcher fileSystemWatcher2;
        private View.BookingPanel bookingPanel1;
        private Label label_is_lecture;
        private View.RoomPanel roomPanel1;
    }
}