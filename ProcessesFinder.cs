using System.Diagnostics;
using System.Linq;

namespace SceenshotTextRecognizer
{
    internal static class ProcessesFinder
    {
        public static bool Find()
        {
            var thisProcess = Process.GetCurrentProcess();
            var processes = Process.GetProcessesByName(thisProcess.ProcessName).ToList();

            bool anyProcess = processes.Any(item => item.Id != thisProcess.Id);
            return anyProcess;
        }
    }
}
