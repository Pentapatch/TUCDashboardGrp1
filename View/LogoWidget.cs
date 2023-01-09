using TUCDashboardGrp1.Controller;
using TUCDashboardGrp1.Model;

namespace TUCDashboardGrp1.View
{
    public partial class LogoWidget : Widget
    {

        public string ImagePath
        {
            get => pbx_logo.ImageLocation;
            set => pbx_logo.ImageLocation = value;
        }

        public int ImagePadding { get; set; } = 20;
       


        public LogoWidget()
        {
            InitializeComponent();
            RefreshWidget();
            Resize += LogoWidget_Resize;
            GlobalTimer.Instance.RefreshWidget += Instance_RefreshSettings;
        }

        private void Instance_RefreshSettings(object? sender, EventArgs e) => RefreshWidget();

        private void RefreshWidget() => ImagePath = LocalStorage.Instance.Settings.LogotypePath;

        private void LogoWidget_Resize(object? sender, EventArgs e)
        {
            // Adjust the location of the picturebox
            pbx_logo.Left = ImagePadding;
            pbx_logo.Top = ImagePadding;
            pbx_logo.Width = Width - ImagePadding * 2;
            pbx_logo.Height = Height - ImagePadding * 2;
        }

    }
}