namespace TUCDashboardGrp1.Controller
{
    public class TrafficProcessor
    {
        public static async Task<TrafficResultModel> LoadTraffic()
        {
            string url = "https://api.resrobot.se/v2.1/departureBoard?id=740062066&format=json&accessId=8b01f58f-bafd-42d5-820c-438b6a987bfa";


            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    TrafficResultModel traffic = await response.Content.ReadAsAsync<TrafficResultModel>();
                    return traffic;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
    }
}
