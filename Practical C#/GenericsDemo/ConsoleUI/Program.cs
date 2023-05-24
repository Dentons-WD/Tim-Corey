using ConsoleUI.WithGenerics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> ages = new List<int>();

            //ages.Add(23);

            Console.ReadLine();

            DemonstrateTextFileStorage();

            Console.WriteLine();
            Console.Write("Press enter to shut down...");
            Console.ReadLine();
        }

        private static void DemonstrateTextFileStorage()
        {
            List<Person> people = new List<Person>();
            List<LogEntry> logs = new List<LogEntry>();

            string peopleFile = @"C:\Temp\people.csv";
            string logFile = @"C:\Temp\logs.csv";

            PopulateLists(people, logs);

            /* New way of doing things - generics */

            GenericTextFileProcessor.SaveToTextFile<Person>(people, peopleFile);
            GenericTextFileProcessor.SaveToTextFile<LogEntry>(logs, logFile);

            var newPeople = GenericTextFileProcessor.LoadFromTextFile<Person>(peopleFile);

            foreach (var p in newPeople)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName} (IsAlive = {p.IsAlive})");
            }

            var newLogs = GenericTextFileProcessor.LoadFromTextFile<LogEntry>(logFile);

            foreach (var log in newLogs)
            {
                Console.WriteLine($"{log.ErrorCode}: {log.Message} at {log.TimeOfEvent.ToShortTimeString()}");
            }

            /* Old way of doing things - non-generics */

            //OriginalTextFileProcessor.SaveLogs(logs, logFile);

            //var newLogs = OriginalTextFileProcessor.LoadLogs(logFile);

            //foreach (var log in newLogs)
            //{
            //    Console.WriteLine($"{ log.ErrorCode }: { log.Message } at { log.TimeOfEvent.ToShortTimeString() }");
            //}

            //OriginalTextFileProcessor.SavePeople(people, peopleFile);

            //var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFile);

            //foreach (var p in newPeople)
            //{
            //    Console.WriteLine($"{ p.FirstName } { p.LastName } (IsAlive = { p.IsAlive })");
            //}
        }

        private static void PopulateLists(List<Person> people, List<LogEntry> logs)
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Corey" });
            people.Add(new Person { FirstName = "Sue", LastName = "Storm", IsAlive = false });
            people.Add(new Person { FirstName = "Greg", LastName = "Olsen" });

            logs.Add(new LogEntry { Message = "I blew up", ErrorCode = 9999 });
            logs.Add(new LogEntry { Message = "I'm too awesome", ErrorCode = 1337 });
            logs.Add(new LogEntry { Message = "I was tired", ErrorCode = 2222 });
        }
    }
}
