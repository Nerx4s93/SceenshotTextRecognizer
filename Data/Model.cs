using System.Collections.Generic;
using System.IO;

namespace SceenshotTextRecognizer.Data
{
    public class Model
    {
        public readonly string Name;
        public readonly string Code;
        public readonly string Url;

        public Model(string name, string model, string url)
        {
            Name = name;
            Code = model;
            Url = url;
        }

        public static List<Model> CanDownload = new List<Model>();
        public static List<Model> Downloaded = new List<Model>();

        public static void Load()
        {
            CanDownload.Clear();
            Downloaded.Clear();

            foreach (Model model in models)
            {
                if (File.Exists(Path.Combine("tessdata", $"{model.Code}.traineddata")))
                    Downloaded.Add(model);
                else
                    CanDownload.Add(model);
            }
        }

        public static readonly Model[] models = new Model[18]
        {
            new Model("Русский", "rus", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=100UgP7h1LHC7ZMBSik7f-5ABTjEBdBvJ"),
            new Model("Английский", "eng", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1WmTaDMxf8c7LQjY0LJrhyLkoniaeueNJ"),
            new Model("Француский", "fra", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1jacOGJ94duJ_IJRIOLB5Qcrar5lKiMMM"),
            new Model("Испанский", "spa", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1g0rxgc9gLxQI-vAq743TfVMyun1OT2Og"),
            new Model("Итальянский", "ita", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1Pxu0sW9dpFcnVvolOeCDZbZSkpAkQdLy"),
            new Model("Португальский", "por", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1YKoi80zPz1OXw6Os_f4oaKcgJ9--GBPi"),
            new Model("Японский", "jpn", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1KdghnlHigU39Idge1lzd0_kCQf655pHD"),
            new Model("Немецкий", "deu", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=10d9qradXHqlitVQqjT8Gfx6br3SCJH4Q"),
            new Model("Финский", "fin", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1JSXl5LhJJPr27R5dZZ2zhI86h-l2aN59"),
            new Model("Шведский", "swe", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1H_X9dUOb7hX4CntChNB1XjN0MokBOkWj"),
            new Model("Норвежский", "nor", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1j9b-tBCvZsw9KzRSAzOA_Zkrlxxu0ObQ"),
            new Model("Датский", "dan", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1hjgTQdbnWXs6GssYkR1ODi597f_y5dpb"),
            new Model("Нидерландский", "nld", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1GLM6Mf84qGdE4jBQDyrrX7y8I7VhngSP"),
            new Model("Греческий", "ell", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1p7HgzO4n4_w27-c4TP899kkW2FHSYyZT"),
            new Model("Польский", "pol", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1j7TW-xIQSJNa7esFVYI2QAtfoMo6v4CV"),
            new Model("Чешский", "ces", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1x1LQn5GQtNTwDJZlJ_KW6aBjT_go-buy"),
            new Model("Словацкий", "slk", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1HwpjCbuWdq3VCqWkUlkGiBGGp6yJtqTq"),
            new Model("Ирландский", "gle", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=11joOlt1UIbEy7CcAY5S0Q_3SpTXSjF4k")
        };
    }
}
