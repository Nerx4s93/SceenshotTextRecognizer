using System.IO;
using System.Windows.Forms;

using SceenshotTextRecognizer.Data.Setting;

using Newtonsoft.Json;

namespace SceenshotTextRecognizer.Data
{
    public class Config
    {
        public Keys bind = Keys.RShiftKey;
        public bool showOnOtherWindows;
        public bool workInFon;
        public bool autoUpload;
        public SelectArea selectArea = new SelectArea();
        public ScanResult scanResult = new ScanResult();

        public static void Load(out Config config)
        {
            if (File.Exists(@"data\settings.json"))
            {
                string stringJson = File.ReadAllText(@"data\settings.json");
                config = JsonConvert.DeserializeObject<Config>(stringJson);
            }
            else
            {
                config = new Config();
                Save(config);
            }
        }

        public static void Save(Config config)
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
