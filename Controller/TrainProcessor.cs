namespace TUCDashboardGrp1.Controller
{
    public class TrainProcessor
    {
        public static async Task<TrainResultModel> LoadTrain()
        {
            string url = "https://api.resrobot.se/v2.1/departureBoard?id=740098005&format=json&accessId=8b01f58f-bafd-42d5-820c-438b6a987bfa";



            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    TrainResultModel train = await response.Content.ReadAsAsync<TrainResultModel>();
                    return train;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }

        }
    }
}
