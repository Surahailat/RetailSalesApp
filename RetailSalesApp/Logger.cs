using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RetailSalesApp
{

    public static class Logger
    {
        public static void Log(string message)
        {
            File.AppendAllText("AppLogs.txt", $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}{Environment.NewLine}");
        }
    }


}
