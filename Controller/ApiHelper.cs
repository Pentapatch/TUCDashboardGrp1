using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUCDashboardGrp1.Controller
{
    public class ApiHelper
    {
        // All call to API's will go through this so that unneccessary port won't be opened.
        public static HttpClient ApiClient { get; set; } = new HttpClient();

    }
}
