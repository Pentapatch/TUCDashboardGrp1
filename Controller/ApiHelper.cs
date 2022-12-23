using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TUCDashboardGrp1.Controller
{
    public class ApiHelper
    {
        private static HttpClient? apiClient = null;
        /// <summary>
        /// All call to API's will go through this so that unneccessary ports won't be opened. 
        /// </summary>
        public static HttpClient ApiClient
        {
            get
            {
                // This property will create ONE instance of this class,
                // if it isn't set already
                if(apiClient == null)
                {
                    apiClient = new();
                    ApiClient.DefaultRequestHeaders.Accept.Clear();
                    ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //IsInitialized = true;
                }
                return apiClient;
            }
        }

        //public static bool IsInitialized { get; private set; } = false;
    }
}
