using Newtonsoft.Json;
using System.IO;
using SceenshotTextRecognizer.Data.Setting;
using System.Windows.Forms;

namespace SceenshotTextRecognizer.Data
{
    public class Config
    {
        public static Config config;

        public Keys bind = Keys.RShiftKey;
        public bool showOnOtherWindows;
        public bool workInFon;
        public bool autoUpload;
        public SelectArea selectArea = new SelectArea();
        public ScanResult scanResult = new ScanResult();

        public static void Load()
        {
            if (File.Exists(@"data\settings.json"))
            {
                string stringJson = File.ReadAllText(@"data\settings.json");
                Config config = JsonConvert.DeserializeObject<Config>(stringJson);

                Config.config = config;
            }
            else
            {
                config = new Config();
                Save();
            }
        }

        public static void Save()
        {
            using (StreamWriter streamWriter = new StreamWriter(@"data\settings.json"))
            {
                string stringJson = JsonConvert.SerializeObject(config);

                streamWriter.Write(stringJson);
                streamWriter.Close();
            }
        }
    }
}
