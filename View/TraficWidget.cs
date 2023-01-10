using System.Windows.Forms.VisualStyles;
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
            GlobalTimer.Instance.RefreshSettings += Instance_RefreshSettings;
        }

        private void Instance_RefreshSettings(object? sender, EventArgs e) => SetLayout();

        private void GlobalTimer_Tick60Seconds(object? sender, EventArgs e)
        {
            // Update on each ^ Trigger
            UpdateTrafficAsync();
            UpdateTrainAsync();
            SetLayout();
        }

        private void TraficWidget_Resize(object? sender, EventArgs e) => SetLayout();

        private int GetTallestLabel() => Math.Max(label_timetable_norrk.Height, Math.Max(label_timetable_rese.Height, label_timetable_skagge.Height));

        private void SetLayout()
        {
            // Setting Fonts
            lbl_header_busses.Font = Settings.CreateFont(GetRelativeFontSize(14), true);
            lbl_header_trains.Font = Settings.CreateFont(GetRelativeFontSize(14), true);

            label_dir_rese.Font = Settings.CreateFont(GetRelativeFontSize(2), true);
            label_dir_skagge.Font = Settings.CreateFont(GetRelativeFontSize(2), true);
            label_dir_norrk.Font = Settings.CreateFont(GetRelativeFontSize(2), true);

            // Setting Variables for Padding and Offset
            int verticalOffset = 10;
            int padding = Width / 8;

            int totalHeight = lbl_header_busses.Height + label_dir_norrk.Height + GetTallestLabel() + (verticalOffset * 2);
            int top = (Height - totalHeight) / 2;

            // Align all elements
            lbl_header_busses.Top = top;
            lbl_header_trains.Top = top;

            lbl_header_busses.Left = Width / 4;
            lbl_header_trains.Left = (int)(Width * 0.75d) - padding; //Width / 2;

            label_dir_rese.Top = lbl_header_busses.Bottom + verticalOffset;
            label_dir_skagge.Top = lbl_header_busses.Bottom + verticalOffset;
            label_dir_norrk.Top = lbl_header_trains.Bottom + verticalOffset;

            label_timetable_rese.Top = label_dir_rese.Bottom + verticalOffset;
            label_timetable_skagge.Top = label_dir_skagge.Bottom + verticalOffset;
            label_timetable_norrk.Top = label_dir_norrk.Bottom + verticalOffset;

            label_dir_rese.Left = (Width / 4) - padding;
            label_dir_skagge.Left = (Width / 2) - padding;
            label_dir_norrk.Left = lbl_header_trains.Left;

            int width = Width / 4;
            label_dir_rese.Width = width;
            label_dir_skagge.Width = width;
            label_dir_norrk.Width = width;

            label_timetable_rese.Left = label_dir_rese.Left;
            label_timetable_skagge.Left = label_dir_skagge.Left;
            label_timetable_norrk.Left = label_dir_norrk.Left;
        }

        private void TraficWidget_Load(object sender, EventArgs e)
        {
            // Asynchronously load the traffic
            UpdateTrafficAsync();
            UpdateTrainAsync();
        }

        private async void UpdateTrainAsync()
        {
            label_timetable_norrk.Text = string.Empty;
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
                if (departure.Direction.Contains("Norrköping Centralstation"))
                {
                    if (++norrCount <= NumberOfTrains)
                        label_timetable_norrk.Text += departure.Time.ToShortTimeString() + "\n";
                }
            }

            if (label_timetable_norrk.Text.Length != 0) label_timetable_norrk.Text = label_timetable_norrk.Text[0..^1];

            SetLayout();
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

            SetLayout();
        }
    }
}
