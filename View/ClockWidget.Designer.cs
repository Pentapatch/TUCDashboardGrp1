namespace TUCDashboardGrp1.View
{
    partial class ClockWidget
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
            this.components = new System.ComponentModel.Container();
            this.label_time = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.Refresher = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Elephant", 39.74999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_time.Location = new System.Drawing.Point(0, 47);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(168, 68);
            this.label_time.TabIndex = 0;
            this.label_time.Text = "Time";
            this.label_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_date.Location = new System.Drawing.Point(0, 77);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(49, 24);
            this.label_date.TabIndex = 1;
            this.label_date.Text = "Date";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Refresher
            // 
            this.Refresher.Enabled = true;
            this.Refresher.Interval = 10000;
            this.Refresher.Tick += new System.EventHandler(this.Refresher_Tick);
            // 
            // ClockWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderWidth = 0;
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_time);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClockWidget";
            this.Size = new System.Drawing.Size(502, 158);
            this.Load += new System.EventHandler(this.ClockWidget_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_time;
        private Label label_date;
        private System.Windows.Forms.Timer Refresher;
    }
}
