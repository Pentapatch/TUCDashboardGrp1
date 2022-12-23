using TUCDashboardGrp1.Controller;
using TUCDashboardGrp1.Properties;
using TUCDashboardGrp1.Model;

namespace TUCDashboardGrp1
{
    public partial class WeatherWidghet : Widget
    {

        // ############
        // ## FIELDS ##
        // ############

        #region Fields

        private bool forecastEnabled = true;

        #endregion

        // ###############
        // ## PROPERIES ##
        // ###############

        #region Properties

        public bool ForecastEnabled
        {
            get => forecastEnabled;
            set
            {
                forecastEnabled = value;
                UpdateForecastAsync();
            }
        }

        #endregion

        // ##################
        // ## CONSTRUCTORS ##
        // ##################

        #region Constructors

        public WeatherWidghet()
        {
            InitializeComponent();
            Resize += WeatherWidget_Resize;
            GlobalTimer.Instance!.Tick60Minutes += GlobalTimer_Tick60Minutes;
        }

        #endregion

        // #####################
        // ## PRIVATE METHODS ##
        // #####################

        #region Private methods

        private void GlobalTimer_Tick60Minutes(object? sender, EventArgs e)
        {
            // Update the forecast every even 60 minutes
            UpdateForecastAsync();
        }

        private void WeatherWidget_Resize(object? sender, EventArgs e) => SetLayout();

        private void SetLayout()
        {
            // Setup:
            int offsetFromCenter = 3;
            int forecastOffset = label_forecast.Text == string.Empty ? 0 : 10;

            // Center according to width
            label_current_weather.Left = (Width / 2) - (label_current_weather.Width / 2);
            current_weather_symbol.Left = (Width / 2) - (current_weather_symbol.Width / 2);
            label_forecast.Left = (Width / 2) - (label_forecast.Width / 2);

            // Center according to height
            int totalHeight = label_current_weather.Height + current_weather_symbol.Height + label_forecast.Height + forecastOffset;
            current_weather_symbol.Top = (Height / 2) - (totalHeight / 2) - offsetFromCenter;
            label_current_weather.Top = current_weather_symbol.Bottom + offsetFromCenter;
            label_forecast.Top = label_current_weather.Bottom + offsetFromCenter + forecastOffset;
        }

        private void WeatherWidghet_Load(object sender, EventArgs e)
        {
            // Asynchronously load the forecast
            UpdateForecastAsync();
        }

        private async void UpdateForecastAsync()
        {
            // Early exit if the ApiHelper is not initialized
            // This is useful so that the Designer won't throw exceptions
            if (!ApiHelper.IsInitialized) return;
            WeatherResultModel? weatherInfo;

            try
            {
                weatherInfo = await WeatherProcessor.LoadWeather();
            }
            catch (Exception)
            {
                label_current_weather.Text = "Kunde inte ladda väder";
                return;


            }
   

            label_current_weather.Text = $"Temperatur: {GetValueAsInt(weatherInfo, "t")}°C";
            current_weather_symbol.Image = GetForecastImage(weatherInfo);
            label_forecast.Text = ForecastEnabled ? CreateForecast(weatherInfo) : string.Empty;
            SetLayout();

        }

        private static string CreateForecast(WeatherResultModel weather) =>
            $"{WindToSentence(GetValueAsDouble(weather, "ws"))}" +
            $"{PercipitationToSentence(GetValueAsDouble(weather, "pmean"))}" +
            $"{ThunderToSentence(GetValueAsInt(weather, "tstm"))}";

        private static Image GetForecastImage(WeatherResultModel weather) =>
           GetWeatherSymbol(GetValueAsInt(weather, "Wsymb2"));

        private static double GetValueAsDouble(WeatherResultModel weather, string name) =>
            Convert.ToDouble(GetValueAsString(weather, name).Replace(".", ","));

        private static int GetValueAsInt(WeatherResultModel weather, string name) =>
            (int)Math.Round(GetValueAsDouble(weather, name), MidpointRounding.AwayFromZero);

        private static string GetValueAsString(WeatherResultModel weatherInfo, string name)
        {
            foreach (WeatherValues param in weatherInfo.TimeSeries[0].Parameters)
                if (param.Name.ToLower() == name.ToLower()) return param.Values[0];

            return string.Empty;
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

        private static string ThunderToSentence(int probability) => probability switch
        {
            >= 10 and < 30 => "\nLiten risk för åska",
            >= 30 and < 80 => "\nRisk för åska",
            >= 80 => "\nÖverhängande risk för åska",
            _ => string.Empty
        };

        private static string WindToSentence(double speed) => speed switch
        {
            >= 0 and < 0.2 => "Vindstilla",
            >= 0.2 and < 3.5 => "Svag vind",
            >= 3.5 and < 8 => "Måttlig vind",
            >= 8 and < 14 => "Frisk vind",
            >= 14 and < 21 => "Hård vind",
            >= 21 and < 24.5 => "Mycket hård vind",
            >= 24.5 and < 28.5 => "Stormvindar",
            >= 28.5 and < 32.6 => "Svår storm",
            _ => "\nOrkanvarning"
        };

        private static string PercipitationToSentence(double value) => value switch
        {
            >= 0.1 and < 0.5 => "\nLätt nederbörd",
            >= 0.5 and < 4 => "\nMåttligt nederbörd",
            >= 4 => "\nKraftig nederbörd",
            _ => string.Empty
        };

    }
    #endregion
}
