using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Automation.Text;
using System.Windows.Forms;

namespace SceenshotTextRecognizer
{
    internal class Server : IDisposable
    {
        public Server(Form form)
        {
            _form = form;
        }

        private readonly Form _form;

        private Thread _thread;
        private Socket _listenSocket;

        public void StartServer()
        {
            _thread = new Thread(() =>
            {
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8005);
                _listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    _listenSocket.Bind(ipPoint);
                    _listenSocket.Listen(10);

                    while (true)
                    {
                        var handler = _listenSocket.Accept();
                        var builder = new StringBuilder();
                        int bytes = 0;
                        byte[] data = new byte[256];

                        do
                        {
                            bytes = handler.Receive(data);
                            builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                        }
                        while (handler.Available > 0);

                        string message = builder.ToString();

                        handler.Shutdown(SocketShutdown.Both);
                        handler.Close();

                        if (message == "show")
                        {
                            _form.Invoke((MethodInvoker)delegate () { _form.Show(); });
                        }
                    }
                }
                catch { }
            })
            {
                IsBackground = true
            };
            _thread.Start();
        }

        public void Dispose()
        {
            _listenSocket.Close();
            _listenSocket = null;
            _thread.Abort();
            _thread = null;
        }
    }
}