﻿using System;
using System.IO;
using System.Windows.Forms;

using SceenshotTextRecognizer.GUI;

using SceenshotTextRecognizer.Data;

namespace SceenshotTextRecognizer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            bool anyProcess = ProcessesFinder.Find();

            if (anyProcess)
            {
                Server.SendMessage("show");
            }
            else
            {
                if (!Directory.Exists("tessdata")) Directory.CreateDirectory("tessdata");
                if (!Directory.Exists("data")) Directory.CreateDirectory("data");

                Model.Load();
                CombinationLanguagePacks.Load();
                Config.Load();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
        }
    }
}
