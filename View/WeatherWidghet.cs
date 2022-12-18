using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUCDashboardGrp1.Controller;
using TUCDashboardGrp1.Properties;

namespace TUCDashboardGrp1
{
    public partial class WeatherWidghet : UserControl
    {
        public WeatherWidghet()
        {
            InitializeComponent();           
        }

        private async void WeatherWidghet_Load(object sender, EventArgs e)
        {
            var weatherInfo = await WeatherProcessor.LoadWeather();
            label2.Text = weatherInfo.Item1;
            pictureBox1.Image = GetWeatherSymbol(weatherInfo.Item2);
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
