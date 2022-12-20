using TUCDashboardGrp1.Model;

namespace TUCDashboardGrp1.View
{
    public partial class ClockWidget : Widget
    {
        public ClockWidget()
        {
            InitializeComponent();

            // Settings
            Resize += SetLayout;
            Refresher_Tick(this, EventArgs.Empty);

        }

        private void SetLayout(object? sender, EventArgs e)
        {
            // Setup:
            int offsetFromCenter = 3;

            // Center according to width
            label_time.Left = (Width / 2) - (label_time.Width / 2);
            label_date.Left = (Width / 2) - (label_date.Width / 2);

            // Center according to height

            int totalHeight = label_time.Height + label_date.Height;
            label_time.Top = (Height / 2) - (totalHeight / 2) - offsetFromCenter;
            label_date.Top = label_time.Bottom + offsetFromCenter;

        }

        private void ClockWidget_Load_1(object sender, EventArgs e) => Refresher.Start();

        private void Refresher_Tick(object sender, EventArgs e)
        {
            var currentTime = DateTime.Now;

            label_time.Text = $"{currentTime.Hour.ToString().PadLeft(2, '0')}:{currentTime.Minute.ToString().PadLeft(2, '0')}";
            label_date.Text = $"{GetDayOfWeek(currentTime.DayOfWeek)} {currentTime.Day}:{(currentTime.Day <= 2 ? "a" : "e")}";
            
            SetLayout(this, EventArgs.Empty);
        }

        private static string GetDayOfWeek(DayOfWeek value) => value switch
        {
            DayOfWeek.Monday => "Måndag",
            DayOfWeek.Tuesday => "Tisdag",
            DayOfWeek.Wednesday => "Onsdag",
            DayOfWeek.Thursday => "Torsdag",
            DayOfWeek.Friday => "Fredag",
            DayOfWeek.Saturday => "Lördag",
            _ => "Söndag",
        };

    }
}
