using CustomExtensions;
using System;

namespace ExtensionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            "This is a demo".PrintToConsole();

            ISimpleLogger logger = new SimpleLogger();
            logger.Log("Test Error", "ERror");
            logger.LogError("This is an error");
            logger.LogWarning("This is a warning.");
            Console.WriteLine("Goodbye");

            // person.Print().LogInfo().SaveToDatabase(myDBConnection);
            // SaveToDatabase(LogInfo(Print(Person)));
        }
    }

    public static class ExtendSimpleLogger
    {
        public static void LogError(this ISimpleLogger logger, string message)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            logger.Log(message, "Error");
            Console.ForegroundColor = defaultColor;
        }

        public static void LogWarning(this ISimpleLogger logger, string message)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            logger.Log(message, "Warning");
            Console.ForegroundColor = defaultColor;
        }
    }

    public class SimpleLogger : ISimpleLogger
    {
        public void Log(string message)
        {
            System.Console.WriteLine(message);
        }

        public void Log(string message, string messageType)
        {
            Log($"{messageType}: {message}");
        }
    }
}
