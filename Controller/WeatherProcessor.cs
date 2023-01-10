using TUCDashboardGrp1.Model;

namespace TUCDashboardGrp1.Controller

{
    public class WeatherProcessor
    {

        /*
         * This class gets data from SMHI with help from the ApiHelper class.
         * When data is returned it uses WeatherResultModel to store the data.
         * A (string, int) tuple is returned, where Item1 is the string presented in the weather widget, 
           and Item2 is the number of the weather symbol.
         * this link: https://www.smhi.se/data/meteorologi/ladda-ner-meteorologiska-observationer#param=airtemperatureInstant,stations=core
         * is used for getting the Longitude and Latitude Coordinates to which works with the API.
        
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

        public static async Task<WeatherResultModel> LoadWeather()
        {
            string longitude = LocalStorage.Instance.Settings.Longitude == null ? "15.62157" : LocalStorage.Instance.Settings.Longitude;
            string latitude = LocalStorage.Instance.Settings.Latitude == null ? "58.41086" : LocalStorage.Instance.Settings.Latitude;
            string address = $"https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/{longitude}/lat/{latitude}/data.json";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(address))
            {
                // Get and return the result asynchronously
                if (response.IsSuccessStatusCode) return await response.Content.ReadAsAsync<WeatherResultModel>();

                // Unsuccessful: Throw error
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
