using TUCDashboardGrp1.Controller;
using TUCDashboardGrp1.Properties;
using TUCDashboardGrp1.Model;

namespace TUCDashboardGrp1
{
    public partial class WeatherWidghet : Widget
    {
        public WeatherWidghet()
        {
            InitializeComponent();
            Resize += WeatherWidget_SetLayout;
            GlobalTimer.Instance!.Tick60Minutes += GlobalTimer_Tick60Minutes;
        }

        private void GlobalTimer_Tick60Minutes(object? sender, EventArgs e)
        {
            // Update the forecast every even 60 minutes
            UpdateForecastAsync();
        }

        private void WeatherWidget_SetLayout(object? sender, EventArgs e)
        {
            // Setup:
            int offsetFromCenter = 3;

            // Center according to width
            label2.Left = (Width / 2) - (label2.Width / 2);
            pictureBox1.Left = (Width / 2) - (pictureBox1.Width / 2);

            // Center according to height
            int totalHeight = label2.Height + pictureBox1.Height;
            pictureBox1.Top = (Height / 2) - (totalHeight / 2) - offsetFromCenter;
            label2.Top = pictureBox1.Bottom + offsetFromCenter;
        }

        private void WeatherWidghet_Load(object sender, EventArgs e)
        {
            // Asynchronously load the forecast
            UpdateForecastAsync();
        }

        private async void UpdateForecastAsync()
        {
            if (ApiHelper.IsInitialized)
            {
                var weatherInfo = await WeatherProcessor.LoadWeather();
                label2.Text = weatherInfo.Item1;
                pictureBox1.Image = GetWeatherSymbol(weatherInfo.Item2);
                WeatherWidget_SetLayout(this, EventArgs.Empty);
            }
        }

        private static Image GetWeatherSymbol(int index) => index switch
        {
            1 => Resources._1,
            2 => Resources._2,
            3 => Resources._3,
            4 => Resources._4,
            5 => Resources._5,
            6 => Resources._6,
            7 => Resources._7,
            8 => Resources._8,
            9 => Resources._9,
            10 => Resources._10,
            11 => Resources._11,
            12 => Resources._12,
            13 => Resources._13,
            14 => Resources._14,
            15 => Resources._15,
            16 => Resources._16,
            17 => Resources._17,
            18 => Resources._18,
            19 => Resources._19,
            20 => Resources._20,
            21 => Resources._21,
            22 => Resources._22,
            23 => Resources._23,
            24 => Resources._24,
            25 => Resources._25,
            26 => Resources._26,
            _ => Resources._27,
        };
    }
}
