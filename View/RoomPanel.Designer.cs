namespace TUCDashboardGrp1.View
{
    partial class RoomPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_editrooms_clear = new System.Windows.Forms.Button();
            this.btn_editrooms_back = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit_room = new System.Windows.Forms.Button();
            this.btn_remove_all = new System.Windows.Forms.Button();
            this.btn_add_room = new System.Windows.Forms.Button();
            this.label_room_type = new System.Windows.Forms.Label();
            this.checkb_is_lecture = new System.Windows.Forms.CheckBox();
            this.checkb_is_group = new System.Windows.Forms.CheckBox();
            this.textBox_room_name = new System.Windows.Forms.TextBox();
            this.label_room_name = new System.Windows.Forms.Label();
            this.listView_edit_rooms = new System.Windows.Forms.ListView();
            this.col_room_name = new System.Windows.Forms.ColumnHeader();
            this.col_room_type = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btn_editrooms_clear
            // 
            this.btn_editrooms_clear.Location = new System.Drawing.Point(185, 99);
            this.btn_editrooms_clear.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_editrooms_clear.Name = "btn_editrooms_clear";
            this.btn_editrooms_clear.Size = new System.Drawing.Size(81, 22);
            this.btn_editrooms_clear.TabIndex = 22;
            this.btn_editrooms_clear.Text = "Rensa";
            this.btn_editrooms_clear.UseVisualStyleBackColor = true;
            this.btn_editrooms_clear.Click += new System.EventHandler(this.btn_editrooms_clear_Click);
            // 
            // btn_editrooms_back
            // 
            this.btn_editrooms_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editrooms_back.Location = new System.Drawing.Point(89, 382);
            this.btn_editrooms_back.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_editrooms_back.Name = "btn_editrooms_back";
            this.btn_editrooms_back.Size = new System.Drawing.Size(81, 22);
            this.btn_editrooms_back.TabIndex = 17;
            this.btn_editrooms_back.Text = "Tillbaka";
            this.btn_editrooms_back.UseVisualStyleBackColor = true;
            this.btn_editrooms_back.Click += new System.EventHandler(this.btn_editrooms_back_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remove.Location = new System.Drawing.Point(674, 382);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(81, 22);
            this.btn_remove.TabIndex = 21;
            this.btn_remove.Text = "Ta bort";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit_room
            // 
            this.btn_edit_room.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit_room.Location = new System.Drawing.Point(578, 382);
            this.btn_edit_room.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_edit_room.Name = "btn_edit_room";
            this.btn_edit_room.Size = new System.Drawing.Size(81, 22);
            this.btn_edit_room.TabIndex = 20;
            this.btn_edit_room.Text = "Redigera";
            this.btn_edit_room.UseVisualStyleBackColor = true;
            this.btn_edit_room.Click += new System.EventHandler(this.btn_edit_room_Click);
            // 
            // btn_remove_all
            // 
            this.btn_remove_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remove_all.Location = new System.Drawing.Point(481, 382);
            this.btn_remove_all.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_remove_all.Name = "btn_remove_all";
            this.btn_remove_all.Size = new System.Drawing.Size(81, 22);
            this.btn_remove_all.TabIndex = 18;
            this.btn_remove_all.Text = "Ta bort alla";
            this.btn_remove_all.UseVisualStyleBackColor = true;
            this.btn_remove_all.Click += new System.EventHandler(this.btn_remove_all_Click);
            // 
            // btn_add_room
            // 
            this.btn_add_room.Location = new System.Drawing.Point(89, 99);
            this.btn_add_room.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_add_room.Name = "btn_add_room";
            this.btn_add_room.Size = new System.Drawing.Size(81, 22);
            this.btn_add_room.TabIndex = 16;
            this.btn_add_room.Text = "Lägg till";
            this.btn_add_room.UseVisualStyleBackColor = true;
            this.btn_add_room.Click += new System.EventHandler(this.btn_add_room_Click);
            // 
            // label_room_type
            // 
            this.label_room_type.AutoSize = true;
            this.label_room_type.Location = new System.Drawing.Point(4, 32);
            this.label_room_type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_room_type.Name = "label_room_type";
            this.label_room_type.Size = new System.Drawing.Size(57, 15);
            this.label_room_type.TabIndex = 19;
            this.label_room_type.Text = "Rumstyp:";
            // 
            // checkb_is_lecture
            // 
            this.checkb_is_lecture.AutoSize = true;
            this.checkb_is_lecture.Location = new System.Drawing.Point(89, 61);
            this.checkb_is_lecture.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkb_is_lecture.Name = "checkb_is_lecture";
            this.checkb_is_lecture.Size = new System.Drawing.Size(41, 19);
            this.checkb_is_lecture.TabIndex = 15;
            this.checkb_is_lecture.Text = "Sal";
            this.checkb_is_lecture.UseVisualStyleBackColor = true;
            this.checkb_is_lecture.Click += new System.EventHandler(this.checkb_is_lecture_Click);
            // 
            // checkb_is_group
            // 
            this.checkb_is_group.AutoSize = true;
            this.checkb_is_group.Location = new System.Drawing.Point(89, 32);
            this.checkb_is_group.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkb_is_group.Name = "checkb_is_group";
            this.checkb_is_group.Size = new System.Drawing.Size(81, 19);
            this.checkb_is_group.TabIndex = 14;
            this.checkb_is_group.Text = "Grupprum";
            this.checkb_is_group.UseVisualStyleBackColor = true;
            this.checkb_is_group.Click += new System.EventHandler(this.checkb_is_group_Click);
            // 
            // textBox_room_name
            // 
            this.textBox_room_name.Location = new System.Drawing.Point(89, 3);
            this.textBox_room_name.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_room_name.Name = "textBox_room_name";
            this.textBox_room_name.Size = new System.Drawing.Size(178, 23);
            this.textBox_room_name.TabIndex = 13;
            // 
            // label_room_name
            // 
            this.label_room_name.AutoSize = true;
            this.label_room_name.Location = new System.Drawing.Point(4, 4);
            this.label_room_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_room_name.Name = "label_room_name";
            this.label_room_name.Size = new System.Drawing.Size(71, 15);
            this.label_room_name.TabIndex = 12;
            this.label_room_name.Text = "Rumsnamn:";
            // 
            // listView_edit_rooms
            // 
            this.listView_edit_rooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_edit_rooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_room_name,
            this.col_room_type});
            this.listView_edit_rooms.FullRowSelect = true;
            this.listView_edit_rooms.Location = new System.Drawing.Point(300, 3);
            this.listView_edit_rooms.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listView_edit_rooms.Name = "listView_edit_rooms";
            this.listView_edit_rooms.Size = new System.Drawing.Size(459, 377);
            this.listView_edit_rooms.TabIndex = 11;
            this.listView_edit_rooms.UseCompatibleStateImageBehavior = false;
            this.listView_edit_rooms.View = System.Windows.Forms.View.Details;
            this.listView_edit_rooms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_edit_rooms_KeyDown);
            this.listView_edit_rooms.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_edit_rooms_MouseDoubleClick);
            // 
            // col_room_name
            // 
            this.col_room_name.Text = "Rumsnamn";
            this.col_room_name.Width = 200;
            // 
            // col_room_type
            // 
            this.col_room_type.Text = "Rumstyp";
            this.col_room_type.Width = 200;
            // 
            // RoomPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btn_editrooms_clear);
            this.Controls.Add(this.btn_editrooms_back);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit_room);
            this.Controls.Add(this.btn_remove_all);
            this.Controls.Add(this.btn_add_room);
            this.Controls.Add(this.label_room_type);
            this.Controls.Add(this.checkb_is_lecture);
            this.Controls.Add(this.checkb_is_group);
            this.Controls.Add(this.textBox_room_name);
            this.Controls.Add(this.label_room_name);
            this.Controls.Add(this.listView_edit_rooms);
            this.Name = "RoomPanel";
            this.Size = new System.Drawing.Size(759, 406);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_editrooms_clear;
        private Button btn_editrooms_back;
        private Button btn_remove;
        private Button btn_edit_room;
        private Button btn_remove_all;
        private Button btn_add_room;
        private Label label_room_type;
        private CheckBox checkb_is_lecture;
        private CheckBox checkb_is_group;
        private TextBox textBox_room_name;
        private Label label_room_name;
        private ListView listView_edit_rooms;
        private ColumnHeader col_room_name;
        private ColumnHeader col_room_type;
    }
}
