﻿namespace TUCDashboardGrp1
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
            this.sc_main = new System.Windows.Forms.SplitContainer();
            this.sc_top = new System.Windows.Forms.SplitContainer();
            this.sc_top_left = new System.Windows.Forms.SplitContainer();
            this.clockWidget1 = new TUCDashboardGrp1.View.ClockWidget();
            this.sc_top_right = new System.Windows.Forms.SplitContainer();
            this.weatherWidghet1 = new TUCDashboardGrp1.WeatherWidghet();
            this.traficWidget1 = new TUCDashboardGrp1.TraficWidget();
            this.sc_bottom = new System.Windows.Forms.SplitContainer();
            this.feedWidget1 = new TUCDashboardGrp1.FeedWidget();
            this.sc_right = new System.Windows.Forms.SplitContainer();
            this.lecturesWidget1 = new TUCDashboardGrp1.LecturesWidget();
            this.roomsWidget1 = new TUCDashboardGrp1.Model.RoomsWidget();
            ((System.ComponentModel.ISupportInitialize)(this.sc_main)).BeginInit();
            this.sc_main.Panel1.SuspendLayout();
            this.sc_main.Panel2.SuspendLayout();
            this.sc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_top)).BeginInit();
            this.sc_top.Panel1.SuspendLayout();
            this.sc_top.Panel2.SuspendLayout();
            this.sc_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_top_left)).BeginInit();
            this.sc_top_left.Panel2.SuspendLayout();
            this.sc_top_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_top_right)).BeginInit();
            this.sc_top_right.Panel1.SuspendLayout();
            this.sc_top_right.Panel2.SuspendLayout();
            this.sc_top_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_bottom)).BeginInit();
            this.sc_bottom.Panel1.SuspendLayout();
            this.sc_bottom.Panel2.SuspendLayout();
            this.sc_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_right)).BeginInit();
            this.sc_right.Panel1.SuspendLayout();
            this.sc_right.Panel2.SuspendLayout();
            this.sc_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc_main
            // 
            this.sc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_main.Location = new System.Drawing.Point(0, 0);
            this.sc_main.Name = "sc_main";
            this.sc_main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_main.Panel1
            // 
            this.sc_main.Panel1.Controls.Add(this.sc_top);
            // 
            // sc_main.Panel2
            // 
            this.sc_main.Panel2.Controls.Add(this.sc_bottom);
            this.sc_main.Size = new System.Drawing.Size(1377, 774);
            this.sc_main.SplitterDistance = 154;
            this.sc_main.TabIndex = 0;
            // 
            // sc_top
            // 
            this.sc_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_top.Location = new System.Drawing.Point(0, 0);
            this.sc_top.Name = "sc_top";
            // 
            // sc_top.Panel1
            // 
            this.sc_top.Panel1.Controls.Add(this.sc_top_left);
            // 
            // sc_top.Panel2
            // 
            this.sc_top.Panel2.Controls.Add(this.sc_top_right);
            this.sc_top.Size = new System.Drawing.Size(1377, 154);
            this.sc_top.SplitterDistance = 459;
            this.sc_top.TabIndex = 0;
            // 
            // sc_top_left
            // 
            this.sc_top_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_top_left.Location = new System.Drawing.Point(0, 0);
            this.sc_top_left.Name = "sc_top_left";
            // 
            // sc_top_left.Panel2
            // 
            this.sc_top_left.Panel2.Controls.Add(this.clockWidget1);
            this.sc_top_left.Size = new System.Drawing.Size(459, 154);
            this.sc_top_left.SplitterDistance = 229;
            this.sc_top_left.TabIndex = 0;
            // 
            // clockWidget1
            // 
            this.clockWidget1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.clockWidget1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.clockWidget1.BorderRadius = 50;
            this.clockWidget1.BorderWidth = 0;
            this.clockWidget1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clockWidget1.IsHighlighted = false;
            this.clockWidget1.Location = new System.Drawing.Point(0, 0);
            this.clockWidget1.Name = "clockWidget1";
            this.clockWidget1.Size = new System.Drawing.Size(226, 154);
            this.clockWidget1.TabIndex = 0;
            // 
            // sc_top_right
            // 
            this.sc_top_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_top_right.Location = new System.Drawing.Point(0, 0);
            this.sc_top_right.Name = "sc_top_right";
            // 
            // sc_top_right.Panel1
            // 
            this.sc_top_right.Panel1.Controls.Add(this.weatherWidghet1);
            // 
            // sc_top_right.Panel2
            // 
            this.sc_top_right.Panel2.Controls.Add(this.traficWidget1);
            this.sc_top_right.Size = new System.Drawing.Size(914, 154);
            this.sc_top_right.SplitterDistance = 431;
            this.sc_top_right.TabIndex = 0;
            // 
            // weatherWidghet1
            // 
            this.weatherWidghet1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.weatherWidghet1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.weatherWidghet1.BorderRadius = 50;
            this.weatherWidghet1.BorderWidth = 2;
            this.weatherWidghet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weatherWidghet1.ForecastEnabled = true;
            this.weatherWidghet1.IsHighlighted = false;
            this.weatherWidghet1.Location = new System.Drawing.Point(0, 0);
            this.weatherWidghet1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.weatherWidghet1.Name = "weatherWidghet1";
            this.weatherWidghet1.Size = new System.Drawing.Size(431, 154);
            this.weatherWidghet1.TabIndex = 0;
            // 
            // traficWidget1
            // 
            this.traficWidget1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.traficWidget1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.traficWidget1.BorderRadius = 50;
            this.traficWidget1.BorderWidth = 2;
            this.traficWidget1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.traficWidget1.IsHighlighted = false;
            this.traficWidget1.Location = new System.Drawing.Point(0, 0);
            this.traficWidget1.Name = "traficWidget1";
            this.traficWidget1.NumberOfTrips = 4;
            this.traficWidget1.Size = new System.Drawing.Size(479, 154);
            this.traficWidget1.TabIndex = 0;
            // 
            // sc_bottom
            // 
            this.sc_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_bottom.Location = new System.Drawing.Point(0, 0);
            this.sc_bottom.Name = "sc_bottom";
            // 
            // sc_bottom.Panel1
            // 
            this.sc_bottom.Panel1.Controls.Add(this.feedWidget1);
            // 
            // sc_bottom.Panel2
            // 
            this.sc_bottom.Panel2.Controls.Add(this.sc_right);
            this.sc_bottom.Size = new System.Drawing.Size(1377, 616);
            this.sc_bottom.SplitterDistance = 459;
            this.sc_bottom.TabIndex = 0;
            // 
            // feedWidget1
            // 
            this.feedWidget1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.feedWidget1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.feedWidget1.BorderRadius = 50;
            this.feedWidget1.BorderWidth = 2;
            this.feedWidget1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedWidget1.IsHighlighted = false;
            this.feedWidget1.Location = new System.Drawing.Point(0, 0);
            this.feedWidget1.Name = "feedWidget1";
            this.feedWidget1.Size = new System.Drawing.Size(459, 616);
            this.feedWidget1.TabIndex = 0;
            // 
            // sc_right
            // 
            this.sc_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_right.Location = new System.Drawing.Point(0, 0);
            this.sc_right.Name = "sc_right";
            this.sc_right.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_right.Panel1
            // 
            this.sc_right.Panel1.Controls.Add(this.lecturesWidget1);
            // 
            // sc_right.Panel2
            // 
            this.sc_right.Panel2.Controls.Add(this.roomsWidget1);
            this.sc_right.Size = new System.Drawing.Size(914, 616);
            this.sc_right.SplitterDistance = 304;
            this.sc_right.TabIndex = 0;
            // 
            // lecturesWidget1
            // 
            this.lecturesWidget1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lecturesWidget1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.lecturesWidget1.BorderRadius = 50;
            this.lecturesWidget1.BorderWidth = 2;
            this.lecturesWidget1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lecturesWidget1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lecturesWidget1.IsHighlighted = false;
            this.lecturesWidget1.Location = new System.Drawing.Point(0, 0);
            this.lecturesWidget1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lecturesWidget1.Name = "lecturesWidget1";
            this.lecturesWidget1.Rooms = ((System.Collections.Generic.List<string>)(resources.GetObject("lecturesWidget1.Rooms")));
            this.lecturesWidget1.RowHeight = 45;
            this.lecturesWidget1.Size = new System.Drawing.Size(914, 304);
            this.lecturesWidget1.TabIndex = 0;
            this.lecturesWidget1.TimelineHeight = 30;
            this.lecturesWidget1.TimelineStart = 8;
            this.lecturesWidget1.TimelineStop = 18;
            this.lecturesWidget1.WidgetName = "Lektionssalar";
            // 
            // roomsWidget1
            // 
            this.roomsWidget1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.roomsWidget1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.roomsWidget1.BorderRadius = 50;
            this.roomsWidget1.BorderWidth = 2;
            this.roomsWidget1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomsWidget1.IsHighlighted = false;
            this.roomsWidget1.Location = new System.Drawing.Point(0, 0);
            this.roomsWidget1.Name = "roomsWidget1";
            this.roomsWidget1.Rooms = ((System.Collections.Generic.List<string>)(resources.GetObject("roomsWidget1.Rooms")));
            this.roomsWidget1.RowHeight = 45;
            this.roomsWidget1.Size = new System.Drawing.Size(914, 308);
            this.roomsWidget1.TabIndex = 0;
            this.roomsWidget1.TimelineHeight = 30;
            this.roomsWidget1.TimelineStart = 8;
            this.roomsWidget1.TimelineStop = 18;
            this.roomsWidget1.WidgetName = "";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 774);
            this.Controls.Add(this.sc_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DashboardForm_KeyDown);
            this.sc_main.Panel1.ResumeLayout(false);
            this.sc_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_main)).EndInit();
            this.sc_main.ResumeLayout(false);
            this.sc_top.Panel1.ResumeLayout(false);
            this.sc_top.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_top)).EndInit();
            this.sc_top.ResumeLayout(false);
            this.sc_top_left.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_top_left)).EndInit();
            this.sc_top_left.ResumeLayout(false);
            this.sc_top_right.Panel1.ResumeLayout(false);
            this.sc_top_right.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_top_right)).EndInit();
            this.sc_top_right.ResumeLayout(false);
            this.sc_bottom.Panel1.ResumeLayout(false);
            this.sc_bottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_bottom)).EndInit();
            this.sc_bottom.ResumeLayout(false);
            this.sc_right.Panel1.ResumeLayout(false);
            this.sc_right.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_right)).EndInit();
            this.sc_right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer sc_main;
        private SplitContainer sc_top;
        private SplitContainer sc_top_left;
        private SplitContainer sc_top_right;
        private SplitContainer sc_bottom;
        private SplitContainer sc_right;
        private View.ClockWidget clockWidget1;
        private WeatherWidghet weatherWidghet1;
        private TraficWidget traficWidget1;
        private FeedWidget feedWidget1;
        private LecturesWidget lecturesWidget1;
        private Model.RoomsWidget roomsWidget1;
    }
}