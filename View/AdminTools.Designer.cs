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
            this.grupprumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inställningarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.picturebox_feed_preview = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textbox_feed_content = new System.Windows.Forms.TextBox();
            this.textbox_feed_header = new System.Windows.Forms.TextBox();
            this.label_feed_img = new System.Windows.Forms.Label();
            this.label_feed_content = new System.Windows.Forms.Label();
            this.label_feed_header = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_confirm_booking = new System.Windows.Forms.Button();
            this.label_room = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_stop_time = new System.Windows.Forms.Label();
            this.label_start_time = new System.Windows.Forms.Label();
            this.dateTimePicker_stop = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label_settings = new System.Windows.Forms.Label();
            this.browser = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_feed_preview)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feedToolStripMenuItem,
            this.grupprumToolStripMenuItem,
            this.inställningarToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(170, 840);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // feedToolStripMenuItem
            // 
            this.feedToolStripMenuItem.Name = "feedToolStripMenuItem";
            this.feedToolStripMenuItem.Size = new System.Drawing.Size(157, 36);
            this.feedToolStripMenuItem.Text = "&Feed";
            this.feedToolStripMenuItem.Click += new System.EventHandler(this.feedToolStripMenuItem_Click);
            // 
            // grupprumToolStripMenuItem
            // 
            this.grupprumToolStripMenuItem.Name = "grupprumToolStripMenuItem";
            this.grupprumToolStripMenuItem.Size = new System.Drawing.Size(157, 36);
            this.grupprumToolStripMenuItem.Text = "&Bokningar";
            this.grupprumToolStripMenuItem.Click += new System.EventHandler(this.grupprumToolStripMenuItem_Click);
            // 
            // inställningarToolStripMenuItem
            // 
            this.inställningarToolStripMenuItem.Name = "inställningarToolStripMenuItem";
            this.inställningarToolStripMenuItem.Size = new System.Drawing.Size(157, 36);
            this.inställningarToolStripMenuItem.Text = "Inställninga&r";
            this.inställningarToolStripMenuItem.Click += new System.EventHandler(this.inställningarToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(170, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1778, 840);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.picturebox_feed_preview);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textbox_feed_content);
            this.tabPage1.Controls.Add(this.textbox_feed_header);
            this.tabPage1.Controls.Add(this.label_feed_img);
            this.tabPage1.Controls.Add(this.label_feed_content);
            this.tabPage1.Controls.Add(this.label_feed_header);
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1762, 786);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 728);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Lägg till";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // picturebox_feed_preview
            // 
            this.picturebox_feed_preview.Location = new System.Drawing.Point(223, 472);
            this.picturebox_feed_preview.Name = "picturebox_feed_preview";
            this.picturebox_feed_preview.Size = new System.Drawing.Size(210, 210);
            this.picturebox_feed_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picturebox_feed_preview.TabIndex = 6;
            this.picturebox_feed_preview.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Bläddra..";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox_feed_content
            // 
            this.textbox_feed_content.Location = new System.Drawing.Point(223, 162);
            this.textbox_feed_content.Multiline = true;
            this.textbox_feed_content.Name = "textbox_feed_content";
            this.textbox_feed_content.Size = new System.Drawing.Size(354, 207);
            this.textbox_feed_content.TabIndex = 4;
            // 
            // textbox_feed_header
            // 
            this.textbox_feed_header.Location = new System.Drawing.Point(223, 71);
            this.textbox_feed_header.Name = "textbox_feed_header";
            this.textbox_feed_header.Size = new System.Drawing.Size(354, 39);
            this.textbox_feed_header.TabIndex = 3;
            // 
            // label_feed_img
            // 
            this.label_feed_img.AutoSize = true;
            this.label_feed_img.Location = new System.Drawing.Point(117, 405);
            this.label_feed_img.Name = "label_feed_img";
            this.label_feed_img.Size = new System.Drawing.Size(59, 32);
            this.label_feed_img.TabIndex = 2;
            this.label_feed_img.Text = "Bild:";
            // 
            // label_feed_content
            // 
            this.label_feed_content.AutoSize = true;
            this.label_feed_content.Location = new System.Drawing.Point(117, 162);
            this.label_feed_content.Name = "label_feed_content";
            this.label_feed_content.Size = new System.Drawing.Size(104, 32);
            this.label_feed_content.TabIndex = 1;
            this.label_feed_content.Text = "Innehåll:";
            // 
            // label_feed_header
            // 
            this.label_feed_header.AutoSize = true;
            this.label_feed_header.Location = new System.Drawing.Point(117, 78);
            this.label_feed_header.Name = "label_feed_header";
            this.label_feed_header.Size = new System.Drawing.Size(87, 32);
            this.label_feed_header.TabIndex = 0;
            this.label_feed_header.Text = "Rubrik:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_confirm_booking);
            this.tabPage2.Controls.Add(this.label_room);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label_stop_time);
            this.tabPage2.Controls.Add(this.label_start_time);
            this.tabPage2.Controls.Add(this.dateTimePicker_stop);
            this.tabPage2.Controls.Add(this.dateTimePicker_start);
            this.tabPage2.Controls.Add(this.textBox_name);
            this.tabPage2.Controls.Add(this.label_name);
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1762, 786);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_confirm_booking
            // 
            this.button_confirm_booking.Location = new System.Drawing.Point(235, 530);
            this.button_confirm_booking.Name = "button_confirm_booking";
            this.button_confirm_booking.Size = new System.Drawing.Size(164, 46);
            this.button_confirm_booking.TabIndex = 8;
            this.button_confirm_booking.Text = "Boka";
            this.button_confirm_booking.UseVisualStyleBackColor = true;
            // 
            // label_room
            // 
            this.label_room.AutoSize = true;
            this.label_room.Location = new System.Drawing.Point(73, 376);
            this.label_room.Name = "label_room";
            this.label_room.Size = new System.Drawing.Size(115, 32);
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
            this.comboBox1.Location = new System.Drawing.Point(235, 376);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 40);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Välj rum..";
            // 
            // label_stop_time
            // 
            this.label_stop_time.AutoSize = true;
            this.label_stop_time.Location = new System.Drawing.Point(73, 261);
            this.label_stop_time.Name = "label_stop_time";
            this.label_stop_time.Size = new System.Drawing.Size(50, 32);
            this.label_stop_time.TabIndex = 5;
            this.label_stop_time.Text = "Till:";
            // 
            // label_start_time
            // 
            this.label_start_time.AutoSize = true;
            this.label_start_time.Location = new System.Drawing.Point(73, 179);
            this.label_start_time.Name = "label_start_time";
            this.label_start_time.Size = new System.Drawing.Size(65, 32);
            this.label_start_time.TabIndex = 4;
            this.label_start_time.Text = "Från:";
            // 
            // dateTimePicker_stop
            // 
            this.dateTimePicker_stop.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker_stop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_stop.Location = new System.Drawing.Point(235, 254);
            this.dateTimePicker_stop.Name = "dateTimePicker_stop";
            this.dateTimePicker_stop.Size = new System.Drawing.Size(400, 39);
            this.dateTimePicker_stop.TabIndex = 3;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_start.Location = new System.Drawing.Point(235, 174);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(400, 39);
            this.dateTimePicker_start.TabIndex = 2;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(235, 66);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(200, 39);
            this.textBox_name.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(73, 66);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(84, 32);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Namn:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label_settings);
            this.tabPage3.Location = new System.Drawing.Point(8, 46);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1762, 786);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label_settings
            // 
            this.label_settings.AutoSize = true;
            this.label_settings.Location = new System.Drawing.Point(113, 82);
            this.label_settings.Name = "label_settings";
            this.label_settings.Size = new System.Drawing.Size(344, 32);
            this.label_settings.TabIndex = 0;
            this.label_settings.Text = "Inställningar är tom för tillfället";
            // 
            // browser
            // 
            this.browser.FileName = "openFileDialog1";
            // 
            // AdminTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1948, 840);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminTools";
            this.Text = "AdminTools";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_feed_preview)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem feedToolStripMenuItem;
        private ToolStripMenuItem grupprumToolStripMenuItem;
        private ToolStripMenuItem inställningarToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button2;
        private PictureBox picturebox_feed_preview;
        private Button button1;
        private TextBox textbox_feed_content;
        private TextBox textbox_feed_header;
        private Label label_feed_img;
        private Label label_feed_content;
        private Label label_feed_header;
        private OpenFileDialog browser;
        private TextBox textBox_name;
        private Label label_name;
        private DateTimePicker dateTimePicker_start;
        private DateTimePicker dateTimePicker_stop;
        private Label label_stop_time;
        private Label label_start_time;
        private ComboBox comboBox1;
        private Button button_confirm_booking;
        private Label label_room;
        private TabPage tabPage3;
        private Label label_settings;
    }
}