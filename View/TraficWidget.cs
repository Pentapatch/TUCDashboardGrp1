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
        }

        private void TraficWidget_Load(object sender, EventArgs e)
        {
            UpdateTrafficAsync();
        }

        private async void UpdateTrafficAsync()
        {
            if (ApiHelper.IsInitialized)
            {
                label_timetable_rese.Text = string.Empty;
                label_timetable_skagge.Text = string.Empty;
                var trafficinfo = await TrafficProcessor.LoadTraffic();
                int reseCount = 0;
                int skaggeCount = 0;
                foreach (var departure in trafficinfo.Departure)
                {
                    if (departure.Direction.Contains("Räknestickan"))
                    {
                        if (++reseCount <= NumberOfTrips)
                        {
                            label_timetable_rese.Text += departure.Time.ToShortTimeString() + "\n";
                        }
                    }
                    else
                    {
                        if (++skaggeCount <= NumberOfTrips)
                        {
                            label_timetable_skagge.Text += departure.Time.ToShortTimeString() + "\n";
                        }
                    }
                }

                if (label_timetable_rese.Text.Length != 0) label_timetable_rese.Text = label_timetable_rese.Text[0..^1];

                if (label_timetable_skagge.Text.Length != 0) label_timetable_skagge.Text = label_timetable_skagge.Text[0..^1];
            }
        }
    }
}
