using TUCDashboardGrp1.Controller;
using TUCDashboardGrp1.Model;
using TUCDashboardGrp1.View;

namespace TUCDashboardGrp1
{
    public partial class AdminTools : Form
    {

        public AdminTools()
        {
            InitializeComponent();

            Text = $"{DashboardForm.ApplicationTitle} - Admin tools";

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            
            feedPanel1.FeedRefresh();
        }

        public void PopulateRoomsList() => roomPanel1.PopulateRoomsList();

        public void ChangeTab(int index) => tabControl1.SelectTab(index);

        public void ClearRooms() => bookingPanel1.ClearRooms();

        public void AddRoom(string roomName) => bookingPanel1.AddRoom(roomName);

        private void AdminTools_FormClosing(object sender, FormClosingEventArgs e) => LocalStorage.Instance.SaveData();

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // IMPORTANT: Set the ToolStripMenuItem.Tag property to the index of the target page
            int index = Convert.ToInt32(e.ClickedItem.Tag);
            tabControl1.SelectTab(index);

            if (index == 0)
            {
                feedPanel1.FeedRefresh();
            }
            else if (index == 1)
            {
                bookingPanel1.BookingsRefresh();
            }
        }

    }

}