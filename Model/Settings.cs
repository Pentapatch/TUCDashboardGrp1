using System.Xml.Serialization;

namespace TUCDashboardGrp1.Model
{
    public class Settings
    {

        public string DataPath { get; set; } = @$"{Application.UserAppDataPath}\Settings\AppData1.xml";

        public string LogotypePath { get; set; } = "";

        public int BorderRadius { get; set; }

        public int BorderWidth { get; set; }

        #region XMLIgnore

        [XmlIgnore]
        public TimeOnly? OpeningHour { get; set; }

        [XmlIgnore]
        public Color BackgroundColor { get; set; }

        [XmlIgnore]
        public Color WidgetBackgroundColor { get; set; }

        [XmlIgnore]
        public Color AccentColor { get; set; }

        [XmlIgnore]
        public Color BaseColor { get; set; }
        
        [XmlIgnore]
        public Color TextColor { get; set; }

        [XmlIgnore]
        public Color BorderColor { get; set; }

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
            get {
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

    }
}
