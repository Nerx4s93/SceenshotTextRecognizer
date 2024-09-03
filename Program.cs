﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
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
            Process thisP = Process.GetCurrentProcess();
            List<Process> processes = Process.GetProcessesByName(thisP.ProcessName).ToList();

            bool anyProcess = processes.Any(item => item.Id != thisP.Id);

            if (anyProcess)
            {
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8005);

                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.SendTimeout = 100;
                socket.Connect(ipPoint);

                if (socket.Connected)
                {
                    string message = "show";
                    byte[] data = Encoding.Unicode.GetBytes(message);
                    socket.Send(data);

                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                }
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
