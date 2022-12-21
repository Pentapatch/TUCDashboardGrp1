using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUCDashboardGrp1.Controller;
using TUCDashboardGrp1.Model;

namespace TUCDashboardGrp1
{
    public partial class LecturesWidget : RoomsWidget
    {
        public LecturesWidget()
        {
            InitializeComponent();
            Rooms.Add("Sal 1");
            Rooms.Add("Sal 2");
            Rooms.Add("Sal 3");
            Rooms.Add("Sal 4");
            Rooms.Add("Sal 5");
            Rooms.Add("Sal 6");
            Rooms.Add("Sal 7");
            Rooms.Add("Sal 8");
            Rooms.Add("Sal 9");
            Rooms.Add("Sal 10");
            Rooms.Add("Sal 11");
        }

    }
}
