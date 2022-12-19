using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUCDashboardGrp1.Controller
{
    public class WeatherProcessor
    {

        /*
         * This class gets data from SMHI with help from the ApiHelper class.
         * When data is returned it uses WeatherResultModel to store the data.
         * A (string, int) tuple is returned, where Item1 is the string presented in the weather widget, 
           and Item2 is the number of the weather symbol.
        
        If you want to display any other type of data, you simply change the index of Paramaters[]. Find the different indexes below:
        0 = spp,      Percent of precipitation in frozen form.Unit: %. 
        1 = pcat,     Precipitation category.                 Unit: integer values from 0-6.
        2 = pmin,     Minimum precipitation intensity.        Unit: mm/h.
        3 = pmean,    Mean precipitation intensity.           Unit: mm/h.
        4 = pmax,     Maximum precipitation intensity.        Unit: mm/h.
        5 = pmedian,  Median precipitation intensity.         Unit: mm/h.
        6 = tcc_mean, Mean value of total cloud cover.        Unit: Octas.
        7 = lcc_mean, Mean value of low level cloud cover.    Unit: Octas.
        8 = mcc_mean, Mean value of medium level cloud cover. Unit: Octas.
        9 = hcc_mean, Mean value of high level cloud cover.   Unit: Octas.
        10 = t,       Air temperature.                        Unit: °C.
        11 = msl,     Air pressure.                           Unit: hPa.
        12 = vis,     Horizontal visibility.                  Unit: km.
        13 = wd,      Wind direction.                         Unit: degree.
        14 = ws,      Wind speed.                             Unit: m/s.
        15 = r,       Relative humidity.                      Unit: %.
        16 = tstm,    Thunder probability.                    Unit: %.
        17 = gust,    Wind gust speed.                        Unit: m/s.
        18 = Wsymb2,  Weather symbol.                         Unit: Integer 1-27 (number of the symbol)

        */

        public static async Task<(string, int)> LoadWeather() 
        {
            string url = "https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/15.62157/lat/58.41086/data.json";
            
            // On the string below you can experiment with changing longitude and latitude in the link if you want to try other cities.
            //string url = "https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/17.141273/lat/60.674880/data.json";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if(response.IsSuccessStatusCode)
                {
                    WeatherResultModel weather = await response.Content.ReadAsAsync<WeatherResultModel>();
                    return ($"Temperature: {weather.TimeSeries[0].Parameters[10].Values[0]}°C \n" +
                        $"Precipitation: {weather.TimeSeries[0].Parameters[2].Values[0]} mm/h", 
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
