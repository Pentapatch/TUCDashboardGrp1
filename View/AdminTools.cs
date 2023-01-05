using TUCDashboardGrp1.Controller;
using TUCDashboardGrp1.Model;

namespace TUCDashboardGrp1
{
    public partial class AdminTools : Form
    {
        private string feedImagePath = string.Empty;

        private FeedData? isEditingFeedItem = null;
        private BookingClass? isEditingBookingItem = null;

        private const string EmptyFeedHeader = "<ingen rubrik>";
        private const string EmptyFeedContent = "<inget innehåll>";
        private const string EmptyFeedImage = "<ingen bild>";
        private const string EmptyBookingRoom = "Välj ett rum..";

        public AdminTools()
        {
            InitializeComponent();

            Text = $"{DashboardForm.ApplicationTitle} - Admin tools";

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            FeedRefresh();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // IMPORTANT: Set the ToolStripMenuItem.Tag property to the index of the target page
            int index = Convert.ToInt32(e.ClickedItem.Tag);
            tabControl1.SelectTab(index);

            if (index == 1)
            {
                // Bookings
                BookingsRefresh();
            }
        }

        private void btn_settings_openInExplorer_Click(object sender, EventArgs e) => LocalStorage.Instance.OpenInExplorer();

        #region Feed panel

        #region Event handlers

