
using System.Xml.Serialization;
using TUCDashboardGrp1.Controller;

namespace TUCDashboardGrp1.Model
{
    public class XmlLocalStorage
    {
        #region Fields

        private List<FeedData> feed = new();
        private List<BookingClass> bookings = new();

        #endregion

        #region XMLIgnore

        [XmlIgnore]
        public List<FeedData> Feed { get => feed; set => feed = value; }

        [XmlIgnore]
        public List<BookingClass> Bookings { get => bookings; set => bookings = value; }
        #endregion

        #region XML

        // Alla enskillda feed object i ett array
        [XmlElement("XMLFeed")]
        public FeedData[]? XMLFeed
        {
            get { return feed.ToArray(); }
            set { if (value != null) feed = new List<FeedData>(value); }
        }

        // Alla enskillda bokningar i ett array
        [XmlElement("XMLBookings")]
        public BookingClass[]? XMLBookings
        {
            get { return bookings.ToArray(); }
            set { if (value != null) bookings = new List<BookingClass>(value); }
        }

        #endregion


        public XmlLocalStorage()
        {
            bookings.Add( new() { Date = DateOnly.FromDateTime(DateTime.Now), StartTime = TimeOnly.FromDateTime(DateTime.Now), BookedFor = "SYNE22", Room = "G-punkt", EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)) });

            feed.Add(new() { Content = "Content 4", Header = "Header 4" });
            feed.Add(new() { Content = "Content 1", Header = "Header 1" });
            feed.Add(new() { Content = "Content 2", Header = "Header 2" });
            feed.Add(new() { Content = "Content 3", Header = "Header 3", XMLImage = "C:\\Users\\newsi\\OneDrive\\Skrivbord\\VSC KeyboardReferenceSheet.png" });
        }

    }
}