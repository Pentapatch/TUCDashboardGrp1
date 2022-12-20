namespace TUCDashboardGrp1
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.weatherWidghet1 = new TUCDashboardGrp1.WeatherWidghet();
            this.feedWidget1 = new TUCDashboardGrp1.FeedWidget();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.traficWidget1 = new TUCDashboardGrp1.TraficWidget();
            this.clockWidget1 = new TUCDashboardGrp1.View.ClockWidget();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupRoomsWidget1 = new TUCDashboardGrp1.GroupRoomsWidget();
            this.lecturesWidget1 = new TUCDashboardGrp1.LecturesWidget();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1377, 665);
            this.splitContainer1.SplitterDistance = 458;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.weatherWidghet1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.feedWidget1);
            this.splitContainer3.Size = new System.Drawing.Size(458, 665);
            this.splitContainer3.SplitterDistance = 284;
            this.splitContainer3.TabIndex = 1;
            // 
            // weatherWidghet1
            // 
            this.weatherWidghet1.BackgroundColor = System.Drawing.Color.White;
            this.weatherWidghet1.BorderColor = System.Drawing.Color.White;
            this.weatherWidghet1.BorderRadius = 15;
            this.weatherWidghet1.BorderWidth = 2;
            this.weatherWidghet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weatherWidghet1.IsHighlighted = false;
            this.weatherWidghet1.Location = new System.Drawing.Point(0, 0);
            this.weatherWidghet1.Name = "weatherWidghet1";
            this.weatherWidghet1.Size = new System.Drawing.Size(458, 284);
            this.weatherWidghet1.TabIndex = 0;
            // 
            // feedWidget1
            // 
            this.feedWidget1.BackgroundColor = System.Drawing.Color.White;
            this.feedWidget1.BorderColor = System.Drawing.Color.White;
            this.feedWidget1.BorderRadius = 15;
            this.feedWidget1.BorderWidth = 2;
            this.feedWidget1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedWidget1.Interval = 2500;
            this.feedWidget1.IsHighlighted = false;
            this.feedWidget1.Location = new System.Drawing.Point(0, 0);
            this.feedWidget1.Name = "feedWidget1";
            this.feedWidget1.Size = new System.Drawing.Size(458, 377);
            this.feedWidget1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(915, 665);
            this.splitContainer2.SplitterDistance = 284;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.traficWidget1);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.clockWidget1);
            this.splitContainer5.Size = new System.Drawing.Size(915, 284);
            this.splitContainer5.SplitterDistance = 305;
            this.splitContainer5.TabIndex = 0;
            // 
            // traficWidget1
            // 
            this.traficWidget1.BackgroundColor = System.Drawing.Color.White;
            this.traficWidget1.BorderColor = System.Drawing.Color.White;
            this.traficWidget1.BorderRadius = 15;
            this.traficWidget1.BorderWidth = 2;
            this.traficWidget1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.traficWidget1.IsHighlighted = false;
            this.traficWidget1.Location = new System.Drawing.Point(0, 0);
            this.traficWidget1.Name = "traficWidget1";
            this.traficWidget1.Size = new System.Drawing.Size(305, 284);
            this.traficWidget1.TabIndex = 1;
            // 
            // clockWidget1
            // 
            this.clockWidget1.BackgroundColor = System.Drawing.Color.White;
            this.clockWidget1.BorderColor = System.Drawing.Color.White;
            this.clockWidget1.BorderRadius = 15;
            this.clockWidget1.BorderWidth = 2;
            this.clockWidget1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clockWidget1.IsHighlighted = false;
            this.clockWidget1.Location = new System.Drawing.Point(0, 0);
            this.clockWidget1.Name = "clockWidget1";
            this.clockWidget1.Size = new System.Drawing.Size(606, 284);
            this.clockWidget1.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupRoomsWidget1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.lecturesWidget1);
            this.splitContainer4.Size = new System.Drawing.Size(915, 377);
            this.splitContainer4.SplitterDistance = 305;
            this.splitContainer4.TabIndex = 0;
            // 
            // groupRoomsWidget1
            // 
            this.groupRoomsWidget1.BackgroundColor = System.Drawing.Color.White;
            this.groupRoomsWidget1.BorderColor = System.Drawing.Color.White;
            this.groupRoomsWidget1.BorderRadius = 15;
            this.groupRoomsWidget1.BorderWidth = 2;
            this.groupRoomsWidget1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupRoomsWidget1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupRoomsWidget1.IsHighlighted = false;
            this.groupRoomsWidget1.Location = new System.Drawing.Point(0, 0);
            this.groupRoomsWidget1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupRoomsWidget1.Name = "groupRoomsWidget1";
            this.groupRoomsWidget1.Rooms = ((System.Collections.Generic.List<string>)(resources.GetObject("groupRoomsWidget1.Rooms")));
            this.groupRoomsWidget1.RowHeight = 45;
            this.groupRoomsWidget1.Size = new System.Drawing.Size(305, 377);
            this.groupRoomsWidget1.TabIndex = 0;
            this.groupRoomsWidget1.TimelineHeight = 30;
            this.groupRoomsWidget1.WidgetName = "Grupprum";
            // 
            // lecturesWidget1
            // 
            this.lecturesWidget1.BackgroundColor = System.Drawing.Color.White;
            this.lecturesWidget1.BorderColor = System.Drawing.Color.White;
            this.lecturesWidget1.BorderRadius = 15;
            this.lecturesWidget1.BorderWidth = 2;
            this.lecturesWidget1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lecturesWidget1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lecturesWidget1.IsHighlighted = false;
            this.lecturesWidget1.Location = new System.Drawing.Point(0, 0);
            this.lecturesWidget1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lecturesWidget1.Name = "lecturesWidget1";
            this.lecturesWidget1.Rooms = ((System.Collections.Generic.List<string>)(resources.GetObject("lecturesWidget1.Rooms")));
            this.lecturesWidget1.RowHeight = 45;
            this.lecturesWidget1.Size = new System.Drawing.Size(606, 377);
            this.lecturesWidget1.TabIndex = 0;
            this.lecturesWidget1.TimelineHeight = 30;
            this.lecturesWidget1.WidgetName = "Lektionssalar";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 665);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DashboardForm_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer4;
        private WeatherWidghet weatherWidghet1;
        private GroupRoomsWidget groupRoomsWidget1;
        private LecturesWidget lecturesWidget1;
        private FeedWidget feedWidget1;
        private SplitContainer splitContainer5;
        private TraficWidget traficWidget1;
        private View.ClockWidget clockWidget1;
    }
}