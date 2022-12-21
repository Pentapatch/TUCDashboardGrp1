namespace TUCDashboardGrp1.Model
{
    public class FeedData
    {
        private string header = string.Empty;
        private string content = string.Empty;

        public string Header
        {
            get => header;
            set
            {
                if (value.Length > 50) throw new Exception("Värdet får inte vara över 50 tecken.");
                header = value;
            }
        }

        public string Content
        {
            get => content;
            set
            {
                if (value.Length > 400) throw new Exception("Värdet får inte vara över 400 tecken.");
                content = value;
            }
        }

        public Image? Image { get; set; } = null;

    }

}