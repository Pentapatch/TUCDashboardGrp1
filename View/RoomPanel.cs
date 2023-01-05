using TUCDashboardGrp1.Controller;
using TUCDashboardGrp1.Model;

namespace TUCDashboardGrp1.View
{
    public partial class RoomPanel : UserControl
    {

        private Rooms? isEditingRoomItem = null;

        public RoomPanel()
        {
            // Initialize, don't touch! 
            InitializeComponent();
        }

        // EventHandlers
        #region EventHandlers
        private void btn_add_room_Click(object sender, EventArgs e)
        {
            AddRoom();
        }

        private void btn_editrooms_back_Click(object sender, EventArgs e)
        {
            if (ParentForm is TUCDashboardGrp1.AdminTools admin) admin.ChangeTab(2);
        }

        private void btn_edit_room_Click(object sender, EventArgs e)
        {
            EditRooms();
        }

        private void btn_editrooms_clear_Click(object sender, EventArgs e)
        {
            ClearRoomsForm();
        }

        private void btn_remove_all_Click(object sender, EventArgs e)
        {
            RemoveAllRooms();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            RemoveSelectedRoom();
            PopulateRoomsList();
        }

        private void checkb_is_group_Click(object sender, EventArgs e)
        {
            if (checkb_is_lecture.Checked)
                checkb_is_lecture.Checked = false;
        }

        private void checkb_is_lecture_Click(object sender, EventArgs e)
        {
            if (checkb_is_group.Checked)
                checkb_is_group.Checked = false;
        }

        private void listView_edit_rooms_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditRooms();
        }

        private void listView_edit_rooms_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) RemoveSelectedRoom();
        }

        #endregion

        // Functions
        #region Functions
        private void AddRoom()
        {
            // Early exit if roomname is left empty
            if (textBox_room_name.Text == "")
            {
                MessageBox.Show(
                    "Fyll rummets namn.",
                    "TUC Dashboard",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            // Early exit if no checkbox is checked            
            if (!checkb_is_group.Checked && !checkb_is_lecture.Checked)
            {
                MessageBox.Show(
                    "Du måste välja rumstyp.",
                    "TUC Dashboard",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            // Create a new Rooms object
            Rooms room = new Rooms()
            {
                RoomName = textBox_room_name.Text,
                RoomType = checkb_is_group.Checked ? "Grupprum" : "Sal"
            };

            if (isEditingRoomItem == null)
            {
                LocalStorage.Instance.Storage.Rooms.Add(room);
            }
            else
            {
                isEditingRoomItem.RoomName = textBox_room_name.Text;
                isEditingRoomItem.RoomType = checkb_is_lecture.Checked ? "Sal" : "Grupprum";
            }
            ClearRoomsForm();
            LocalStorage.Instance.Save<XmlLocalStorage>();
            PopulateRoomsList();
            GlobalTimer.Instance.Refresh();
        }

        private void EditRooms()
        {
            foreach (Rooms room in LocalStorage.Instance.Storage.Rooms)
            {
                if (room.RoomName == listView_edit_rooms.SelectedItems[0].Text)
                {
                    isEditingRoomItem = room;
                    break;
                }
            }

            listView_edit_rooms.Enabled = false;
            btn_add_room.Text = "Uppdatera";
            btn_editrooms_clear.Text = "Avbryt";

            textBox_room_name.Text = isEditingRoomItem!.RoomName;

            if (isEditingRoomItem.RoomType == "Sal")
            {
                checkb_is_lecture.Checked = true;
                checkb_is_group.Checked = false;
            }
            else if (isEditingRoomItem.RoomType == "Grupprum")
            {
                checkb_is_group.Checked = true;
                checkb_is_lecture.Checked = false;
            }
        }

        private void ClearRoomsForm()
        {
            textBox_room_name.Text = "";
            checkb_is_group.Checked = false;
            checkb_is_lecture.Checked = false;
            isEditingRoomItem = null;
            btn_add_room.Text = "Lägg till";
            btn_editrooms_clear.Text = "Rensa";
            listView_edit_rooms.Enabled = true;

        }

        public void PopulateRoomsList()
        {
            // Clear the listview
            listView_edit_rooms.Items.Clear();
            TUCDashboardGrp1.AdminTools admin = (TUCDashboardGrp1.AdminTools)ParentForm;

            admin.ClearRooms();

            foreach (Rooms room in LocalStorage.Instance.Storage.Rooms)
            {
                listView_edit_rooms.Items.Add(room.RoomName);
                listView_edit_rooms.Items[^1].SubItems.Add(room.RoomType);
                admin.AddRoom(room.RoomName);
                
            }


        }
        private void RemoveAllRooms()
        {
            if (MessageBox.Show($"Vill du verkligen ta bort alla fält?",
                DashboardForm.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            LocalStorage.Instance.Storage.Rooms.Clear();
            LocalStorage.Instance.Save<XmlLocalStorage>();
            PopulateRoomsList();
            GlobalTimer.Instance.Refresh();
        }
        private void RemoveSelectedRoom()
        {
            if (MessageBox.Show($"Vill du verkligen ta bort " +
                $"{(listView_edit_rooms.SelectedItems.Count == 1 ? "detta" : $"dessa {listView_edit_rooms.SelectedItems.Count}")} fält?",
                DashboardForm.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            foreach (ListViewItem item in listView_edit_rooms.SelectedItems)
            {
                foreach (Rooms room in LocalStorage.Instance.Storage.Rooms)
                {
                    if (item.Text == room.RoomName)
                    {
                        LocalStorage.Instance.Storage.Rooms.Remove(room);
                        break;
                    }

                }
            }
            LocalStorage.Instance.Save<XmlLocalStorage>();
            PopulateRoomsList();
            GlobalTimer.Instance.Refresh();
        }
        #endregion

    }
}
