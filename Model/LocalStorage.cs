using System.Xml.Serialization;

namespace TUCDashboardGrp1.Model
{
    public class LocalStorage
    {

        private string path = string.Empty;
        private string directoryPath = string.Empty;

        private XmlLocalStorage value;

        private static LocalStorage? instance = null;

        public static LocalStorage Instance
        {
            get
            {
                instance ??= new();
                return instance;
            }
        }

        public static void Initialize() => instance ??= new();

        public XmlLocalStorage Value { get => value; }

        public LocalStorage()
        {
            value = new();

            CreateFile("AppData1", "Settings");

            ReadFile();

            Save();

        }

        internal void Save()
        {
            if (File.Exists(path))
            {
                using FileStream fs = File.Create(path);
                XmlSerializer writer = new(typeof(XmlLocalStorage));

                writer.Serialize(fs, value);
            }
        }

        private void CreateFile(string fileName, string directoryName = "Settings")
        {
            directoryPath = @$"{Application.UserAppDataPath}\{directoryName}";
            path = @$"{directoryPath}\{fileName.Trim().Replace(".xml", "")}.xml";

            // Create a blank file if none exists
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(directoryPath);

                using FileStream fs = File.Create(path);
                XmlSerializer writer = new(typeof(XmlLocalStorage));

                writer.Serialize(fs, value);
            }
        }

        private void ReadFile()
        {
            XmlSerializer reader = new(typeof(XmlLocalStorage));

            using StreamReader file = new(path);
            try
            {
                XmlLocalStorage ls = (XmlLocalStorage)reader.Deserialize(file)!;
                value = ls;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error when reading XML file:\n{e.Message}", "TUC Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // TODO: Error management
                throw;
            }
        }

    }

}