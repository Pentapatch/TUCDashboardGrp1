using TUCDashboardGrp1.Model;
using TUCDashboardGrp1.Properties;
using TUCDashboardGrp1.Controller;

namespace TUCDashboardGrp1
{
    public partial class FeedWidget : Widget
    {

        // ############
        // ## FIELDS ##
        // ############

        #region Fields

        private FeedData? data = null;
        private int currentSlide = -1;
        private List<FeedData> feedData = new();

        #endregion

        // ################
        // ## PROPERTIES ##
        // ################

        #region Properties

        /// <summary>
        /// Get the feed that is currently shown. Use <see cref="SetFeed(List{FeedData})"/> to update the feed.
        /// </summary>
        public IReadOnlyList<FeedData> Feed
        {
            get => feedData.AsReadOnly();
        }

        #endregion

        // ##################
        // ## CONSTRUCTORS ##
        // ##################

        #region Constructors

        public FeedWidget()
        {
            InitializeComponent(); // <-- Don't touch

            // Add dummy feeds
            List<FeedData> newFeed = new();
            newFeed.Add(new() { Header = "Enbart en header" });
            newFeed.Add(new() { Header = "Header + Content", Content = "En fin text" });
            newFeed.Add(new() { Header = "Header + Content + Image", Content = "En fin bildtext en fin bildtext en fin bildtext en fin bildtext en fin bildtext en fin bildtext en fin bildtext", Image = Resources._1 });
            newFeed.Add(new() { Header = "En regning dag", Image = Resources._9 });
            newFeed.Add(new() { Content = "En ensam ledsen body-text" });
            newFeed.Add(new() { Content = "Body-text + bild", Image = Resources._22 });
            newFeed.Add(new() { Image = Resources._13 });

            SetFeed(newFeed);

            // Subscribe to timer event
            GlobalTimer.Instance!.Tick10Seconds += Refresher_Tick;
            GlobalTimer.Instance!.RefreshWidget += Refresher_Tick;

            // Subscribe to form event
            Resize += FeedWidget_Resize;
        }

        #endregion

        // ####################
        // ## PUBLIC METHODS ##
        // ####################

        #region Public methods

        public void SetFeed(List<FeedData> feed)
        {
            feedData = feed;
            UpdateSlide();
        }

        #endregion

        // #####################
        // ## PRIVATE METHODS ##
        // #####################

        #region Private methods

        private void UpdateSlide()
        {
            // Go to the next slide
            NextSlide();

            // Set the layout
            SetLayout();
        }

        private void SetLayout()
        {
            // Populate the controls with values
            if (data == null)
            {
                label_header.Text = "";
                label_content.Text = "";
                picture.Image = null;
                label_header.Visible = false;
                label_content.Visible = false;
                picture.Visible = false;
                return;
            }

            label_header.Text = data.Header;
            label_content.Text = data.Content;
            picture.Image = data.Image;

            // Set control visibility
            label_header.Visible = data.Header != "";
            label_content.Visible = data.Content != "";
            picture.Visible = data.Image != null;

            // Organize the controls based on the contents of the current slide data

            int minimum = (BorderRadius / 3) + BorderWidth;

            // Position the header
            int headerTop = minimum;
            label_header.Left = (Width / 2) - (label_header.Width / 2);
            label_header.MaximumSize = new(Width - (BorderRadius * 2) - 10, Height / 3);

            // Position the image and content
            int bodyTop = data.Header != "" ? headerTop + label_header.Height + 20 : headerTop;
            picture.Top = bodyTop;
            label_content.Top = bodyTop;

            picture.Left = minimum;
            label_content.Left = picture.Right + 10;

            picture.Width = (Width - (minimum * 2)) / 2;

            // CASE: content is null -> expand picture right
            if (data.Content == "") picture.Width = Width - picture.Left - minimum;

            // CASE: image is null -> move content left (and expand right)
            if (data.Image == null) label_content.Left = minimum;

            label_content.Width = Width - label_content.Left - minimum;

            // CASE: image and content is null -> center header vertically
            if (data.Image == null && data.Content == "")
                headerTop = (Height / 2) - (label_header.Height / 2) - 10;

            // Adjust body size
            label_content.Height = Height - label_content.Top - BorderWidth - 10;
            picture.Height = Height - picture.Top - minimum;

            label_header.Top = headerTop;
        }

        private void NextSlide()
        {
            // Early exit if there is no slides
            if (Feed.Count == 0)
            {
                data = null;
                currentSlide = -1;
                return;
            }

            // Increment the current slide and wrap arround to the beginning if the end is reached
            if (++currentSlide >= Feed.Count)
                currentSlide = 0;

            // Set the current data that we will be working on
            data = Feed[currentSlide];
        }

        private void FeedWidget_Resize(object? sender, EventArgs e) => SetLayout();

        private void Refresher_Tick(object? sender, EventArgs e) => UpdateSlide();

        #endregion

    }

}