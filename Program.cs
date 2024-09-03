using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using SceenshotTextRecognizer.Data;
using main = SceenshotTextRecognizer.Data.Main;

namespace SceenshotTextRecognizer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Process thisProcess = Process.GetCurrentProcess();
            List<Process> processes = Process.GetProcessesByName(thisProcess.ProcessName).ToList();

            bool anyProcess = processes.Any(item => item.Id != thisProcess.Id);

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
                main.Load();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new GUI.FormMain());
            }
        }
    }
}
