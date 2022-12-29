using System.Xml.Serialization;

namespace TUCDashboardGrp1.Controller
{
    public class BookingClass
    {

        public BookingClass()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }            // Database Use "only" .... 

        public string Room { get; set; }        // G1, A8

        public string BookedBy { get; set; }    // Bokee: Dan S. Syne22

        public string BookedFor { get; set; }   // Syne22 

        #region XML Ignore

        [XmlIgnore]
        public DateOnly Date { get; set; }      // 2022-12-14

        [XmlIgnore]
        public TimeOnly StartTime { get; set; } // 10.00

        [XmlIgnore]
        public TimeOnly EndTime { get; set; }   // 12.00

        #endregion

        #region XML

        [XmlElement("XMLDate")]
        public string XMLDate
        {
            get => Date.ToString("o");
            set
            {
                if (value != "") Date = DateOnly.FromDateTime(Convert.ToDateTime(value));
            }
        }

        [XmlElement("XMLStartTime")]
        public string XMLStartTime
        {
            get => StartTime.ToShortTimeString();
            set
            {
                if (value != "") StartTime = TimeOnly.FromDateTime(Convert.ToDateTime(value));
            }
        }

        [XmlElement("XMLEndTime")]
        public string XMLEndTime
        {
            get => EndTime.ToShortTimeString();
            set
            {
                if (value != "") EndTime = TimeOnly.FromDateTime(Convert.ToDateTime(value));
            }
        }

        #endregion
    }

}