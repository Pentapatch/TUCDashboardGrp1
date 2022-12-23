using TUCDashboardGrp1.Controller;
using TUCDashboardGrp1.Model;

namespace TUCDashboardGrp1
{
    public partial class TraficWidget : Widget
    {

        public int NumberOfTrips { get; set; } = 4;

        public TraficWidget()
        {
            InitializeComponent();

            // Subscribe to GlobalTimer event
            GlobalTimer.Instance!.Tick60Seconds += GlobalTimer_Tick60Seconds;
        }

        private void GlobalTimer_Tick60Seconds(object? sender, EventArgs e)
        {
            // Update on each ^ Trigger
            UpdateTrafficAsync();
        }

        private void TraficWidget_Load(object sender, EventArgs e)
        {
            // Asynchronously load the traffic
            UpdateTrafficAsync();
        }

        private async void UpdateTrafficAsync()
        {
            label_timetable_rese.Text = string.Empty;
            label_timetable_skagge.Text = string.Empty;
            var trafficinfo = await TrafficProcessor.LoadTraffic();

            // Early exit if the ApiHelper is not initialized
            // This is useful so that the Designer won't throw exceptions
            // if (!ApiHelper.IsInitialized) return;

            int reseCount = 0;
            int skaggeCount = 0;
            foreach (var departure in trafficinfo.Departure)
            {
                label_timetable_rese.Text = string.Empty;
                label_timetable_skagge.Text = string.Empty;
                TrafficResultModel? trafficinfo;
                try
                {
                    trafficinfo = await TrafficProcessor.LoadTraffic();
                }
                catch (Exception)
                {
                    label_dir_rese.Text = "Kunde inte ladda busstider";
                    return;
                    
                }

                label_dir_skagge.Visible = true;
                label_dir_rese.Text = "Mot Resecentrum";


                int reseCount = 0;
                int skaggeCount = 0;
                foreach (var departure in trafficinfo.Departure)
                {
                    if (++reseCount <= NumberOfTrips)
                        label_timetable_rese.Text += departure.Time.ToShortTimeString() + "\n";
                }
                else
                {
                    if (++skaggeCount <= NumberOfTrips)
                        label_timetable_skagge.Text += departure.Time.ToShortTimeString() + "\n";
                }
            }

            if (label_timetable_rese.Text.Length != 0) label_timetable_rese.Text = label_timetable_rese.Text[0..^1];
            if (label_timetable_skagge.Text.Length != 0) label_timetable_skagge.Text = label_timetable_skagge.Text[0..^1];
        }
    }
}
