using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SceenshotTextRecognizer
{
    internal class Server
    {
        public Server(Form form)
        {
            _form = form;
        }

        private readonly Form _form;

        // Ссылка на экземпляр класса потока
        private Thread _thread;
        // Ссылка на экземпляр класса сервера
        private Socket _listenSocket;

        // Айпи сервера
        private string _ip = "127.0.0.1";
        // Порт сервера
        private int _port = 8005;

        // Запуск сервера
        public void StartServer()
        {
            //Сервер в новом потоке
            _thread = new Thread(() =>
            {
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(_ip), _port);
                _listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    _listenSocket.Bind(ipPoint);
                    _listenSocket.Listen(10);

                    while (true)
                    {
                        Socket handler = _listenSocket.Accept();
                        StringBuilder builder = new StringBuilder();
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

                        //Открыть форму при получении сообщения "show"
                        if (message == "show")
                            _form.Invoke((MethodInvoker)delegate () { _form.Show(); });
                    }
                }
                catch { }
            })
            {
                IsBackground = true
            };
            //Запуск потока
            _thread.Start();
        }

        // Отчистить данные, занятые классом
        public void Dispose()
        {
            _listenSocket.Close();
            _thread.Abort();
        }
    }
}