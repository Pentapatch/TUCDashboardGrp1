using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUCDashboardGrp1.Properties;

namespace TUCDashboardGrp1
{
    public partial class AdminTools : Form
    {
        public AdminTools()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void feedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }
        private void grupprumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browser.Filter = "Bildfiler| *.bmp; *.jpg; *.jpeg; *.gif; *.png | Bitmap (*.bmp) | *.bmp | Joint photographic experts group (*.jpg; *.jpeg) | *.jpg; *.jpeg";
            browser.ShowDialog(this);

            var test = browser.FileName;
            // "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            picturebox_feed_preview.Image = Resources._1;
        }

        private void inställningarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }
    }
}
