using InquiryUserAddress.AppCode;
using System;
using System.ServiceProcess;
using UpdateCity.Agetn.AppCode;

namespace InquiryUserAddress
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            LogSyetem.Log("**Start Inquiry city addres agent **");

            if (Environment.UserInteractive)
                StartInConsoleMode();
            else
                RunInquiryWinService();
        }

        private static void StartInConsoleMode()
        {
            Console.WriteLine("************* Start In Console Mode ***************");

            new WinService().StartInConsoleMode();

            Console.ReadLine();
        }

        private static  void RunInquiryWinService()
        {
            var servicesToRun = CreateServiceBase();

            ServiceBase.Run(servicesToRun);
        }

        private static ServiceBase[] CreateServiceBase()
        {
            return new ServiceBase[]
            {
                new WinService()
            };
        }
    }
}
