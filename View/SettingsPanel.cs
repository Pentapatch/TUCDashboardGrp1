using TUCDashboardGrp1.Controller;
using TUCDashboardGrp1.Model;

namespace TUCDashboardGrp1.View
{
    public partial class SettingsPanel : UserControl
    {
        public SettingsPanel()
        {

            InitializeComponent();
            RefreshPanel();
            GlobalTimer.Instance.RefreshWidget += Instance_RefreshWidget;
        }

        private void Instance_RefreshWidget(object? sender, EventArgs e) => RefreshPanel();

        private void RefreshPanel()
        {
            // Change the textlabel to reflect the name of thenew file used.
            lbl_currentDataFile.Text = new FileInfo(LocalStorage.Instance.Settings.DataPath).Name;
        }

        private void btn_dataBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browser = new()
            {
                Filter = "XML Filer | *.xml;",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                InitialDirectory = LocalStorage.Instance.Settings.DataPath,
            };
            browser.ShowDialog(this);

            // Save the current filepath to the Settings.xml for the next loadup of the program
            LocalStorage.Instance.Settings.DataPath = browser.FileName;
            LocalStorage.Instance.SaveSettings();

            // Load all new settings
            LocalStorage.Instance.ReLoad();
        }

        private void btn_edit_rooms_Click(object sender, EventArgs e)
        {
            if (ParentForm is TUCDashboardGrp1.AdminTools admin)
            {
                admin.ChangeTab(3);
                admin.PopulateRoomsList();
            }
          
        }
    }
}
