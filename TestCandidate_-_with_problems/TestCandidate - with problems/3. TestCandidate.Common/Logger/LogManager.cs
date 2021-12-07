using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace TestCandidate.Logger
{
    public static class LogManager
    {
        public static void WriteToLog(string message)
        {
            // Do not delete!
            log4net.ILog log;

            string textToLog = string.Format("{0}\t{1}", DateTime.Now, message);
            // Do something ... 
        }
    }
}
