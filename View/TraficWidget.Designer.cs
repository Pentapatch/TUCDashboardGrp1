namespace TUCDashboardGrp1
{
    partial class TraficWidget
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
            this.label_dir_rese = new System.Windows.Forms.Label();
            this.label_dir_skagge = new System.Windows.Forms.Label();
            this.label_timetable_rese = new System.Windows.Forms.Label();
            this.label_timetable_skagge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_dir_rese
            // 
            this.label_dir_rese.AutoSize = true;
            this.label_dir_rese.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_dir_rese.Location = new System.Drawing.Point(23, 18);
            this.label_dir_rese.Name = "label_dir_rese";
            this.label_dir_rese.Size = new System.Drawing.Size(180, 28);
            this.label_dir_rese.TabIndex = 1;
            this.label_dir_rese.Text = "Mot Resecentrum";
            // 
            // label_dir_skagge
            // 
            this.label_dir_skagge.AutoSize = true;
            this.label_dir_skagge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_dir_skagge.Location = new System.Drawing.Point(23, 281);
            this.label_dir_skagge.Name = "label_dir_skagge";
            this.label_dir_skagge.Size = new System.Drawing.Size(165, 28);
            this.label_dir_skagge.TabIndex = 2;
            this.label_dir_skagge.Text = "Mot Skäggetorp";
            // 
            // label_timetable_rese
            // 
            this.label_timetable_rese.AutoSize = true;
            this.label_timetable_rese.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_timetable_rese.Location = new System.Drawing.Point(23, 69);
            this.label_timetable_rese.Name = "label_timetable_rese";
            this.label_timetable_rese.Size = new System.Drawing.Size(0, 28);
            this.label_timetable_rese.TabIndex = 3;
            // 
            // label_timetable_skagge
            // 
            this.label_timetable_skagge.AutoSize = true;
            this.label_timetable_skagge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_timetable_skagge.Location = new System.Drawing.Point(23, 332);
            this.label_timetable_skagge.Name = "label_timetable_skagge";
            this.label_timetable_skagge.Size = new System.Drawing.Size(0, 28);
            this.label_timetable_skagge.TabIndex = 4;
            // 
            // TraficWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_timetable_skagge);
            this.Controls.Add(this.label_timetable_rese);
            this.Controls.Add(this.label_dir_skagge);
            this.Controls.Add(this.label_dir_rese);
            this.Name = "TraficWidget";
            this.Size = new System.Drawing.Size(994, 704);
            this.Load += new System.EventHandler(this.TraficWidget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_dir_rese;
        private Label label_dir_skagge;
        private Label label_timetable_rese;
        private Label label_timetable_skagge;
    }
}
