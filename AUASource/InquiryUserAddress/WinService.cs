using InquiryUserAddress.AppCode.AgentManager;
using System;
using System.ServiceProcess;

namespace InquiryUserAddress
{
    partial class WinService : ServiceBase
    {
        private readonly SchedulerAgent _schedulerAgent;

        public WinService()
        {
            _schedulerAgent = new SchedulerAgent();
            
            _schedulerAgent.Scheduler();

            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _schedulerAgent.Start();
        }

        protected override void OnStop()
        {
            _schedulerAgent.Stop();

            Dispose();
        }
        
        public void StartInConsoleMode()
        {
            _schedulerAgent.Start();
        }
    }
}
