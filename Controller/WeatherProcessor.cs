using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUCDashboardGrp1.Controller
{
    public class WeatherProcessor
    {
        public static async Task<(string, int)> LoadWeather() 
        {

            string url = "https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/16.158/lat/58.5812/data.json";
            
            // Here you can experiment with changing longitude and latitude in the link if you want to try other cities.
            //string url = "https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/17.141273/lat/60.674880/data.json";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if(response.IsSuccessStatusCode)
                {
                    WeatherResultModel weather = await response.Content.ReadAsAsync<WeatherResultModel>();
                    return ($"Temperatur: {weather.TimeSeries[0].Parameters[10].Values[0]}°C \n" +
                        $"Vädersymbol: {weather.TimeSeries[0].Parameters[18].Values[0]}", 
                        Convert.ToInt32(weather.TimeSeries[0].Parameters[18].Values[0]));
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
    }
}
