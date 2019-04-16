using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DemoService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        Timer timer = new Timer();
        protected override void OnStart(string[] args)
        {
            timer.Interval = 1000;
            timer.Elapsed += new ElapsedEventHandler(timer_tick);
            this.timer.Enabled = true;
            Logger.WriteToLog("Demo Service started .... ");
        }

        private void timer_tick(object sender, ElapsedEventArgs e)
        {

            Logger.WriteToLog("Timer ticked .... ");
            Logger.WriteToLog("Successful");
        }
    

        protected override void OnStop()
        {
            Logger.WriteToLog("Service is about to close");
            timer.Stop();
            timer = null;
            Logger.WriteToLog("Service is shutdown by user");
        }
    }
}
