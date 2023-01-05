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

        public BookingPanel() // Initialization, don't touch
        {
            InitializeComponent();
        }


        #region Booking panel

        #region Event handlers

        private void Booking_Submit_Click(object sender, EventArgs e) => BookingSubmit();

        private void Booking_Reset_Click(object sender, EventArgs e) => BookingClearForm();

        private void Booking_Room_Enter(object sender, EventArgs e) => combobox_room.DroppedDown = true;

        private void combobox_room_DropDownClosed(object sender, EventArgs e)
        {
            // Check if any room in the list contains part of what was written
            foreach (string room in combobox_room.Items)
            {
                if (room.ToLower() == combobox_room.Text.ToLower() ||
                    room.ToLower().Contains(combobox_room.Text.ToLower()))
                {
                    combobox_room.Text = room;
                    return;
                }
            }
        }
        
        private void Listview_MouseDoubleClick(object sender, MouseEventArgs e) => EditBooking();

        private void listview_bookings_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if delete key was pressed
            if (e.KeyCode == Keys.Delete && listview_bookings.SelectedItems.Count > 0)
            {
                // Delete entries
                RemoveEntries();
            }
            else if (e.KeyCode == Keys.A && e.Control && !e.Alt && !e.Shift)
            {
                // Select all items
                foreach (ListViewItem item in listview_bookings.Items)
                    item.Selected = true;
            }
        }

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
            if (!combobox_room.Items.Contains(combobox_room.Text))
            {
                MessageBox.Show("Det valda rummet finns inte.", DashboardForm.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                isEditingBookingItem.Room = combobox_room.Text;
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

            listview_bookings.Enabled = true;
            button1.Text = "Lägg till";
            button2.Text = "Rensa";

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

        private void RemoveEntries()
        {
            // Give the user a chanse to abort (early exit)
            if (MessageBox.Show($"Vill du verkligen ta bort " +
                $"{(listview_bookings.SelectedItems.Count == 1 ? "detta" : $"dessa {listview_bookings.SelectedItems.Count}")} fält?",
                DashboardForm.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            foreach (ListViewItem item in listview_bookings.SelectedItems)
                RemoveEntry(item);

            // Save the local storage to file
            LocalStorage.Instance.Save();

            // Make all widgets refresh themselves
            GlobalTimer.Instance.Refresh();

            // Clear the form
            BookingClearForm();
        }

        private void RemoveEntry(ListViewItem item)
        {
            if (item.Tag is not BookingClass) return;

            // Remove the entry from the local storage
            LocalStorage.Instance.Storage.Bookings.Remove((BookingClass)item.Tag);

            // Remove the item from the listview
            listview_bookings.Items.Remove(item);
        }

        private void EditBooking()
        {
            if (listview_bookings.SelectedItems[0].Tag is BookingClass booking)
            {
                isEditingBookingItem = booking;

                // Load the controls with the values of the isEditingBookingItem
                textBox_booked_for.Text = isEditingBookingItem.BookedFor;
                textBox_booked_by.Text = isEditingBookingItem.BookedBy;
                dateTimePicker_date.Text = isEditingBookingItem.Date.ToString("o");
                dateTimePicker_start.Text = isEditingBookingItem.StartTime.ToString();
                dateTimePicker_stop.Text = isEditingBookingItem.EndTime.ToString();
                combobox_room.Text = isEditingBookingItem.Room;

                // Disable the listview
                listview_bookings.Enabled = false;

                // Update the button texts
                button1.Text = "Uppdatera";
                button2.Text = "Avbryt";
            }
        }

        #endregion

        #endregion // End booking panel region

    }

}
