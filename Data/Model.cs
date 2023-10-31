using System.Collections.Generic;
using System.IO;

namespace SceenshotTextRecognizer.Data
{
    public class Model
    {
        public Model(string name, string model, string url)
        {
            this.name = name;
            this.model = model;
            this.url = url;
        }

        public readonly string name;
        public readonly string model;
        public readonly string url;

        public static readonly List<Model> models = new List<Model>()
        {
            new Model("Русский", "rus", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=100UgP7h1LHC7ZMBSik7f-5ABTjEBdBvJ"),
            new Model("Английский", "eng", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1WmTaDMxf8c7LQjY0LJrhyLkoniaeueNJ")
        };

        public static List<Model> CanDownload = new List<Model>();
        public static List<Model> Downloaded = new List<Model>();

        public static void Load()
        {
            CanDownload.Clear();
            Downloaded.Clear();

            foreach (Model model in models)
            {
                if (File.Exists(Path.Combine("tessdata", $"{model.model}.traineddata")))
                    Downloaded.Add(model);
                else
                    CanDownload.Add(model);
            }
        }
    }
}
