namespace TUCDashboardGrp1.Controller
{
    public class BookingClass
    {
        public Guid ID { get; set; }                           // Database Use "only" .... 
        public string Room { get; set; } = string.Empty;       // G1, A8
        public string Name { get; set; } = string.Empty;       // Bokee: Dan S. Syne22
        public DateOnly? Date { get; set; } = null;            // 2022-12-14
        public TimeOnly? StartTime { get; set; } = null;       // 10.00
        public TimeOnly? EndTime { get; set; } = null;         // 12.00
        public string ClassType { get; set; } = string.Empty;  // Syne22 

    }

}