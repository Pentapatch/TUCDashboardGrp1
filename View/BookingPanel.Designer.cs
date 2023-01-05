namespace TUCDashboardGrp1.View
{
    partial class BookingPanel
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
            this.listview_bookings = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_booked_by = new System.Windows.Forms.TextBox();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combobox_room = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_booked_for = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker_stop = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listview_bookings
            // 
            this.listview_bookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listview_bookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader9,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listview_bookings.FullRowSelect = true;
            this.listview_bookings.Location = new System.Drawing.Point(358, 3);
            this.listview_bookings.Name = "listview_bookings";
            this.listview_bookings.Size = new System.Drawing.Size(871, 507);
            this.listview_bookings.TabIndex = 8;
            this.listview_bookings.UseCompatibleStateImageBehavior = false;
            this.listview_bookings.View = System.Windows.Forms.View.Details;
            this.listview_bookings.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listview_bookings_KeyDown);
            this.listview_bookings.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Listview_MouseDoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bokad för";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Bokad av";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Datum";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Starttid";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Sluttid";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Rum / Sal";
            this.columnHeader8.Width = 180;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bokad av:";
            // 
            // textBox_booked_by
            // 
            this.textBox_booked_by.Location = new System.Drawing.Point(104, 48);
            this.textBox_booked_by.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_booked_by.Name = "textBox_booked_by";
            this.textBox_booked_by.Size = new System.Drawing.Size(235, 27);
            this.textBox_booked_by.TabIndex = 1;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_date.Location = new System.Drawing.Point(104, 91);
            this.dateTimePicker_date.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(172, 27);
            this.dateTimePicker_date.TabIndex = 2;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.CustomFormat = "HH:mm";
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_start.Location = new System.Drawing.Point(104, 124);
            this.dateTimePicker_start.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.ShowUpDown = true;
            this.dateTimePicker_start.Size = new System.Drawing.Size(81, 27);
            this.dateTimePicker_start.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Starttid:";
            // 
            // combobox_room
            // 
            this.combobox_room.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_room.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_room.FormattingEnabled = true;
            this.combobox_room.Location = new System.Drawing.Point(104, 204);
            this.combobox_room.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.combobox_room.Name = "combobox_room";
            this.combobox_room.Size = new System.Drawing.Size(235, 28);
            this.combobox_room.TabIndex = 5;
            this.combobox_room.Text = "Välj ett rum..";
            this.combobox_room.Enter += new System.EventHandler(this.Booking_Room_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rum / Sal:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 247);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Boka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Booking_Submit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bokad för:";
            // 
            // textBox_booked_for
            // 
            this.textBox_booked_for.Location = new System.Drawing.Point(105, 5);
            this.textBox_booked_for.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_booked_for.Name = "textBox_booked_for";
            this.textBox_booked_for.Size = new System.Drawing.Size(233, 27);
            this.textBox_booked_for.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 247);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Rensa form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Booking_Reset_Click);
            // 
            // dateTimePicker_stop
            // 
            this.dateTimePicker_stop.CustomFormat = "HH:mm";
            this.dateTimePicker_stop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_stop.Location = new System.Drawing.Point(104, 157);
            this.dateTimePicker_stop.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimePicker_stop.Name = "dateTimePicker_stop";
            this.dateTimePicker_stop.ShowUpDown = true;
            this.dateTimePicker_stop.Size = new System.Drawing.Size(81, 27);
            this.dateTimePicker_stop.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sluttid:";
            // 
            // BookingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listview_bookings);
            this.Controls.Add(this.dateTimePicker_stop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_booked_by);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.textBox_booked_for);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combobox_room);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BookingPanel";
            this.Size = new System.Drawing.Size(1233, 513);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listview_bookings;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label label1;
        private TextBox textBox_booked_by;
        private DateTimePicker dateTimePicker_date;
        private DateTimePicker dateTimePicker_start;
        private Label label2;
        private Label label3;
        private ComboBox combobox_room;
        private Label label4;
        private Button button1;
        private Label label5;
        private TextBox textBox_booked_for;
        private Button button2;
        private DateTimePicker dateTimePicker_stop;
        private Label label6;
    }
}
