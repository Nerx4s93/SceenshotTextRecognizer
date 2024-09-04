using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;

namespace SceenshotTextRecognizer.Data
{
    public class CombinationLanguagePacks
    {
        public CombinationLanguagePacks()
        {

        }

        public CombinationLanguagePacks(string name, List<string> models)
        {
            this.name = name;
            this.models = models;
        }

        public string name;
        public List<string> models = new List<string>();

        public static List<CombinationLanguagePacks> combinationLanguagePacks;

        public static void Load()
        {
            string path = "data\\CombinationLanguagePacks.json";

            if (!File.Exists(path))
            {
                combinationLanguagePacks = new List<CombinationLanguagePacks>();
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    streamWriter.Write("[]");
                    streamWriter.Close();
                }
            }
            else
            {
                using(StreamReader streamReader = new StreamReader(path))
                {
                    combinationLanguagePacks = JsonConvert.DeserializeObject<List<CombinationLanguagePacks>>(streamReader.ReadToEnd());
                    streamReader.Close();
                }
            }
        }
        public static void Save()
        {
            using (StreamWriter streamWriter = new StreamWriter("data\\CombinationLanguagePacks.json"))
            {
                streamWriter.Write(JsonConvert.SerializeObject(combinationLanguagePacks));
                streamWriter.Close();
            }
        }

        public override string ToString()
        {
            return string.Join("+", models);
        }
    }
}
