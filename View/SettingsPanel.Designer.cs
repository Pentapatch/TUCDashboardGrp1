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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_edit_rooms
            // 
            this.btn_edit_rooms.Location = new System.Drawing.Point(0, 76);
            this.btn_edit_rooms.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_edit_rooms.Name = "btn_edit_rooms";
            this.btn_edit_rooms.Size = new System.Drawing.Size(150, 47);
            this.btn_edit_rooms.TabIndex = 0;
            this.btn_edit_rooms.Text = "Ändra..";
            this.btn_edit_rooms.UseVisualStyleBackColor = true;
            this.btn_edit_rooms.Click += new System.EventHandler(this.btn_edit_rooms_Click);
            // 
            // btn_dataBrowse
            // 
            this.btn_dataBrowse.Location = new System.Drawing.Point(9, 76);
            this.btn_dataBrowse.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_dataBrowse.Name = "btn_dataBrowse";
            this.btn_dataBrowse.Size = new System.Drawing.Size(150, 47);
            this.btn_dataBrowse.TabIndex = 1;
            this.btn_dataBrowse.Text = "Bläddra";
            this.btn_dataBrowse.UseVisualStyleBackColor = true;
            this.btn_dataBrowse.Click += new System.EventHandler(this.btn_dataBrowse_Click);
            // 
            // lbl_currentDataFile
            // 
            this.lbl_currentDataFile.AutoSize = true;
            this.lbl_currentDataFile.Location = new System.Drawing.Point(209, 84);
            this.lbl_currentDataFile.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_currentDataFile.Name = "lbl_currentDataFile";
            this.lbl_currentDataFile.Size = new System.Drawing.Size(89, 32);
            this.lbl_currentDataFile.TabIndex = 10;
            this.lbl_currentDataFile.Text = "<tom>";
            // 
            // lbl_open
            // 
            this.lbl_open.AutoSize = true;
            this.lbl_open.Location = new System.Drawing.Point(6, 61);
            this.lbl_open.Name = "lbl_open";
            this.lbl_open.Size = new System.Drawing.Size(65, 32);
            this.lbl_open.TabIndex = 12;
            this.lbl_open.Text = "Från:";
            // 
            // dtpicker_opening
            // 
            this.dtpicker_opening.CustomFormat = "HH:mm";
            this.dtpicker_opening.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker_opening.Location = new System.Drawing.Point(104, 61);
            this.dtpicker_opening.Name = "dtpicker_opening";
            this.dtpicker_opening.ShowUpDown = true;
            this.dtpicker_opening.Size = new System.Drawing.Size(122, 39);
            this.dtpicker_opening.TabIndex = 2;
            // 
            // btn_save_openedHour
            // 
            this.btn_save_openedHour.Location = new System.Drawing.Point(6, 186);
            this.btn_save_openedHour.Name = "btn_save_openedHour";
            this.btn_save_openedHour.Size = new System.Drawing.Size(150, 46);
            this.btn_save_openedHour.TabIndex = 4;
            this.btn_save_openedHour.Text = "Spara";
            this.btn_save_openedHour.UseVisualStyleBackColor = true;
            this.btn_save_openedHour.Click += new System.EventHandler(this.btn_save_openedHour_Click);
            // 
            // dtpicker_closing
            // 
            this.dtpicker_closing.CustomFormat = "HH:mm";
            this.dtpicker_closing.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker_closing.Location = new System.Drawing.Point(104, 122);
            this.dtpicker_closing.Name = "dtpicker_closing";
            this.dtpicker_closing.ShowUpDown = true;
            this.dtpicker_closing.Size = new System.Drawing.Size(122, 39);
            this.dtpicker_closing.TabIndex = 3;
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Location = new System.Drawing.Point(6, 122);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(50, 32);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 428);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 297);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öppettider";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_dataBrowse);
            this.groupBox2.Controls.Add(this.lbl_currentDataFile);
            this.groupBox2.Location = new System.Drawing.Point(12, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 200);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ladda ny Datafil";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_edit_rooms);
            this.groupBox3.Location = new System.Drawing.Point(12, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 200);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hantera rum";
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SettingsPanel";
            this.Size = new System.Drawing.Size(2080, 1062);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
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
    }
}
