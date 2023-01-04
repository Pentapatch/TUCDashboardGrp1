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

        public static void testar()
        {
            throw new NotImplementedException();
        }


        private void AdminTools_FormClosing(object sender, FormClosingEventArgs e) => LocalStorage.Instance.Save();

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // IMPORTANT: Set the ToolStripMenuItem.Tag property to the index of the target page
            int index = Convert.ToInt32(e.ClickedItem.Tag);
            tabControl1.SelectTab(index);

            if (index == 1)
            {
                
                bookingPanel1.BookingsRefresh();
            }
        }

        private void btn_settings_openInExplorer_Click(object sender, EventArgs e) => LocalStorage.Instance.OpenInExplorer();

    }

}
