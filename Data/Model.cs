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

        // Имя модели
        public readonly string name;
        // Обозначение модели
        public readonly string model;
        // Ссылка на модель
        public readonly string url;

        // Все доступные модели
        public static readonly List<Model> models = new List<Model>()
        {
            new Model("Русский", "rus", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=100UgP7h1LHC7ZMBSik7f-5ABTjEBdBvJ"),
            new Model("Английский", "eng", "https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1WmTaDMxf8c7LQjY0LJrhyLkoniaeueNJ")
        };

        // Модели, которые можно скачать
        public static List<Model> CanDownload = new List<Model>();
        // Скачанные модели
        public static List<Model> Downloaded = new List<Model>();

        // Загрузка языковыъ моделий
        public static void Load()
        {
            //Отчистить листы
            CanDownload.Clear();
            Downloaded.Clear();

            //Добавить элементы в листы
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
