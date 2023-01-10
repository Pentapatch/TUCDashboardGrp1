using System.Diagnostics;
using System.Xml.Serialization;
using TUCDashboardGrp1.Controller;

namespace TUCDashboardGrp1.Model
{
    public class LocalStorage
    {
        #region Fields
        readonly string directoryPath = @$"{Application.UserAppDataPath}\Settings";

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
        #endregion

        #region Props
        public XmlLocalStorage Storage { get => dataStorage; }

        public Settings Settings { get => settings; }
        #endregion

        public static void Initialize() => instance ??= new();


        #region Functions
        private LocalStorage()
        {
            dataStorage = new();
            settings = new();

            // Create (if not existing already) a settings file
            // then load the settings to local storage
            CreateFile<Settings>(true);
            settings = ReadFile<Settings>(true);

            // Create (if not already existing) a data file
            // then load the data to local storage
            CreateFile<XmlLocalStorage>(false);
            dataStorage = ReadFile<XmlLocalStorage>(false);
        }


        private void Save<T>(bool isSettings)
        {
            if (File.Exists(GetCurrentPath(isSettings)))
            {
                using FileStream fs = File.Create(GetCurrentPath(isSettings));
                XmlSerializer writer = new(typeof(T));

                writer.Serialize(fs, isSettings ? settings : dataStorage);
            }
        }

        public void SaveSettings() => Save<Settings>(true);

        public void SaveData() => Save<XmlLocalStorage>(false);

        public void OpenInExplorer()
        {
            Process.Start("explorer.exe", directoryPath);
        }

        private string GetSettingsPath() => $"{directoryPath}\\UserSettings.xml";

        // This will either return, the current dataPath or a default value
        private string GetDataPath() => settings.DataPath;

        // Returns the CurrentPath to either Data or Settings
        private string GetCurrentPath(bool isSettings) => isSettings ? GetSettingsPath() : GetDataPath();

        private void CreateFile<T>(bool isSettings)
        {
            // Get the path to the file (either data or settings)
            string filePath = GetCurrentPath(isSettings);

            // If the file or directory does not exist, create them.
            if (!File.Exists(filePath))
            {
                Directory.CreateDirectory(directoryPath);

                using FileStream fs = File.Create(filePath);
                XmlSerializer writer = new(typeof(T));

                writer.Serialize(fs, isSettings ? settings : dataStorage);
            }
        }

        private T ReadFile<T>(bool isSettings)
        {
            XmlSerializer reader = new(typeof(T));

            // Get the path to the file (either data or settings)
            string filePath = GetCurrentPath(isSettings);

            using StreamReader file = new(filePath);
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

        internal void ReLoad()
        {
            // Change the current DataFile to the new one, saved in Settings.xml
            dataStorage = ReadFile<XmlLocalStorage>(false);

            GlobalTimer.Instance.Refresh();
        }

        #endregion
    }

}