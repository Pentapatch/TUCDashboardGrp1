namespace TUCDashboardGrp1.Controller
{
    public class TrafficResultModel
    {
        public TrafficParameters[] Departure { get; set; } = Array.Empty<TrafficParameters>();

    }


    public class TrafficParameters
    {
        public DateTime Time { get; set; } = new();

        public string Direction { get; set; } = string.Empty;
    }
}
