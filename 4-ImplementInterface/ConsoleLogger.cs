using System;
using System.Collections.Generic;
using System.Text;

namespace _4_ImplementInterface
{
    static class ConsoleLogger
    {
        /// <summary>
        /// Write Log In Console
        /// </summary>
        /// <param name="message">message to write</param>
        public static void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
