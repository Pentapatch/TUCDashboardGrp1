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

namespace TUCDashboardGrp1
{
    /*
        Få vädersymbolerna att funka i picturebox1
        Förklara och ge instruktioner för framtida förändringar
        Kommentera kod
        Namnge och berätta vad filerna gör
     */

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
            pictureBox1.ImageLocation = @"..\resources\WeatherSymbols\1.png"; // Doesnt work, fix it!!

        }
        public static string SetWeatherSymbol(int index) 
        {
            return index switch
            {
                1 => "../resources/WeatherSymbols/1.png",
                2 => "../resources/WeatherSymbols/2.png",
                3 => "../resources/WeatherSymbols/3.png",
                4 => "../resources/WeatherSymbols/4.png",
                5 => "../resources/WeatherSymbols/5.png",
                6 => "../resources/WeatherSymbols/6.png",
                7 => "../resources/WeatherSymbols/7.png",
                8 => "../resources/WeatherSymbols/1.png",
                9 => "../resources/WeatherSymbols/1.png",
                10 => "../resources/WeatherSymbols/1.png",
                11 => "../resources/WeatherSymbols/1.png",
                12 => "../resources/WeatherSymbols/1.png",
                13 => "../resources/WeatherSymbols/1.png",
                14 => "../resources/WeatherSymbols/1.png",
                15 => "../resources/WeatherSymbols/1.png",
                16 => "../resources/WeatherSymbols/1.png",
                17=> "../resources/WeatherSymbols/1.png",
                18 => "../resources/WeatherSymbols/1.png",
                19 => "../resources/WeatherSymbols/1.png",
                20 => "../resources/WeatherSymbols/1.png",
                21 => "../resources/WeatherSymbols/1.png",
                22 => "../resources/WeatherSymbols/1.png",
                23 => "../resources/WeatherSymbols/1.png",
                24 => "../resources/WeatherSymbols/1.png",
                25 => "../resources/WeatherSymbols/25.png",
                26 => "../resources/WeatherSymbols/26.png",
                27 => "../resources/WeatherSymbols/27.png",

            };
        }
    }
}
