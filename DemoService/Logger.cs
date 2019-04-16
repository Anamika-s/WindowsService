using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoService
{
   public static class Logger
    {
        public static void WriteToLog(string Message)
        {
            StreamWriter sw = null;
            try
            {
                string Date = System.DateTime.Now.ToString("dd-mm-yyyy");
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFolder\\DemoService" + Date + ".txt", true);
                sw.Write(DateTime.Now.ToString() + " : " + Message);
                sw.Flush();
                sw.Close();
            }
            catch (Exception ex) { }
            }
    }
}
