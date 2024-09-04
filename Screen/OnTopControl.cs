using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace SceenshotTextRecognizer.Utils
{
    public class OnTopControl : IDisposable
    {
        private Thread _thread;

        [DllImport("user32.dll")]
        public static extern bool BringWindowToTop(IntPtr hWnd);

        public OnTopControl(IntPtr intPtrControl)
        {
            _thread = new Thread(() =>
            {
                try
                {
                    using (Mutex mutex = new Mutex(false, "B0F8707FA1E54755B2DB83A0FE31216C"))
                        while (true)
                        {
                            try
                            {
                                if (mutex.WaitOne(Timeout.Infinite, false))
                                {
                                    BringWindowToTop(intPtrControl);
                                    mutex.ReleaseMutex();
                                }
                            }
                            catch { }
                        }
                }
                catch (ThreadAbortException) { }
            })
            {
                IsBackground = true
            };
            _thread.Start();
        }

        public void Dispose()
        {
            _thread.Abort();
            _thread = null;
        }
    }
}