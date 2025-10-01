using System;

namespace Okc_HomeWrk6
{
    static class Logger
    {
        private static readonly DateTime _startTime;

        static Logger()
        {
            _startTime = DateTime.Now;
            Console.WriteLine($"Logger started at {_startTime}");
        }

        public static void Log(string msg)
        {
            Console.WriteLine($"[{DateTime.Now}] {msg}");
        }
    }
}
