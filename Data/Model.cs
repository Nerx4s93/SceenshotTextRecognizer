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
            new Model("Английский", "eng", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1WmTaDMxf8c7LQjY0LJrhyLkoniaeueNJ"),
            new Model("Украинский", "ukr", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1TfbEaomZDRD9kEImdIGy79k0jBwgSxLm"),
            new Model("Француский", "fra", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1jacOGJ94duJ_IJRIOLB5Qcrar5lKiMMM"),
            new Model("Испанский", "spa", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1g0rxgc9gLxQI-vAq743TfVMyun1OT2Og"),
            new Model("Испанский (старый)", "spa_old", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1kuUSnPeke_0zWryugNpY-4ZPOaRjuKpM"),
            new Model("Итальянский", "ita", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1Pxu0sW9dpFcnVvolOeCDZbZSkpAkQdLy"),
            new Model("Итальянский (старый)", "ita_old", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1JomEg9l4afNrh3xl6XQYcflYLeSeKDVA"),
            new Model("Португальский", "por", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1YKoi80zPz1OXw6Os_f4oaKcgJ9--GBPi"),
            new Model("Японский", "jpn", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1KdghnlHigU39Idge1lzd0_kCQf655pHD"),
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
