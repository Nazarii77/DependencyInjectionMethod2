using System;
using static System.Console;

namespace DependencyInjectionMethod
{
    class Program
    {

        public interface ILogger
        {
            void LogInfo(String info);
        }

        public class TextLogger : ILogger
        {
            public void LogInfo(string info)
            {
                // Log data into a Text file.
                WriteLine(info);
            }
        }
        public class XMLLogger : ILogger
        {
            public void LogInfo(string info)
            {
                // Log data into a XML file.
                WriteLine(info);
            }
        }



        public class User
        {
            public void SaveData(ILogger loggerType)
            {
                loggerType.LogInfo($"Save data {loggerType}");
            }
        }
        static void Main(string[] args)
        {
            User _user = new User();

            _user.SaveData(new TextLogger());

            _user.SaveData(new XMLLogger());

        }
    }
}
