using System.Diagnostics;
using System.Xml.Serialization;

namespace TUCDashboardGrp1.Model
{
    public class LocalStorage
    {

        private string pathToStorage = string.Empty;
        private string pathToSettings = string.Empty;
        private string directoryPath = string.Empty;


        private XmlLocalStorage dataStorage;
        private Settings settings;

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

        public XmlLocalStorage Storage { get => dataStorage; }

        public Settings Settings { get => settings; }

        private LocalStorage()
        {
            dataStorage = new();
            settings = new();

            CreateFile<XmlLocalStorage>(dataStorage, "AppData1", "Settings");
            CreateFile<Settings>(settings, "UserSettings", "Settings");

            dataStorage = ReadFile<XmlLocalStorage>(dataStorage);
            settings = ReadFile<Settings>(settings);
        }

        internal void Save<T>()
        {
            if (File.Exists(pathToStorage))
            {
                using FileStream fs = File.Create(pathToStorage);
                XmlSerializer writer = new(typeof(T));

                writer.Serialize(fs, dataStorage);
            }
        }

        public void OpenInExplorer()
        {
            Process.Start("explorer.exe", directoryPath);
        }

        private void CreateFile<T>(T source, string fileName, string directoryName = "Settings")
        {
            directoryPath = @$"{Application.UserAppDataPath}\{directoryName}";

            string path = @$"{directoryPath}\{fileName.Trim().Replace(".xml", "")}.xml";

            if (source is XmlLocalStorage)
            {
                pathToStorage = path;
            } else if (source is Settings) {
                pathToSettings = path;
            }

            // Create a blank file if none exists
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(directoryPath);

                using FileStream fs = File.Create(path);
                XmlSerializer writer = new(typeof(T));

                writer.Serialize(fs, source);
            }
        }

        private T ReadFile<T>(T obj)
        {
            XmlSerializer reader = new(typeof(T));

            string path = "";

            if (obj is XmlLocalStorage)
            {
                path = pathToStorage;
            }
            else if (obj is Settings)
            {
                path = pathToSettings;
            }


            using StreamReader file = new(path);
            try
            {
                return (T)reader.Deserialize(file)!;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error when reading XML file:\n{e.Message}", DashboardForm.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                // TODO: Error management
                throw;
            }
        }

    }

}