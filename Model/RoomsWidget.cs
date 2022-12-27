using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using TUCDashboardGrp1.Controller;

namespace TUCDashboardGrp1.Model
{
    public partial class RoomsWidget : Widget
    {

        public string WidgetName { get; set; } = string.Empty;
        public List<BookingClass> Bookings { get; set; } = new();

        public List<string> Rooms { get; set; } = new();

        public int RowHeight { get; set; } = 45;

        public int TimelineHeight { get; set; } = 30;
        public int TimelineStart { get; set; } = 8;
        public int TimelineStop { get; set; } = 18;


        public RoomsWidget()
        {
            InitializeComponent();

            GlobalTimer.Instance.RefreshWidget += Instance_RefreshWidget;
            Load += Instance_RefreshWidget;
        }

        private void Instance_RefreshWidget(object? sender, EventArgs e)
        {
            Bookings = LocalStorage.Instance.Storage.Bookings;
            Invalidate();
        }

        private List<BookingClass> GetCurrentBookings()
        {
            List<BookingClass> result = new();

            foreach (BookingClass booking in Bookings)
                if (booking.Date == DateOnly.FromDateTime(DateTime.Now.Date)) result.Add(booking);

            return result;
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);

            // Do not bother drawing if there are no rooms declared
            if (Rooms.Count == 0) return;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            Font bodyFont = new(Font.FontFamily, Font.Size - 8, Font.Style);
            Font bookingFont = new(Font.FontFamily, Font.Size - 12, Font.Style);

            SolidBrush textBrush = new(Color.Black);
            SolidBrush accentBrush = new(Color.FromArgb(155, 155, 155));
            SolidBrush tucRedBrush = new(Color.FromArgb(226, 35, 26));

            int minimum = (BorderRadius / 3) + BorderWidth;
            int bodyHeight = (int)e.Graphics.MeasureString(Rooms[0], bodyFont).Height;

            // Draw room names
            int rowTopStart = minimum + 100;
            int timelineX = minimum + GetMaximumWidth(e.Graphics, bodyFont) + 20;
            int dividerlineX = timelineX - 10;

            // Calculate the lenght of the timeline and set a int? for %usage
            int timelineWidth = Width - timelineX - minimum - 20;
            int totalLenght = timelineWidth;
            int totalTime = TimelineStop - TimelineStart;

            // Drawing the header
            e.Graphics.DrawString(WidgetName, Font, textBrush, new Point(minimum, minimum));

            // Draw a separator                                                              
            e.Graphics.FillRectangle(accentBrush, dividerlineX, rowTopStart + 10, 1, (RowHeight * Rooms.Count) - (TimelineHeight / 2) - 20);
            timelineX += 10;

            // Draw the time values (as a header)
            for (int i = 0; i < TimelineStop - TimelineStart - 1; i += 2)
            {
                // Do the Calc's needed for the drawing
                int hour = TimelineStart + i;
                int timeLeft = timelineX + ((totalLenght / totalTime) * i);
                int timeTop = rowTopStart - bodyHeight - 4;
                // Draw the Header
                e.Graphics.DrawString($"{hour}:00", bodyFont, textBrush, new Point(timeLeft, timeTop));
            }

            // Loop through all the Rooms and Draw
            for (int i = 0; i < Rooms.Count; i++)
            {
                int currentTop = rowTopStart + (i * RowHeight);

                // Draw the room name
                e.Graphics.DrawString(Rooms[i], bodyFont, textBrush, new Point(minimum, currentTop));

                // Calculate Height of the Timeline
                int timelineY = currentTop + (bodyHeight / 2) - (TimelineHeight / 2);

                // Fill in the timeline background
                e.Graphics.FillRectangle(accentBrush, timelineX, timelineY, timelineWidth, TimelineHeight);

                // Check if the current room has any reservations
                foreach (BookingClass booking in GetCurrentBookings())
                {
                    if (Rooms[i] == booking.Room)
                    {
                        // Check the start and endtime to compare to the points in %
                        int bookingStart = booking.StartTime.Hour;
                        int bookingStop = booking.EndTime.Hour;

                        // !!! TODO: Perform time validation here
                        //           If out of bounds: continue;

                        // Calculate the position of the booking field
                        int width = (int)(totalLenght / (double)totalTime * (bookingStop - bookingStart)); // <-- This line contains the rounding error
                        int left = timelineX + ((totalLenght / totalTime) * (bookingStart - TimelineStart));

                        // Fill in the time line with the values of the current booking
                        e.Graphics.FillRectangle(tucRedBrush, left, timelineY, width, TimelineHeight);

                        // Get the name of the bookie
                        string bookieName = booking.BookedFor;

                        // Calculate where in the Booking to draw
                        int bookieWidth = (int)e.Graphics.MeasureString(bookieName, bookingFont).Width;
                        int bookieHeight = (int)e.Graphics.MeasureString(bookieName, bookingFont).Height;
                        int bookieLeft = left + (width / 2) - (bookieWidth / 2);
                        int bookieTop = timelineY + (TimelineHeight / 2) - (bookieHeight / 2);

                        // Draw the name of the bookie
                        e.Graphics.DrawString(bookieName, bookingFont, textBrush, new Point(bookieLeft, bookieTop));
                    }
                }
            }

            // Dispose of used Brushes to free up unused memory
            textBrush.Dispose();
            accentBrush.Dispose();
            tucRedBrush.Dispose();
        }


        // Calculate MaxWidth for viewing
        private int GetMaximumWidth(Graphics g, Font font)
        {
            int max = int.MinValue;
            foreach (string room in Rooms)
            {
                int current = (int)g.MeasureString(room, font).Width;
                if (current > max) max = current;
            }

            return max;
        }

    }

}
