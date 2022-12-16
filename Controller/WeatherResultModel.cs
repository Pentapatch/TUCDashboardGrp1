using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUCDashboardGrp1.Controller
{
    // Since the SMHI-api return data in multiple layers we need one class to dig through each layer.
    public class WeatherResultModel
    {
        public WeatherModel[] TimeSeries { get; set; }
    }
    
    public class WeatherModel
    {
        public WeatherArray[] Parameters { get; set; }
    }

    public class WeatherArray
    {
        public string[] Values { get; set; }
    }
}
