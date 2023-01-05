namespace TUCDashboardGrp1.Controller
{
    public class TrainResultModel
    {
        public TrainParameters[] Departure { get; set; } = Array.Empty<TrainParameters>();
    }

    public class TrainParameters
    {
        public DateTime Time { get; set; } = new();

        public string Direction { get; set; } = string.Empty;
    }
}
