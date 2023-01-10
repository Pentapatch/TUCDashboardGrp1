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

            string logotypePath = LocalStorage.Instance.Settings.LogotypePath;

            if (logotypePath != "")
                lbl_logotypePath.Text = new FileInfo(logotypePath).Name;
            else
                lbl_logotypePath.Text = "";

            if (logotypePath != "")
                pb_logotypePreview.LoadAsync(logotypePath);
            else
                pb_logotypePreview.Image = null;

            // Update all of the color preview labels
            lbl_backgroundColorPreview.BackColor = LocalStorage.Instance.Settings.BackgroundColor;
            lbl_widgetBackgroundColorPreview.BackColor = LocalStorage.Instance.Settings.WidgetBackgroundColor;
            lbl_accentColorPreview.BackColor = LocalStorage.Instance.Settings.AccentColor;
            lbl_textColorPreview.BackColor = LocalStorage.Instance.Settings.TextColor;
            lbl_baseColorPreview.BackColor = LocalStorage.Instance.Settings.BaseColor;
            lbl_borderColorPreview.BackColor = LocalStorage.Instance.Settings.BorderColor;

            // Update the font preview
            lbl_fontPreview.Text = LocalStorage.Instance.Settings.FontName;
            lbl_fontPreview.Font = Settings.CreateFont(11);

            // Update the slider
            slider_borderRadius.Value = LocalStorage.Instance.Settings.BorderRadius;
            slider_borderWidth.Value = LocalStorage.Instance.Settings.BorderWidth;
        }

        private void btn_dataBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browser = new()
            {
                Filter = "XML Filer | *.xml;",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                InitialDirectory = new FileInfo(LocalStorage.Instance.Settings.DataPath).Directory?.FullName,
            };
            browser.ShowDialog(this);

            // Early exit if no file was selected
            if (browser.FileName == "") return;

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

        private void btn_clearLogotypePath_Click(object sender, EventArgs e)
        {
            // Clear the setting
            LocalStorage.Instance.Settings.LogotypePath = "";

            // Refresh all widgets
            GlobalTimer.Instance.Refresh();
        }

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

        private void btn_browseForLogotypePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog browser = new()
            {
                Filter = "Bildfiler| *.bmp; *.jpg; *.jpeg; *.gif; *.png; | Bitmap (*.bmp) | *.bmp; | Joint Photographic Experts Group (*.jpg, *.jpeg) | *.jpg; *.jpeg; | Graphics Interchange Format (*.gif) | *.gif; | Portable Network Graphics (*.png) | *.png;",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
            };
            browser.ShowDialog(this);

            // Early exit if no file was selected
            if (browser.FileName == "") return;

            // Set the new path
            LocalStorage.Instance.Settings.LogotypePath = browser.FileName;

            // Save the settings
            LocalStorage.Instance.SaveSettings();

            // Refresh all widgets
            GlobalTimer.Instance.Refresh();
            GlobalTimer.Instance.RefreshSettingsOnly();
        }

        public enum ColorTypeEnum
        {
            Background,
            WidgetBackground,
            Base,
            Accent,
            Text,
            Border,
        }

        private Label GetPreviewLabel(ColorTypeEnum type) => type switch
        {
            ColorTypeEnum.Background => lbl_backgroundColorPreview,
            ColorTypeEnum.WidgetBackground => lbl_widgetBackgroundColorPreview,
            ColorTypeEnum.Base => lbl_baseColorPreview,
            ColorTypeEnum.Accent => lbl_accentColorPreview,
            ColorTypeEnum.Border => lbl_borderColorPreview,
            _ => lbl_textColorPreview,
        };

        private static Color? BrowseForColor()
        {
            ColorDialog cd = new();

            if (cd.ShowDialog() == DialogResult.OK) return cd.Color;

            return null;
        }

        private void UpdateColor(ColorTypeEnum type)
        {
            // Browse for the color
            Color? color = BrowseForColor();

            // Early exit if cancelled
            if (color == null) return;

            // Update the preview label
            GetPreviewLabel(type).BackColor = color.Value;

            // Update the local storage property
            switch (type)
            {
                case ColorTypeEnum.Background:
                    LocalStorage.Instance.Settings.BackgroundColor = color.Value;
                    break;
                case ColorTypeEnum.WidgetBackground:
                    LocalStorage.Instance.Settings.WidgetBackgroundColor = color.Value;
                    break;
                case ColorTypeEnum.Base:
                    LocalStorage.Instance.Settings.BaseColor = color.Value;
                    break;
                case ColorTypeEnum.Accent:
                    LocalStorage.Instance.Settings.AccentColor = color.Value;
                    break;
                case ColorTypeEnum.Text:
                    LocalStorage.Instance.Settings.TextColor = color.Value;
                    break;
                case ColorTypeEnum.Border:
                    LocalStorage.Instance.Settings.BorderColor = color.Value;
                    break;
                default:
                    break;
            }

            // Save the settings
            LocalStorage.Instance.SaveSettings();
            
            // Update Widgets
            GlobalTimer.Instance.RefreshSettingsOnly();
        }

        private void btn_browseForBackgroundColor_Click(object sender, EventArgs e) => UpdateColor(ColorTypeEnum.Background);

        private void btn_browseForWidgetBackgroundColor_Click(object sender, EventArgs e) => UpdateColor(ColorTypeEnum.WidgetBackground);

        private void btn_browseForBaseColor_Click(object sender, EventArgs e) => UpdateColor(ColorTypeEnum.Base);

        private void btn_browseForAccentColor_Click(object sender, EventArgs e) => UpdateColor(ColorTypeEnum.Accent);

        private void btn_browseForTextColor_Click(object sender, EventArgs e) => UpdateColor(ColorTypeEnum.Text);

        private void btn_browseForBorderColor_Click(object sender, EventArgs e) => UpdateColor(ColorTypeEnum.Border);

        private void slider_borderRadius_ValueChanged(object sender, EventArgs e)
        {
            LocalStorage.Instance.Settings.BorderRadius = slider_borderRadius.Value;
            LocalStorage.Instance.SaveSettings();
            GlobalTimer.Instance.RefreshSettingsOnly();
        }

        private void slider_borderWidth_ValueChanged(object sender, EventArgs e)
        {
            LocalStorage.Instance.Settings.BorderWidth = slider_borderWidth.Value;
            LocalStorage.Instance.SaveSettings();
            GlobalTimer.Instance.RefreshSettingsOnly();
        }

        private void btn_browseForFont_Click(object sender, EventArgs e)
        {
            //lbl_fontPreview.Font = LocalStorage.Instance.Settings.Font;
            //return;

            FontDialog fd = new();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                lbl_fontPreview.Text = fd.Font.Name;
                lbl_fontPreview.Font = new Font(fd.Font.FontFamily.ToString(), 9, fd.Font.Style);
            }

            // Save the font details
            LocalStorage.Instance.Settings.FontSize = (int)fd.Font.Size;
            LocalStorage.Instance.Settings.FontName = fd.Font.Name;
            LocalStorage.Instance.Settings.FontBold = fd.Font.Style.HasFlag(FontStyle.Bold);
            LocalStorage.Instance.Settings.FontItalic = fd.Font.Style.HasFlag(FontStyle.Italic);
            LocalStorage.Instance.Settings.FontUnderline = fd.Font.Style.HasFlag(FontStyle.Underline);

            // Save settings
            LocalStorage.Instance.SaveSettings();

            // Update all widgets
            GlobalTimer.Instance.RefreshSettingsOnly();
        }
    }
}
