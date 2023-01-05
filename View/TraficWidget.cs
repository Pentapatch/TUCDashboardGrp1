using TUCDashboardGrp1.Controller;
using TUCDashboardGrp1.Model;

namespace TUCDashboardGrp1
{
    public partial class TraficWidget : Widget
    {

        public int NumberOfTrips { get; set; } = 4;
        public int NumberOfTrains { get; set; } = 2;

        public TraficWidget()
        {
            InitializeComponent();
            Resize += TraficWidget_Resize;
            // Subscribe to GlobalTimer event
            GlobalTimer.Instance!.Tick60Seconds += GlobalTimer_Tick60Seconds;
        }

        private void GlobalTimer_Tick60Seconds(object? sender, EventArgs e)
        {
            // Update on each ^ Trigger
            UpdateTrafficAsync();
            UpdateTrainAsync();
        }

        private void TraficWidget_Resize(object? sender, EventArgs e) => SetLayout();

        private void SetLayout()
        {
            int offsetLabel = 20;

            // Center horizontally
            label_dir_rese.Left = Left + offsetLabel;
            label_timetable_rese.Left = label_dir_rese.Left;

            label_dir_skagge.Left = label_dir_rese.Right + offsetLabel;
            label_timetable_skagge.Left = label_dir_skagge.Left;

            label_dir_norrk.Left = label_dir_skagge.Right + offsetLabel;
            label_timetable_norrk.Left = label_dir_norrk.Left;


            // Center vertically
            
            label_dir_rese.Top = (Height / 2) - offsetLabel;
            label_timetable_rese.Top = label_dir_rese.Bottom + offsetLabel;
            
            label_dir_skagge.Top = label_dir_rese.Top;
            label_timetable_skagge.Top = label_dir_skagge.Bottom + offsetLabel;
            
            label_dir_norrk.Top = label_dir_rese.Top;
            label_timetable_norrk.Top = label_dir_norrk.Bottom + offsetLabel;
            
        }

        private void TraficWidget_Load(object sender, EventArgs e)
        {
            // Asynchronously load the traffic
            UpdateTrafficAsync();
            UpdateTrainAsync();
        }

        
        private async void UpdateTrainAsync()
        {
            label_timetable_norrk.Text= string.Empty;
            TrainResultModel? traininfo;
            try
            {
                traininfo = await TrainProcessor.LoadTrain();
            }
            catch (Exception)
            {
                return;
            }

            label_dir_norrk.Visible = true;

            int norrCount = 0;
            foreach (var departure in traininfo.Departure)
            {
                if(departure.Direction.Contains("Norrköping Centralstation"))
                {
                    if (++norrCount <= NumberOfTrains)
                        label_timetable_norrk.Text += departure.Time.ToShortTimeString() + "\n";
                }
            }

            if (label_timetable_norrk.Text.Length != 0) label_timetable_norrk.Text = label_timetable_norrk.Text[0..^1];

        }
        
        private async void UpdateTrafficAsync()
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
                if (departure.Direction.Contains("Räknestickan"))
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
