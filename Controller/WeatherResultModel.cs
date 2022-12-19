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
        public WeatherParameters[] TimeSeries { get; set; } = Array.Empty<WeatherParameters>();
    }
    
    public class WeatherParameters
    {
        public WeatherValues[] Parameters { get; set; } = Array.Empty<WeatherValues>();
    }

    public class WeatherValues
    {
        public string[] Values { get; set; } = Array.Empty<string>();
    }
}
