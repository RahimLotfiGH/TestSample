using Quartz;
using Quartz.Impl;
using System;
using UpdateCity.Agetn.AppCode;

namespace InquiryUserAddress.AppCode.AgentManager
{
    public class SchedulerAgent
    {
        private readonly IScheduler _scheduler;

        public SchedulerAgent()
        {
            _scheduler = new StdSchedulerFactory().GetScheduler();
        }

        public void Scheduler()
        {
            SchedulerStartAgent();

           
        }


        private void SchedulerStartAgent()
        {
            var jobStart = CreateStartJob();

            var triggerStart = CreateStartTriggerBuilder();

            _scheduler.ScheduleJob(jobStart, triggerStart);
        }
        public void Start()
        {
            _scheduler.Start();
        }


        private static IJobDetail CreateStartJob()
        {
            return JobBuilder.Create<StartJob>()
                             .WithIdentity("_InqueryStart")
                             .Build();
        }

        private static ITrigger CreateStartTriggerBuilder()
        {
            return TriggerBuilder.Create()
                                 .WithIdentity("_IdentityStartjob")
                                 .StartNow()
                                 .WithCronSchedule(GetAgentStartTime())
                                 .Build();
        }

        private static string GetAgentStartTime()
        {
            // ToDo :Get from config file
            //0 * * ? * *

            return "0 * * ? * *";//"0 */10 * ? * *";
        }

     

        public void Stop()
        {
            try
            {
                TryStop();
            }
            catch (Exception exception)
            {
                AddLog("Stop in Inquiry> ", exception);
            }
        }

        public void TryStop()
        {
            _scheduler.Shutdown(true);
        }

        private static void AddLog(string title, Exception exception)
        {
            LogSyetem.Log(title, exception.Message);
        }

        public void Execute(JobExecutionContextImpl executionContextImpl)
        {
            new StartJob()
                     .Execute(executionContextImpl);
        }
    }
}