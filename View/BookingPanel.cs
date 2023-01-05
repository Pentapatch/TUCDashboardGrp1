using TUCDashboardGrp1.Controller;
using TUCDashboardGrp1.Model;

namespace TUCDashboardGrp1.View
{



    public partial class BookingPanel : UserControl
    {
        // setting Fields
        #region Fields
        private BookingClass? isEditingBookingItem = null;
        private const string EmptyBookingRoom = "Välj ett rum..";
        #endregion

        public TimeOnly? OpeningHour { get; set; } = null;
        public TimeOnly? ClosingHour { get; set; } = null;

        public BookingPanel() // Initialization, don't touch
        {
            InitializeComponent();
        }


        #region Booking panel

        #region Event handlers

        private void Booking_Submit_Click(object sender, EventArgs e) => BookingSubmit();

        private void Booking_Reset_Click(object sender, EventArgs e) => BookingClearForm();

        private void Booking_Room_Enter(object sender, EventArgs e) => combobox_room.DroppedDown = true;

        #endregion // End event handlers region

        #region Booking functions

        public void ClearRooms() => combobox_room.Items.Clear();

        public void AddRoom(string roomName) => combobox_room.Items.Add(roomName);

        public void BookingsRefresh()
        {
            // Load the feed into the listview control
            listview_bookings.Items.Clear();

            // Ask AdminTools to populate the combobox with values
            if (ParentForm is TUCDashboardGrp1.AdminTools admin) admin.PopulateRoomsList();

            for (int i = LocalStorage.Instance.Storage.Bookings.Count - 1; i >= 0; i--)
            {
                BookingClass data = LocalStorage.Instance.Storage.Bookings[i];
                ListViewItem item = listview_bookings.Items.Add(data.BookedFor);
                item.Tag = data;

                if (data.Date < DateOnly.FromDateTime(DateTime.Now))
                {
                    item.ForeColor = Color.Red;
                }

                item.SubItems.Add(data.BookedBy);
                item.SubItems.Add(data.XMLDate);
                item.SubItems.Add(data.XMLStartTime);
                item.SubItems.Add(data.XMLEndTime);
                item.SubItems.Add(data.Room);
            }

            // Reset all controls
            BookingClearForm();
        }

        private void BookingSubmit()
        {
            // Early exit if selected room doesn't exist.
            if (!combobox_room.Items.Contains(combobox_room.Text))
            {
                MessageBox.Show("Det valda rummet finns inte.", DashboardForm.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Early exit if opening hours have not been set yet
            if (OpeningHour == null || ClosingHour == null)
            {
                MessageBox.Show("Du måste ange öppettider innan du kan boka",
                    DashboardForm.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Early exit if either start time or end time falls outside of opened hours.
            if(!IsSchoolOpen(dateTimePicker_start.Value) || !IsSchoolOpen(dateTimePicker_stop.Value) )
            {
                MessageBox.Show(
                    $"Du har försökt boka ett rum {dateTimePicker_start.Text}-{dateTimePicker_stop.Text}, men öppettiderna är {OpeningHour} - {ClosingHour}.\n" +
                    "Vänligen ändra till en tid inom öppettiderna.",
                    DashboardForm.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Early exit if starttime is later than endtime.
            if(dateTimePicker_start.Value > dateTimePicker_stop.Value)
            {
                MessageBox.Show(
                    $"Starttid kan inte vara senare än sluttid.",
                    DashboardForm.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Either update the current entry or create a new one
            if (isEditingBookingItem != null)
            {
                // Update the value of the current feed entry
                isEditingBookingItem.BookedFor = textBox_booked_for.Text;
                isEditingBookingItem.BookedBy = textBox_booked_by.Text;
                isEditingBookingItem.XMLDate = dateTimePicker_date.Text;
                isEditingBookingItem.XMLStartTime = dateTimePicker_start.Text;
                isEditingBookingItem.XMLEndTime = dateTimePicker_stop.Text;
            }
            else
            {
                // Add a new feed to the local storage

                LocalStorage.Instance.Storage.Bookings.Add(new()
                {
                    BookedFor = textBox_booked_for.Text,
                    BookedBy = textBox_booked_by.Text,
                    XMLDate = dateTimePicker_date.Text,
                    XMLStartTime = dateTimePicker_start.Text,
                    XMLEndTime = dateTimePicker_stop.Text,
                    Room = combobox_room.Text,
                });
            }

            // Save the local storage to file
            LocalStorage.Instance.Save();

            // Make all widgets refresh themselves
            GlobalTimer.Instance.Refresh();

            // Clear the form
            BookingClearForm();

            // Update the treeview
            BookingsRefresh();
        }

        private void BookingClearForm()
        {
            // Reset default values
            textBox_booked_for.Text = "";
            textBox_booked_by.Text = "";
            dateTimePicker_date.Text = DateTime.Now.ToShortDateString();
            // Vi är intresserade av .Minute, kanske .Hour

            DateTime now = RoundToClosestHalfHour(DateTime.Now);

            dateTimePicker_start.Text = now.ToShortTimeString();
            dateTimePicker_stop.Text = now.AddHours(2).ToShortTimeString();

            combobox_room.Text = EmptyBookingRoom;

            // Clear the entry that is being edited
            isEditingBookingItem = null;
        }

        private static DateTime RoundToClosestHalfHour(DateTime value, bool incrementHour = true)
        {
            int hour = value.Hour;
            int minute = value.Minute;

            if (minute < 30)
            {
                minute = 30;
            }
            else if (minute >= 30)
            {
                minute = 0;
                if (incrementHour) hour++;
            }

            return new DateTime(value.Year, value.Month, value.Day, hour, minute, 0);
        }

        private bool IsSchoolOpen(DateTime dateTime)
        {
            TimeOnly time = new TimeOnly(dateTime.Hour, dateTime.Minute);
            
            //School has not opened yet
            if (time < OpeningHour ) return false;

            // School has closed for the day
            if (time >= ClosingHour && time.Minute != 0) return false;
            
            return true;
        }

        #endregion

        #endregion // End booking panel region


    }





}