        private void Feed_ListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && listview_feed.SelectedItems.Count > 0)
            {
                // Delete entries
                FeedRemoveEntries();
            }
            else if (e.KeyCode == Keys.A && e.Control && !e.Alt && !e.Shift)
            {
                // Select all items
                foreach (ListViewItem item in listview_feed.Items)
                    item.Selected = true;
            }
        }

        private void Feed_ListView_Leave(object sender, EventArgs e)
        {
            // Hide the selection if we are not editing it (to make it
            // more obvious if we are editing an item or not)
            listview_feed.HideSelection = isEditingFeedItem == null;
        }

        private void Feed_Textboxes_KeyDown(object sender, KeyEventArgs e)
        {
            // Allow for quick-submit by pressing ctrl + return
            if (e.KeyCode == Keys.Return && e.Control && !e.Alt && !e.Shift) FeedSubmit();
        }

        private void Feed_BrowseForImage_Click(object sender, EventArgs e)
        {
            string path = FeedBrowseForImage();

            // Abort if cancelled (early exit)
            if (path == "") return;

            // Show the preview
            try
            {
                feedImagePath = path;
                picturebox_feed_preview.Image = new Bitmap(feedImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when loading image:\n{ex.Message}", DashboardForm.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Feed_ClearImage_Click(object sender, EventArgs e) => FeedClearImage();

        private void Feed_ClearForm_Click(object sender, EventArgs e) => FeedClearForm();

        private void Feed_Submit_Click(object sender, EventArgs e) => FeedSubmit();

        private void Feed_ListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Perform a hit test to find the entry that was clicked on
            ListViewHitTestInfo hitTest = listview_feed.HitTest(e.Location);
            if (hitTest.Item == null) return;

            // Set the edit flag and populate the control with the values of the entry
            FeedEditEntry(hitTest.Item);

            // Focus the corresponding control
            int columnIndex = hitTest.Item.SubItems.IndexOf(hitTest.SubItem);
            if (columnIndex == 0) textbox_feed_header.Focus();
            else if (columnIndex == 1) textbox_feed_content.Focus();
            else btn_feed_browseForImage.Focus();
        }

        #endregion // End event handlers region

        #region Feed functions

        private void FeedRefresh()
        {
            // Load the feed into the listview control
            listview_feed.Items.Clear();

            for (int i = LocalStorage.Instance.Storage.Feed.Count - 1; i >= 0; i--)
            {
                FeedData data = LocalStorage.Instance.Storage.Feed[i];
                ListViewItem item = listview_feed.Items.Add(data.Header != "" ? data.Header : EmptyFeedHeader);
                item.Tag = data;

                item.SubItems.Add(data.Content != "" ? data.Content : EmptyFeedContent);
                item.SubItems.Add(data.XMLImage != "" ? data.XMLImage : EmptyFeedImage);
            }
        }

        private void FeedSubmit()
        {
            // Warn if all fields are empty (early exit)
            if (feedImagePath == "" && textbox_feed_header.Text == "" && textbox_feed_content.Text == "")
            {
                MessageBox.Show("Du måste fylla minst ett av fälten.", DashboardForm.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Either update the current entry or create a new one
            if (isEditingFeedItem != null)
            {
                // Update the value of the current feed entry
                isEditingFeedItem.Header = textbox_feed_header.Text;
                isEditingFeedItem.Content = textbox_feed_content.Text;
                isEditingFeedItem.XMLImage = feedImagePath;
            }
            else
            {
                // Add a new feed to the local storage
                LocalStorage.Instance.Storage.Feed.Add(new()
                {
                    Header = textbox_feed_header.Text,
                    Content = textbox_feed_content.Text,
                    XMLImage = feedImagePath,
                });
            }

            // Save the local storage to file
            LocalStorage.Instance.Save<XmlLocalStorage>();

            // Make all widgets refresh themselves
            GlobalTimer.Instance.Refresh();

            // Clear the form
            FeedClearForm();

            // Update the treeview
            FeedRefresh();
        }

        private string FeedBrowseForImage()
        {
            OpenFileDialog browser = new()
            {
                Filter = "Bildfiler| *.bmp; *.jpg; *.jpeg; *.gif; *.png | Bitmap (*.bmp) | *.bmp | Joint Photographic Experts Group (*.jpg; *.jpeg) | *.jpg; *.jpeg | Graphics Interchange Format (*.gif) | *.gif | Portable Network Graphics (*.png) | *.png",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
            };

            browser.ShowDialog(this);

            return browser.FileName;
        }

        private void FeedClearForm()
        {
            textbox_feed_header.Text = "";
            textbox_feed_content.Text = "";
            FeedClearImage();
            textbox_feed_header.Focus();
            isEditingFeedItem = null;
            btn_feed_submit.Text = "&Lägg till";
            btn_feed_clear.Text = "&Rensa form";
            listview_feed.SelectedItems.Clear();
            listview_feed.Enabled = true;
        }

        private void FeedClearImage()
        {
            feedImagePath = "";
            picturebox_feed_preview.Image = null;
        }

        private void FeedEditEntry(ListViewItem item)
        {
            if (item.Tag is not FeedData) return;

            isEditingFeedItem = (FeedData)item.Tag;

            string header = item.Text;
            string content = item.SubItems[1].Text;
            string imagePath = item.SubItems[2].Text;

            textbox_feed_header.Text = header != EmptyFeedHeader ? header : "";
            textbox_feed_content.Text = content != EmptyFeedContent ? content : "";
            picturebox_feed_preview.Image = imagePath != EmptyFeedImage ? new Bitmap(imagePath) : null;
            feedImagePath = imagePath;

            btn_feed_submit.Text = "&Uppdatera";
            btn_feed_clear.Text = "&Avbryt";
            listview_feed.Enabled = false;
        }

        private void FeedRemoveEntry(ListViewItem item)
        {
            if (item.Tag is not FeedData) return;

            // Remove the entry from the local storage
            LocalStorage.Instance.Storage.Feed.Remove((FeedData)item.Tag);

            // Remove the item from the listview
            listview_feed.Items.Remove(item);
        }

        private void FeedRemoveEntries()
        {
            // Give the user a chanse to abort (early exit)
            if (MessageBox.Show($"Vill du verkligen ta bort " +
                $"{(listview_feed.SelectedItems.Count == 1 ? "detta" : $"dessa {listview_feed.SelectedItems.Count}")} fält?",
                DashboardForm.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            foreach (ListViewItem item in listview_feed.SelectedItems)
                FeedRemoveEntry(item);

            // Save the local storage to file
            LocalStorage.Instance.Save<XmlLocalStorage>();

            // Make all widgets refresh themselves
            GlobalTimer.Instance.Refresh();

            // Clear the form
            FeedClearForm();
        }

        #endregion // End feed functions

        #endregion // End feed panel region

        #region Booking panel

        #region Event handlers

        private void Booking_Submit_Click(object sender, EventArgs e) => BookingSubmit();

        private void Booking_Reset_Click(object sender, EventArgs e) => BookingClearForm();

        private void Booking_Room_Enter(object sender, EventArgs e) => combobox_room.DroppedDown = true;

        #endregion // End event handlers region

        #region Booking functions

        private void BookingsRefresh()
        {
            // Load the feed into the listview control
            listview_bookings.Items.Clear();

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
            LocalStorage.Instance.Save<XmlLocalStorage>();

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

        #endregion

        #endregion // End booking panel region

    }

}
