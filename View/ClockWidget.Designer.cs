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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_time.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_time.Location = new System.Drawing.Point(0, 63);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(574, 19);
            this.label_time.TabIndex = 0;
            this.label_time.Text = "Time";
            this.label_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_date
            // 
            this.label_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_date.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_date.Location = new System.Drawing.Point(0, 103);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(574, 19);
            this.label_date.TabIndex = 1;
            this.label_date.Text = "Date";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClockWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_time);
            this.Name = "ClockWidget";
            this.Size = new System.Drawing.Size(574, 211);
            this.Load += new System.EventHandler(this.ClockWidget_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label_time;
        private Label label_date;
        private System.Windows.Forms.Timer timer1;
    }
}
