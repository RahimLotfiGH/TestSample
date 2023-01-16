using System.IO;

namespace UpdateCity.Agetn.AppCode
{
    public static class LogSyetem
    {

        public static void Log(string title, string message)
        {
            File.AppendAllText("log.txt", title + " : " + message);
        }
        public static void Log(string message)
        {
            File.AppendAllText("log.txt", message);
        }

    }
}
