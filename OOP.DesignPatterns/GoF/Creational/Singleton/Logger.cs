using System;
using System.IO;

namespace OOP.DesignPatterns.GoF.Creational.Singleton
{
    // not threadsafe
    public class Logger
    {
        private string _logPath;

        private Logger(string logPath)
        {
            _logPath = logPath;
        }

        public static Logger Instance { get; private set; }

        public static void Initialize(string logPath)
        {
            if (Instance == null)
                Instance = new Logger(logPath);
        }

        public void Log(string message)
        {
            using (var fs = new FileStream(_logPath, FileMode.Append))
            using (var sw = new StreamWriter(fs))
            {
                sw.WriteLine($"{DateTime.Now} - {message}");
            }
        }
    }
}
