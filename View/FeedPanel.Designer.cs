namespace TUCDashboardGrp1
{
    partial class FeedPanel
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
            this.listview_feed = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btn_feed_clear = new System.Windows.Forms.Button();
            this.btn_feed_clearImage = new System.Windows.Forms.Button();
            this.btn_feed_submit = new System.Windows.Forms.Button();
            this.picturebox_feed_preview = new System.Windows.Forms.PictureBox();
            this.btn_feed_browseForImage = new System.Windows.Forms.Button();
            this.textbox_feed_content = new System.Windows.Forms.TextBox();
            this.textbox_feed_header = new System.Windows.Forms.TextBox();
            this.label_feed_img = new System.Windows.Forms.Label();
            this.label_feed_content = new System.Windows.Forms.Label();
            this.label_feed_header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_feed_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // listview_feed
            // 
            this.listview_feed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listview_feed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listview_feed.FullRowSelect = true;
            this.listview_feed.Location = new System.Drawing.Point(305, 2);
            this.listview_feed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listview_feed.Name = "listview_feed";
            this.listview_feed.Size = new System.Drawing.Size(731, 475);
            this.listview_feed.TabIndex = 23;
            this.listview_feed.UseCompatibleStateImageBehavior = false;
            this.listview_feed.View = System.Windows.Forms.View.Details;
            this.listview_feed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Feed_ListView_KeyDown);
            this.listview_feed.Leave += new System.EventHandler(this.Feed_ListView_Leave);
            this.listview_feed.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Feed_ListView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rubrik";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Innehåll";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bild";
            this.columnHeader3.Width = 400;
            // 
            // btn_feed_clear
            // 
            this.btn_feed_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_feed_clear.Location = new System.Drawing.Point(147, 455);
            this.btn_feed_clear.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_feed_clear.Name = "btn_feed_clear";
            this.btn_feed_clear.Size = new System.Drawing.Size(95, 22);
            this.btn_feed_clear.TabIndex = 21;
            this.btn_feed_clear.Text = "&Rensa form";
            this.btn_feed_clear.UseVisualStyleBackColor = true;
            this.btn_feed_clear.Click += new System.EventHandler(this.Feed_ClearForm_Click);
            // 
            // btn_feed_clearImage
            // 
            this.btn_feed_clearImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_feed_clearImage.Location = new System.Drawing.Point(147, 194);
            this.btn_feed_clearImage.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_feed_clearImage.Name = "btn_feed_clearImage";
            this.btn_feed_clearImage.Size = new System.Drawing.Size(95, 21);
            this.btn_feed_clearImage.TabIndex = 19;
            this.btn_feed_clearImage.Text = "R&ensa bild..";
            this.btn_feed_clearImage.UseVisualStyleBackColor = true;
            this.btn_feed_clearImage.Click += new System.EventHandler(this.Feed_ClearImage_Click);
            // 
            // btn_feed_submit
            // 
            this.btn_feed_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_feed_submit.Location = new System.Drawing.Point(63, 455);
            this.btn_feed_submit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_feed_submit.Name = "btn_feed_submit";
            this.btn_feed_submit.Size = new System.Drawing.Size(81, 22);
            this.btn_feed_submit.TabIndex = 20;
            this.btn_feed_submit.Text = "&Lägg till";
            this.btn_feed_submit.UseVisualStyleBackColor = true;
            this.btn_feed_submit.Click += new System.EventHandler(this.Feed_Submit_Click);
            // 
            // picturebox_feed_preview
            // 
            this.picturebox_feed_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picturebox_feed_preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picturebox_feed_preview.Location = new System.Drawing.Point(63, 217);
            this.picturebox_feed_preview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.picturebox_feed_preview.Name = "picturebox_feed_preview";
            this.picturebox_feed_preview.Size = new System.Drawing.Size(236, 236);
            this.picturebox_feed_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox_feed_preview.TabIndex = 22;
            this.picturebox_feed_preview.TabStop = false;
            // 
            // btn_feed_browseForImage
            // 
            this.btn_feed_browseForImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_feed_browseForImage.Location = new System.Drawing.Point(63, 194);
            this.btn_feed_browseForImage.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_feed_browseForImage.Name = "btn_feed_browseForImage";
            this.btn_feed_browseForImage.Size = new System.Drawing.Size(81, 21);
            this.btn_feed_browseForImage.TabIndex = 17;
            this.btn_feed_browseForImage.Text = "&Bläddra..";
            this.btn_feed_browseForImage.UseVisualStyleBackColor = true;
            this.btn_feed_browseForImage.Click += new System.EventHandler(this.Feed_BrowseForImage_Click);
            // 
            // textbox_feed_content
            // 
            this.textbox_feed_content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textbox_feed_content.Location = new System.Drawing.Point(63, 32);
            this.textbox_feed_content.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textbox_feed_content.Multiline = true;
            this.textbox_feed_content.Name = "textbox_feed_content";
            this.textbox_feed_content.Size = new System.Drawing.Size(237, 160);
            this.textbox_feed_content.TabIndex = 15;
            this.textbox_feed_content.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Feed_Textboxes_KeyDown);
            // 
            // textbox_feed_header
            // 
            this.textbox_feed_header.Location = new System.Drawing.Point(63, 2);
            this.textbox_feed_header.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textbox_feed_header.Name = "textbox_feed_header";
            this.textbox_feed_header.Size = new System.Drawing.Size(237, 23);
            this.textbox_feed_header.TabIndex = 13;
            this.textbox_feed_header.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Feed_Textboxes_KeyDown);
            // 
            // label_feed_img
            // 
            this.label_feed_img.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_feed_img.AutoSize = true;
            this.label_feed_img.Location = new System.Drawing.Point(6, 197);
            this.label_feed_img.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_feed_img.Name = "label_feed_img";
            this.label_feed_img.Size = new System.Drawing.Size(30, 15);
            this.label_feed_img.TabIndex = 18;
            this.label_feed_img.Text = "Bild:";
            // 
            // label_feed_content
            // 
            this.label_feed_content.AutoSize = true;
            this.label_feed_content.Location = new System.Drawing.Point(6, 32);
            this.label_feed_content.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_feed_content.Name = "label_feed_content";
            this.label_feed_content.Size = new System.Drawing.Size(52, 15);
            this.label_feed_content.TabIndex = 16;
            this.label_feed_content.Text = "&Innehåll:";
            // 
            // label_feed_header
            // 
            this.label_feed_header.AutoSize = true;
            this.label_feed_header.Location = new System.Drawing.Point(6, 6);
            this.label_feed_header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_feed_header.Name = "label_feed_header";
            this.label_feed_header.Size = new System.Drawing.Size(44, 15);
            this.label_feed_header.TabIndex = 14;
            this.label_feed_header.Text = "R&ubrik:";
            // 
            // FeedPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.listview_feed);
            this.Controls.Add(this.btn_feed_clear);
            this.Controls.Add(this.btn_feed_clearImage);
            this.Controls.Add(this.btn_feed_submit);
            this.Controls.Add(this.picturebox_feed_preview);
            this.Controls.Add(this.btn_feed_browseForImage);
            this.Controls.Add(this.textbox_feed_content);
            this.Controls.Add(this.textbox_feed_header);
            this.Controls.Add(this.label_feed_img);
            this.Controls.Add(this.label_feed_content);
            this.Controls.Add(this.label_feed_header);
            this.Name = "FeedPanel";
            this.Size = new System.Drawing.Size(1039, 479);
            this.Resize += new System.EventHandler(this.FeedPanel_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_feed_preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listview_feed;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btn_feed_clear;
        private Button btn_feed_clearImage;
        private Button btn_feed_submit;
        private PictureBox picturebox_feed_preview;
        private Button btn_feed_browseForImage;
        private TextBox textbox_feed_content;
        private TextBox textbox_feed_header;
        private Label label_feed_img;
        private Label label_feed_content;
        private Label label_feed_header;
    }
}
