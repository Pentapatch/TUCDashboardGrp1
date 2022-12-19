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
            var currentTime = DateTime.Now;

            label_time.Text = $"{currentTime.Hour.ToString().PadLeft(2, '0')}:{currentTime.Minute.ToString().PadLeft(2, '0')}";

            //label_date.Text = DateTime.Now.ToLongDateString();
            label_date.Text = $"{GetDayOfWeek(currentTime.DayOfWeek)} {currentTime.Day}:{(currentTime.Day <= 2 ? "a" : "e")}";
        }

        private string GetDayOfWeek(DayOfWeek value) => value switch
        {
            DayOfWeek.Monday => "Måndag",
            DayOfWeek.Tuesday => "Tisdag",
            DayOfWeek.Wednesday => "Onsdag",
            DayOfWeek.Thursday => "Torsdag",
            DayOfWeek.Friday => "Fredag",
            DayOfWeek.Saturday => "Lördag",
            _ => "Söndag",
        };

    }
}
