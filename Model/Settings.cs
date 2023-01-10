using System.Xml.Serialization;

namespace TUCDashboardGrp1.Model
{
    public class Settings
    {
        public string DataPath { get; set; } = @$"{Application.UserAppDataPath}\Settings\AppData1.xml";

        public string LogotypePath { get; set; } = "";

        public int BorderRadius { get; set; }

        public int BorderWidth { get; set; }

        public int FontSize { get; set; } = 12;

        public bool FontBold { get; set; } = false;

        public bool FontItalic { get; set; } = false;

        public bool FontUnderline { get; set; } = false;

        public string FontName { get; set; } = "Segoe UI";

        #region XMLIgnore

        [XmlIgnore]
        public TimeOnly? OpeningHour { get; set; }

        [XmlIgnore]
        public Color BackgroundColor { get; set; } = Color.Black;

        [XmlIgnore]
        public Color WidgetBackgroundColor { get; set; } = Color.FromArgb(24, 24, 24);

        [XmlIgnore]
        public Color AccentColor { get; set; } = Color.PaleTurquoise;

        [XmlIgnore]
        public Color BaseColor { get; set; } = Color.Silver;

        [XmlIgnore]
        public Color TextColor { get; set; } = Color.Gray;

        [XmlIgnore]
        public Color BorderColor { get; set; } = Color.White;

        [XmlIgnore]
        public TimeOnly? ClosingHour { get; set; }

        #endregion

        #region XMLElements

        [XmlElement("BackgroundColor")]
        public int XMLBackgroundColor
        {
            get { return BackgroundColor.ToArgb(); }
            set { BackgroundColor = Color.FromArgb(value); }
        }

        [XmlElement("BorderColor")]
        public int XMLBorderColor
        {
            get { return BorderColor.ToArgb(); }
            set { BorderColor = Color.FromArgb(value); }
        }

        [XmlElement("WidgetBackgroundColor")]
        public int XMLWidgetBackgroundColor
        {
            get { return WidgetBackgroundColor.ToArgb(); }
            set { WidgetBackgroundColor = Color.FromArgb(value); }
        }

        [XmlElement("AccentColor")]
        public int XMLAccentColor
        {
            get { return AccentColor.ToArgb(); }
            set { AccentColor = Color.FromArgb(value); }
        }

        [XmlElement("TextColor")]
        public int XMLTextColor
        {
            get { return TextColor.ToArgb(); }
            set { TextColor = Color.FromArgb(value); }
        }

        [XmlElement("BaseColor")]
        public int XMLBaseColor
        {
            get { return BaseColor.ToArgb(); }
            set { BaseColor = Color.FromArgb(value); }
        }

        [XmlElement("XMLOpeningHour")]
        public string XMLOpeningHour
        {
            get
            {
                if (OpeningHour == null) return "";

                TimeOnly time = (TimeOnly)OpeningHour;
                return time.ToShortTimeString();
            }
            set
            {
                if (value != "") OpeningHour = TimeOnly.FromDateTime(Convert.ToDateTime(value));
            }
        }

        [XmlElement("XMLClosingHour")]
        public string XMLClosingHour
        {
            get
            {
                if (ClosingHour == null) return "";

                TimeOnly time = (TimeOnly)ClosingHour;
                return time.ToShortTimeString();
            }
            set
            {
                if (value != "") ClosingHour = TimeOnly.FromDateTime(Convert.ToDateTime(value));
            }
        }

        #endregion

        public static Font CreateFont(int size = -1)
        {
            FontStyle style = FontStyle.Regular;

            if (LocalStorage.Instance.Settings.FontBold) style &= ~FontStyle.Bold;
            if (LocalStorage.Instance.Settings.FontItalic) style &= ~FontStyle.Italic;
            if (LocalStorage.Instance.Settings.FontUnderline) style &= ~FontStyle.Underline;

            return new Font(LocalStorage.Instance.Settings.FontName, size == -1 ? LocalStorage.Instance.Settings.FontSize : size, style);
        }

    }

}
