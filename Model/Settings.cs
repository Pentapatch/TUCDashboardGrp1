using System.Xml.Serialization;

namespace TUCDashboardGrp1.Model
{
    public class Settings
    {

        public string DataPath { get; set; } = @$"{Application.UserAppDataPath}\Settings\AppData1.xml";

        #region XMLIgnore

        [XmlIgnore]
        public TimeOnly? OpeningHour { get; set; }

        [XmlIgnore]
        public TimeOnly? ClosingHour { get; set; }
        
        #endregion

        #region XMLElements

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
