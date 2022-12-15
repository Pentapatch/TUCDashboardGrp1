using TUCDashboardGrp1.Controller;

namespace TUCDashboardGrp1
{
    public partial class DashboardForm : Form
    {
        private LoginForm login = new();
        private AdminTools admin = new();

        public DashboardForm()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

        private void DashboardForm_KeyDown(object sender, KeyEventArgs e)
        {
           // TODO: Not firing: look in to
        }

        private void DashboardForm_Shown(object sender, EventArgs e)
        {

        }

        private void ShowLogin()
        {
            login.ShowDialog();
        }

        private void ShowAdminTools()
        {
            admin.ShowDialog();
        }
    }
}