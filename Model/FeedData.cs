using System.Xml;
using System.Xml.Serialization;

namespace TUCDashboardGrp1.Model
{

    public class FeedData
    {
        private string? header;
        private string? content;
        private string? imagePath;

        public string? Header
        {
            get => header;
            set
            {
                if (value != null && value.Length > 50) throw new Exception("Värdet får inte vara över 50 tecken.");
                header = value;
            }
        }

        public string? Content
        {
            get => content;
            set
            {
                if (value != null && value.Length > 400) throw new Exception("Värdet får inte vara över 400 tecken.");
                content = value;
            }
        }

        [XmlIgnore]
        public Image? Image
        {
            get
            {
                if (imagePath != null && imagePath != "")
                {
                    try
                    {
                        return new Bitmap(imagePath);
                    }
                    catch (Exception)
                    {
                        XMLImage = "";
                    }
                }
                return null;
            }
        }

        [XmlElement("ImagePath")]
        public string? XMLImage
        {
            get => imagePath;
            set => imagePath = value;
        }

    }

}