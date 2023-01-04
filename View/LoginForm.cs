namespace TUCDashboardGrp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            Text = $"{DashboardForm.ApplicationTitle} - Login to admin tools";

            this.ActiveControl = textBoxUsername;
            textBoxUsername.Focus();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxUsername.Text;
            string pass = textBoxPassword.Text;

            if (user == "admin" && pass == "admin" || DashboardForm.IsDebugging)
            {
                //labelMessage.Text = "Welcome Admin";
                //labelMessage.ForeColor = System.Drawing.Color.Green;
                using (AdminTools a = new AdminTools())
                {
                    this.Visible = false;
                    a.ShowDialog(Owner);
                    this.Close();
                    this.Visible = true;

                }
            }

            else
            {
                labelMessage.Text = "Invalid details";
                labelMessage.ForeColor = System.Drawing.Color.Red;
            }

            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(sender, new());
            }
        }

     
    }

}
