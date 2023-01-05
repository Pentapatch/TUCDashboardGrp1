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
            this.label_edit_rooms = new System.Windows.Forms.Label();
            this.btn_edit_rooms = new System.Windows.Forms.Button();
            this.btn_dataBrowse = new System.Windows.Forms.Button();
            this.label_settings = new System.Windows.Forms.Label();
            this.lbl_currentDataFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_edit_rooms
            // 
            this.label_edit_rooms.AutoSize = true;
            this.label_edit_rooms.Location = new System.Drawing.Point(3, 5);
            this.label_edit_rooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_edit_rooms.Name = "label_edit_rooms";
            this.label_edit_rooms.Size = new System.Drawing.Size(77, 15);
            this.label_edit_rooms.TabIndex = 9;
            this.label_edit_rooms.Text = "Hantera rum:";
            // 
            // btn_edit_rooms
            // 
            this.btn_edit_rooms.Location = new System.Drawing.Point(3, 38);
            this.btn_edit_rooms.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_edit_rooms.Name = "btn_edit_rooms";
            this.btn_edit_rooms.Size = new System.Drawing.Size(81, 22);
            this.btn_edit_rooms.TabIndex = 7;
            this.btn_edit_rooms.Text = "Ändra..";
            this.btn_edit_rooms.UseVisualStyleBackColor = true;
            this.btn_edit_rooms.Click += new System.EventHandler(this.btn_edit_rooms_Click);
            // 
            // btn_dataBrowse
            // 
            this.btn_dataBrowse.Location = new System.Drawing.Point(3, 134);
            this.btn_dataBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dataBrowse.Name = "btn_dataBrowse";
            this.btn_dataBrowse.Size = new System.Drawing.Size(81, 22);
            this.btn_dataBrowse.TabIndex = 6;
            this.btn_dataBrowse.Text = "Bläddra";
            this.btn_dataBrowse.UseVisualStyleBackColor = true;
            this.btn_dataBrowse.Click += new System.EventHandler(this.btn_dataBrowse_Click);
            // 
            // label_settings
            // 
            this.label_settings.AutoSize = true;
            this.label_settings.Location = new System.Drawing.Point(3, 99);
            this.label_settings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_settings.Name = "label_settings";
            this.label_settings.Size = new System.Drawing.Size(94, 15);
            this.label_settings.TabIndex = 5;
            this.label_settings.Text = "Ladda ny DataFil";
            // 
            // lbl_currentDataFile
            // 
            this.lbl_currentDataFile.AutoSize = true;
            this.lbl_currentDataFile.Location = new System.Drawing.Point(111, 138);
            this.lbl_currentDataFile.Name = "lbl_currentDataFile";
            this.lbl_currentDataFile.Size = new System.Drawing.Size(45, 15);
            this.lbl_currentDataFile.TabIndex = 10;
            this.lbl_currentDataFile.Text = "<tom>";
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_currentDataFile);
            this.Controls.Add(this.label_edit_rooms);
            this.Controls.Add(this.btn_edit_rooms);
            this.Controls.Add(this.btn_dataBrowse);
            this.Controls.Add(this.label_settings);
            this.Name = "SettingsPanel";
            this.Size = new System.Drawing.Size(1120, 498);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_edit_rooms;
        private Button btn_edit_rooms;
        private Button btn_dataBrowse;
        private Label label_settings;
        private Label lbl_currentDataFile;
    }
}
