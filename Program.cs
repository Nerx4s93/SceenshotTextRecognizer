using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using SceenshotTextRecognizer.GUI;
using System.Linq;
using SceenshotTextRecognizer.Data;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace SceenshotTextRecognizer
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            //Получение всех процессов ПК
            string runningProcess = Process.GetCurrentProcess().ProcessName;
            List<Process> processes = Process.GetProcessesByName(runningProcess).ToList();

            //Удаление из списка процессов данный процесс
            for (int i = 0; i != processes.Count; i++)
                if (processes[i].ProcessName == runningProcess)
                {
                    processes.Remove(processes[i]);
                    break;
                }

            if (processes.Count == 1)
            {
                //Если остался 1 прцоесс, то отправить сокет сообщение об открытии формы
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8005);

                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.SendTimeout = 100;
                socket.Connect(ipPoint);

                if (socket.Connected == true)
                {
                    string message = "show";
                    byte[] data = Encoding.Unicode.GetBytes(message);
                    socket.Send(data);

                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                }
            }
            else if (processes.Count == 0)
            {
                //Если осталось 0 процессов, то запустить программу

                //Проверка директорий
                if (!Directory.Exists("tessdata")) Directory.CreateDirectory("tessdata");
                if (!Directory.Exists("data")) Directory.CreateDirectory("data");

                //Загрузка конфигов
                Model.Load();
                CombinationLanguagePacks.Load();

                //Открытие формы
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
        }
    }
}
