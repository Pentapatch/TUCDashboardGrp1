using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUCDashboardGrp1
{
    public partial class FeedWidget : UserControl
    {
        public FeedWidget()
        {
            InitializeComponent(); // <-- Don't touch
            test(); // <-- your code here
        }

        private void test()
        {
            BackColor = Color.Green;
        }

    }
}
