namespace TUCDashboardGrp1.View
{
    partial class SettingsPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_edit_rooms = new System.Windows.Forms.Button();
            this.btn_dataBrowse = new System.Windows.Forms.Button();
            this.lbl_currentDataFile = new System.Windows.Forms.Label();
            this.lbl_open = new System.Windows.Forms.Label();
            this.dtpicker_opening = new System.Windows.Forms.DateTimePicker();
            this.btn_save_openedHour = new System.Windows.Forms.Button();
            this.dtpicker_closing = new System.Windows.Forms.DateTimePicker();
            this.lbl_close = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.slider_borderWidth = new System.Windows.Forms.TrackBar();
            this.slider_borderRadius = new System.Windows.Forms.TrackBar();
            this.lbl_borderColorPreview = new System.Windows.Forms.Label();
            this.btn_browseForBorderColor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_clearLogotypePath = new System.Windows.Forms.Button();
            this.pb_logotypePreview = new System.Windows.Forms.PictureBox();
            this.lbl_textColorPreview = new System.Windows.Forms.Label();
            this.btn_browseForTextColor = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_accentColorPreview = new System.Windows.Forms.Label();
            this.btn_browseForAccentColor = new System.Windows.Forms.Button();
            this.lbl_baseColorPreview = new System.Windows.Forms.Label();
            this.btn_browseForBaseColor = new System.Windows.Forms.Button();
            this.lbl_widgetBackgroundColorPreview = new System.Windows.Forms.Label();
            this.btn_browseForWidgetBackgroundColor = new System.Windows.Forms.Button();
            this.lbl_backgroundColorPreview = new System.Windows.Forms.Label();
            this.btn_browseForBackgroundColor = new System.Windows.Forms.Button();
            this.btn_browseForLogotypePath = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_logotypePath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_borderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_borderRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logotypePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_edit_rooms
            // 
            this.btn_edit_rooms.Location = new System.Drawing.Point(5, 43);
            this.btn_edit_rooms.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_edit_rooms.Name = "btn_edit_rooms";
            this.btn_edit_rooms.Size = new System.Drawing.Size(81, 22);
            this.btn_edit_rooms.TabIndex = 0;
            this.btn_edit_rooms.Text = "Ändra..";
            this.btn_edit_rooms.UseVisualStyleBackColor = true;
            this.btn_edit_rooms.Click += new System.EventHandler(this.btn_edit_rooms_Click);
            // 
            // btn_dataBrowse
            // 
            this.btn_dataBrowse.Location = new System.Drawing.Point(5, 36);
            this.btn_dataBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dataBrowse.Name = "btn_dataBrowse";
            this.btn_dataBrowse.Size = new System.Drawing.Size(81, 22);
            this.btn_dataBrowse.TabIndex = 1;
            this.btn_dataBrowse.Text = "Bläddra..";
            this.btn_dataBrowse.UseVisualStyleBackColor = true;
            this.btn_dataBrowse.Click += new System.EventHandler(this.btn_dataBrowse_Click);
            // 
            // lbl_currentDataFile
            // 
            this.lbl_currentDataFile.AutoSize = true;
            this.lbl_currentDataFile.Location = new System.Drawing.Point(92, 40);
            this.lbl_currentDataFile.Name = "lbl_currentDataFile";
            this.lbl_currentDataFile.Size = new System.Drawing.Size(45, 15);
            this.lbl_currentDataFile.TabIndex = 10;
            this.lbl_currentDataFile.Text = "<tom>";
            // 
            // lbl_open
            // 
            this.lbl_open.AutoSize = true;
            this.lbl_open.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_open.Location = new System.Drawing.Point(3, 29);
            this.lbl_open.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_open.Name = "lbl_open";
            this.lbl_open.Size = new System.Drawing.Size(34, 15);
            this.lbl_open.TabIndex = 12;
            this.lbl_open.Text = "Från:";
            // 
            // dtpicker_opening
            // 
            this.dtpicker_opening.CustomFormat = "HH:mm";
            this.dtpicker_opening.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker_opening.Location = new System.Drawing.Point(56, 29);
            this.dtpicker_opening.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpicker_opening.Name = "dtpicker_opening";
            this.dtpicker_opening.ShowUpDown = true;
            this.dtpicker_opening.Size = new System.Drawing.Size(68, 23);
            this.dtpicker_opening.TabIndex = 2;
            // 
            // btn_save_openedHour
            // 
            this.btn_save_openedHour.Location = new System.Drawing.Point(3, 87);
            this.btn_save_openedHour.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_save_openedHour.Name = "btn_save_openedHour";
            this.btn_save_openedHour.Size = new System.Drawing.Size(81, 22);
            this.btn_save_openedHour.TabIndex = 4;
            this.btn_save_openedHour.Text = "Spara";
            this.btn_save_openedHour.UseVisualStyleBackColor = true;
            this.btn_save_openedHour.Click += new System.EventHandler(this.btn_save_openedHour_Click);
            // 
            // dtpicker_closing
            // 
            this.dtpicker_closing.CustomFormat = "HH:mm";
            this.dtpicker_closing.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker_closing.Location = new System.Drawing.Point(56, 57);
            this.dtpicker_closing.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpicker_closing.Name = "dtpicker_closing";
            this.dtpicker_closing.ShowUpDown = true;
            this.dtpicker_closing.Size = new System.Drawing.Size(68, 23);
            this.dtpicker_closing.TabIndex = 3;
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_close.Location = new System.Drawing.Point(3, 57);
            this.lbl_close.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(26, 15);
            this.lbl_close.TabIndex = 16;
            this.lbl_close.Text = "Till:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_close);
            this.groupBox1.Controls.Add(this.lbl_open);
            this.groupBox1.Controls.Add(this.dtpicker_closing);
            this.groupBox1.Controls.Add(this.dtpicker_opening);
            this.groupBox1.Controls.Add(this.btn_save_openedHour);
            this.groupBox1.Location = new System.Drawing.Point(6, 201);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(215, 139);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öppettider";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_dataBrowse);
            this.groupBox2.Controls.Add(this.lbl_currentDataFile);
            this.groupBox2.Location = new System.Drawing.Point(6, 104);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Size = new System.Drawing.Size(215, 94);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ladda ny Datafil";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_edit_rooms);
            this.groupBox3.Location = new System.Drawing.Point(6, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Size = new System.Drawing.Size(215, 94);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hantera rum";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.slider_borderWidth);
            this.groupBox4.Controls.Add(this.slider_borderRadius);
            this.groupBox4.Controls.Add(this.lbl_borderColorPreview);
            this.groupBox4.Controls.Add(this.btn_browseForBorderColor);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btn_clearLogotypePath);
            this.groupBox4.Controls.Add(this.pb_logotypePreview);
            this.groupBox4.Controls.Add(this.lbl_textColorPreview);
            this.groupBox4.Controls.Add(this.btn_browseForTextColor);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lbl_accentColorPreview);
            this.groupBox4.Controls.Add(this.btn_browseForAccentColor);
            this.groupBox4.Controls.Add(this.lbl_baseColorPreview);
            this.groupBox4.Controls.Add(this.btn_browseForBaseColor);
            this.groupBox4.Controls.Add(this.lbl_widgetBackgroundColorPreview);
            this.groupBox4.Controls.Add(this.btn_browseForWidgetBackgroundColor);
            this.groupBox4.Controls.Add(this.lbl_backgroundColorPreview);
            this.groupBox4.Controls.Add(this.btn_browseForBackgroundColor);
            this.groupBox4.Controls.Add(this.btn_browseForLogotypePath);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lbl_logotypePath);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(226, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(809, 403);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Applikationstema";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(316, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ramstorlek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(206, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Avrundning (ram)";
            // 
            // slider_borderWidth
            // 
            this.slider_borderWidth.Location = new System.Drawing.Point(316, 340);
            this.slider_borderWidth.Maximum = 6;
            this.slider_borderWidth.Name = "slider_borderWidth";
            this.slider_borderWidth.Size = new System.Drawing.Size(104, 45);
            this.slider_borderWidth.TabIndex = 27;
            this.slider_borderWidth.ValueChanged += new System.EventHandler(this.slider_borderWidth_ValueChanged);
            // 
            // slider_borderRadius
            // 
            this.slider_borderRadius.Location = new System.Drawing.Point(206, 340);
            this.slider_borderRadius.Maximum = 100;
            this.slider_borderRadius.Name = "slider_borderRadius";
            this.slider_borderRadius.Size = new System.Drawing.Size(104, 45);
            this.slider_borderRadius.TabIndex = 26;
            this.slider_borderRadius.TickFrequency = 10;
            this.slider_borderRadius.ValueChanged += new System.EventHandler(this.slider_borderRadius_ValueChanged);
            // 
            // lbl_borderColorPreview
            // 
            this.lbl_borderColorPreview.BackColor = System.Drawing.Color.Black;
            this.lbl_borderColorPreview.Location = new System.Drawing.Point(6, 365);
            this.lbl_borderColorPreview.Name = "lbl_borderColorPreview";
            this.lbl_borderColorPreview.Size = new System.Drawing.Size(20, 20);
            this.lbl_borderColorPreview.TabIndex = 25;
            // 
            // btn_browseForBorderColor
            // 
            this.btn_browseForBorderColor.Location = new System.Drawing.Point(32, 364);
            this.btn_browseForBorderColor.Name = "btn_browseForBorderColor";
            this.btn_browseForBorderColor.Size = new System.Drawing.Size(95, 23);
            this.btn_browseForBorderColor.TabIndex = 24;
            this.btn_browseForBorderColor.Text = "Välj..";
            this.btn_browseForBorderColor.UseVisualStyleBackColor = true;
            this.btn_browseForBorderColor.Click += new System.EventHandler(this.btn_browseForBorderColor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ramfärg";
            // 
            // btn_clearLogotypePath
            // 
            this.btn_clearLogotypePath.Location = new System.Drawing.Point(96, 43);
            this.btn_clearLogotypePath.Name = "btn_clearLogotypePath";
            this.btn_clearLogotypePath.Size = new System.Drawing.Size(50, 23);
            this.btn_clearLogotypePath.TabIndex = 22;
            this.btn_clearLogotypePath.Text = "Rensa";
            this.btn_clearLogotypePath.UseVisualStyleBackColor = true;
            this.btn_clearLogotypePath.Click += new System.EventHandler(this.btn_clearLogotypePath_Click);
            // 
            // pb_logotypePreview
            // 
            this.pb_logotypePreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pb_logotypePreview.Location = new System.Drawing.Point(206, 22);
            this.pb_logotypePreview.Name = "pb_logotypePreview";
            this.pb_logotypePreview.Size = new System.Drawing.Size(589, 280);
            this.pb_logotypePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logotypePreview.TabIndex = 21;
            this.pb_logotypePreview.TabStop = false;
            // 
            // lbl_textColorPreview
            // 
            this.lbl_textColorPreview.BackColor = System.Drawing.Color.Black;
            this.lbl_textColorPreview.Location = new System.Drawing.Point(6, 315);
            this.lbl_textColorPreview.Name = "lbl_textColorPreview";
            this.lbl_textColorPreview.Size = new System.Drawing.Size(20, 20);
            this.lbl_textColorPreview.TabIndex = 17;
            // 
            // btn_browseForTextColor
            // 
            this.btn_browseForTextColor.Location = new System.Drawing.Point(32, 314);
            this.btn_browseForTextColor.Name = "btn_browseForTextColor";
            this.btn_browseForTextColor.Size = new System.Drawing.Size(95, 23);
            this.btn_browseForTextColor.TabIndex = 16;
            this.btn_browseForTextColor.Text = "Välj..";
            this.btn_browseForTextColor.UseVisualStyleBackColor = true;
            this.btn_browseForTextColor.Click += new System.EventHandler(this.btn_browseForTextColor_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(6, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "Textfärg";
            // 
            // lbl_accentColorPreview
            // 
            this.lbl_accentColorPreview.BackColor = System.Drawing.Color.Red;
            this.lbl_accentColorPreview.Location = new System.Drawing.Point(6, 262);
            this.lbl_accentColorPreview.Name = "lbl_accentColorPreview";
            this.lbl_accentColorPreview.Size = new System.Drawing.Size(20, 20);
            this.lbl_accentColorPreview.TabIndex = 14;
            // 
            // btn_browseForAccentColor
            // 
            this.btn_browseForAccentColor.Location = new System.Drawing.Point(32, 261);
            this.btn_browseForAccentColor.Name = "btn_browseForAccentColor";
            this.btn_browseForAccentColor.Size = new System.Drawing.Size(95, 23);
            this.btn_browseForAccentColor.TabIndex = 13;
            this.btn_browseForAccentColor.Text = "Välj..";
            this.btn_browseForAccentColor.UseVisualStyleBackColor = true;
            this.btn_browseForAccentColor.Click += new System.EventHandler(this.btn_browseForAccentColor_Click);
            // 
            // lbl_baseColorPreview
            // 
            this.lbl_baseColorPreview.BackColor = System.Drawing.Color.Gray;
            this.lbl_baseColorPreview.Location = new System.Drawing.Point(6, 207);
            this.lbl_baseColorPreview.Name = "lbl_baseColorPreview";
            this.lbl_baseColorPreview.Size = new System.Drawing.Size(20, 20);
            this.lbl_baseColorPreview.TabIndex = 12;
            // 
            // btn_browseForBaseColor
            // 
            this.btn_browseForBaseColor.Location = new System.Drawing.Point(32, 206);
            this.btn_browseForBaseColor.Name = "btn_browseForBaseColor";
            this.btn_browseForBaseColor.Size = new System.Drawing.Size(95, 23);
            this.btn_browseForBaseColor.TabIndex = 11;
            this.btn_browseForBaseColor.Text = "Välj..";
            this.btn_browseForBaseColor.UseVisualStyleBackColor = true;
            this.btn_browseForBaseColor.Click += new System.EventHandler(this.btn_browseForBaseColor_Click);
            // 
            // lbl_widgetBackgroundColorPreview
            // 
            this.lbl_widgetBackgroundColorPreview.BackColor = System.Drawing.Color.White;
            this.lbl_widgetBackgroundColorPreview.Location = new System.Drawing.Point(6, 152);
            this.lbl_widgetBackgroundColorPreview.Name = "lbl_widgetBackgroundColorPreview";
            this.lbl_widgetBackgroundColorPreview.Size = new System.Drawing.Size(20, 20);
            this.lbl_widgetBackgroundColorPreview.TabIndex = 10;
            // 
            // btn_browseForWidgetBackgroundColor
            // 
            this.btn_browseForWidgetBackgroundColor.Location = new System.Drawing.Point(32, 151);
            this.btn_browseForWidgetBackgroundColor.Name = "btn_browseForWidgetBackgroundColor";
            this.btn_browseForWidgetBackgroundColor.Size = new System.Drawing.Size(95, 23);
            this.btn_browseForWidgetBackgroundColor.TabIndex = 9;
            this.btn_browseForWidgetBackgroundColor.Text = "Välj..";
            this.btn_browseForWidgetBackgroundColor.UseVisualStyleBackColor = true;
            this.btn_browseForWidgetBackgroundColor.Click += new System.EventHandler(this.btn_browseForWidgetBackgroundColor_Click);
            // 
            // lbl_backgroundColorPreview
            // 
            this.lbl_backgroundColorPreview.BackColor = System.Drawing.Color.Red;
            this.lbl_backgroundColorPreview.Location = new System.Drawing.Point(6, 94);
            this.lbl_backgroundColorPreview.Name = "lbl_backgroundColorPreview";
            this.lbl_backgroundColorPreview.Size = new System.Drawing.Size(20, 20);
            this.lbl_backgroundColorPreview.TabIndex = 8;
            // 
            // btn_browseForBackgroundColor
            // 
            this.btn_browseForBackgroundColor.Location = new System.Drawing.Point(32, 93);
            this.btn_browseForBackgroundColor.Name = "btn_browseForBackgroundColor";
            this.btn_browseForBackgroundColor.Size = new System.Drawing.Size(95, 23);
            this.btn_browseForBackgroundColor.TabIndex = 7;
            this.btn_browseForBackgroundColor.Text = "Välj..";
            this.btn_browseForBackgroundColor.UseVisualStyleBackColor = true;
            this.btn_browseForBackgroundColor.Click += new System.EventHandler(this.btn_browseForBackgroundColor_Click);
            // 
            // btn_browseForLogotypePath
            // 
            this.btn_browseForLogotypePath.Location = new System.Drawing.Point(6, 43);
            this.btn_browseForLogotypePath.Name = "btn_browseForLogotypePath";
            this.btn_browseForLogotypePath.Size = new System.Drawing.Size(84, 23);
            this.btn_browseForLogotypePath.TabIndex = 6;
            this.btn_browseForLogotypePath.Text = "Bläddra..";
            this.btn_browseForLogotypePath.UseVisualStyleBackColor = true;
            this.btn_browseForLogotypePath.Click += new System.EventHandler(this.btn_browseForLogotypePath_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Accentfärg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Basfärg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bakgrundsfärg (Widget)";
            // 
            // lbl_logotypePath
            // 
            this.lbl_logotypePath.AutoSize = true;
            this.lbl_logotypePath.Location = new System.Drawing.Point(63, 25);
            this.lbl_logotypePath.Name = "lbl_logotypePath";
            this.lbl_logotypePath.Size = new System.Drawing.Size(80, 15);
            this.lbl_logotypePath.TabIndex = 2;
            this.lbl_logotypePath.Text = "<path to file>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bakgrundsfärg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logotyp";
            // 
            // SettingsPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsPanel";
            this.Size = new System.Drawing.Size(1120, 498);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_borderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_borderRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logotypePreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_edit_rooms;
        private Button btn_dataBrowse;
        private Label lbl_currentDataFile;
        private Label lbl_open;
        private DateTimePicker dtpicker_opening;
        private Button btn_save_openedHour;
        private DateTimePicker dtpicker_closing;
        private Label lbl_close;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btn_browseForLogotypePath;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lbl_logotypePath;
        private Label label2;
        private Label label1;
        private Label lbl_backgroundColorPreview;
        private Button btn_browseForBackgroundColor;
        private Label lbl_accentColorPreview;
        private Button btn_browseForAccentColor;
        private Label lbl_baseColorPreview;
        private Button btn_browseForBaseColor;
        private Label lbl_widgetBackgroundColorPreview;
        private Button btn_browseForWidgetBackgroundColor;
        private Label lbl_textColorPreview;
        private Button btn_browseForTextColor;
        private Label label12;
        private PictureBox pb_logotypePreview;
        private Button btn_clearLogotypePath;
        private Label lbl_borderColorPreview;
        private Button btn_browseForBorderColor;
        private Label label7;
        private Label label8;
        private Label label3;
        private TrackBar slider_borderWidth;
        private TrackBar slider_borderRadius;
    }
}
