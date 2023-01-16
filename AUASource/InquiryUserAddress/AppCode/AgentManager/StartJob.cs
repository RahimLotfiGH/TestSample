using Quartz;

namespace InquiryUserAddress.AppCode.AgentManager
{
    public class StartJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            new InqueryAddress().Run();
        }
    }
}
