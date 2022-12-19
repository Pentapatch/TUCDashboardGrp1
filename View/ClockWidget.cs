using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUCDashboardGrp1.Model;

namespace TUCDashboardGrp1.View
{
    public partial class ClockWidget : Widget
    {
        public ClockWidget()
        {
            InitializeComponent(); //dont touch!!!
        }

        

        private void ClockWidget_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();

            label2.Text = DateTime.Now.ToLongDateString();
        }
    }
}
