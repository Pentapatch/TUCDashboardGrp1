namespace TUCDashboardGrp1
{
    partial class WeatherWidget
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
            this.label_current_weather = new System.Windows.Forms.Label();
            this.current_weather_symbol = new System.Windows.Forms.PictureBox();
            this.label_forecast = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.current_weather_symbol)).BeginInit();
            this.SuspendLayout();
            // 
            // label_current_weather
            // 
            this.label_current_weather.AutoSize = true;
            this.label_current_weather.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_current_weather.Location = new System.Drawing.Point(151, 252);
            this.label_current_weather.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_current_weather.Name = "label_current_weather";
            this.label_current_weather.Size = new System.Drawing.Size(217, 37);
            this.label_current_weather.TabIndex = 2;
            this.label_current_weather.Text = "Laddar prognos..";
            // 
            // current_weather_symbol
            // 
            this.current_weather_symbol.ImageLocation = "";
            this.current_weather_symbol.Location = new System.Drawing.Point(151, 140);
            this.current_weather_symbol.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.current_weather_symbol.Name = "current_weather_symbol";
            this.current_weather_symbol.Size = new System.Drawing.Size(160, 98);
            this.current_weather_symbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.current_weather_symbol.TabIndex = 3;
            this.current_weather_symbol.TabStop = false;
            // 
            // label_forecast
            // 
            this.label_forecast.AutoSize = true;
            this.label_forecast.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_forecast.Location = new System.Drawing.Point(151, 368);
            this.label_forecast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_forecast.Name = "label_forecast";
            this.label_forecast.Size = new System.Drawing.Size(0, 21);
            this.label_forecast.TabIndex = 4;
            // 
            // WeatherWidget
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label_forecast);
            this.Controls.Add(this.current_weather_symbol);
            this.Controls.Add(this.label_current_weather);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "WeatherWidget";
            this.Size = new System.Drawing.Size(1048, 663);
            this.Load += new System.EventHandler(this.WeatherWidghet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.current_weather_symbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label_current_weather;
        private PictureBox current_weather_symbol;
        private Label label_forecast;
    }
}
