using System.IO;
using System.Windows.Forms;

using SceenshotTextRecognizer.Data.Setting;

using Newtonsoft.Json;

namespace SceenshotTextRecognizer.Data
{
    public class Settings
    {
        public Keys bind = Keys.RShiftKey;
        public bool showOnOtherWindows;
        public bool workInFon;
        public bool autoUpload;
        public SelectArea selectArea = new SelectArea();
        public ScanResult scanResult = new ScanResult();

        public static void Load(out Settings config)
        {
            if (File.Exists(@"data\settings.json"))
            {
                string stringJson = File.ReadAllText(@"data\settings.json");
                config = JsonConvert.DeserializeObject<Settings>(stringJson);
            }
            else
            {
                config = new Settings();
                Save(config);
            }
        }

        public static void Save(Settings config)    
        {
            using (var streamWriter = new StreamWriter(@"data\settings.json"))
            {
                string stringJson = JsonConvert.SerializeObject(config);

                streamWriter.Write(stringJson);
                streamWriter.Close();
            }
        }
    }
}
