using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

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

        // Имя языковой комбинаций
        public string name;
        // Модели, используемые в языковой комбинации
        public List<string> models = new List<string>();

        // Созданные языковые комбинации
        public static List<CombinationLanguagePacks> combinationLanguagePacks;

        // Загрузка языковых комбинаций
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

        // Сохранение языковых комбинаций
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
