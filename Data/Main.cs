using Newtonsoft.Json;
using System.IO;
using SceenshotTextRecognizer.Data.Setting;
using System.Windows.Forms;

namespace SceenshotTextRecognizer.Data
{
    public class Main
    {
        public static Main main;

        public Keys bind = Keys.RShiftKey;
        public bool showOnOtherWindows;
        public bool workInFon;
        public SelectArea selectArea = new SelectArea();
        public ScanResult scanResult = new ScanResult();

        public static void Load()
        {
            if (File.Exists(@"data\settings.json"))
            {
                string stringJson = File.ReadAllText(@"data\settings.json");
                Main main = JsonConvert.DeserializeObject<Main>(stringJson);

                Main.main = main;
            }
            else
            {
                main = new Main();
                Save();
            }
        }

        public static void Save()
        {
            using (StreamWriter streamWriter = new StreamWriter(@"data\settings.json"))
            {
                string stringJson = JsonConvert.SerializeObject(main);

                streamWriter.Write(stringJson);
                streamWriter.Close();
            }
        }
    }
}
