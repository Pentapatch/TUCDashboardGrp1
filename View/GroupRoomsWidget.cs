using TUCDashboardGrp1.Model;

namespace TUCDashboardGrp1
{
    public partial class GroupRoomsWidget : RoomsWidget
    {
        public GroupRoomsWidget()
        {
            InitializeComponent();
            Rooms.Add("G1 Roxen");
            Rooms.Add("G2 Stångån");
            Rooms.Add("G3 Glan");
            Rooms.Add("G4 Berga");
            Rooms.Add("G5 Norrköping");
            Rooms.Add("G6 Finspång");
            Rooms.Add("G7 Söderköping");
        }
    }
}
