using TUCDashboardGrp1.Controller;
using TUCDashboardGrp1.Model;

namespace TUCDashboardGrp1.View
{
    public partial class SettingsPanel : UserControl
    {
        public SettingsPanel()
        {
            InitializeComponent();
            SetOpeningHours();
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

        private void btn_save_openedHour_Click(object sender, EventArgs e) => SaveOpeningHours();

        private void SaveOpeningHours()
        {
            string openingTime = dtpicker_opening.Value.ToShortTimeString();
            string closingTime = dtpicker_closing.Value.ToShortTimeString();

            // Ask the user to confirm the changed opening hours.
            if (MessageBox.Show($"Vänligen bekräfta byte av öppettider {openingTime} - {closingTime}.",
                   DashboardForm.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            LocalStorage.Instance.Settings.OpeningHour = new TimeOnly(dtpicker_opening.Value.Hour, dtpicker_opening.Value.Minute);
            LocalStorage.Instance.Settings.ClosingHour = new TimeOnly(dtpicker_closing.Value.Hour, dtpicker_closing.Value.Minute);
            LocalStorage.Instance.SaveSettings();

            GlobalTimer.Instance.Refresh();
        }

        private void SetOpeningHours()
        {
            dtpicker_opening.Text = LocalStorage.Instance.Settings.OpeningHour == null ? "00:00" : LocalStorage.Instance.Settings.XMLOpeningHour;
            dtpicker_closing.Text = LocalStorage.Instance.Settings.ClosingHour == null ? "00:00" : LocalStorage.Instance.Settings.XMLClosingHour;
        }

    }
}
