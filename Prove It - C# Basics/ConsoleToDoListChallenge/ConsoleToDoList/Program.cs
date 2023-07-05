using System;
using System.Collections.Generic;

namespace ConsoleToDoList
{
    class Program
    {
        private static List<string> todos = new List<string>();

        static void Main(string[] args)
        {
            MenuActions currentAction = MenuActions.Help;
            string param = "";

            do
            {
                (currentAction, param) = GetMenuAction();

                switch (currentAction)
                {
                    case MenuActions.Add:
                        AddToDo(param);
                        break;
                    case MenuActions.Print:
                        Print(3);
                        break;
                    case MenuActions.PrintAll:
                        Print();
                        break;
                    case MenuActions.Done:
                        Done(param);
                        break;
                    case MenuActions.Exit:
                        break;
                    case MenuActions.Help:
                        PrintHelp();
                        break;
                    case MenuActions.Clear:
                        Clear();
                        break;
                    case MenuActions.ReOrder:
                        ReOrder(param);
                        break;
                    default:
                        break;
                }

                Console.WriteLine();

            } while (currentAction != MenuActions.Exit);
        }

        private static (MenuActions action, string param) GetMenuAction()
        {
            MenuActions action = MenuActions.Help;

            Console.Write("What would you like to do: ");
            string fullAction = Console.ReadLine();

            string actionString = fullAction;
            string param = "";

            if (fullAction.IndexOf(' ') >= 0)
            {
                actionString = fullAction.Substring(0, fullAction.IndexOf(' '));
                param = fullAction.Substring(fullAction.IndexOf(' ') + 1);
            }

            if (Enum.TryParse(actionString, out action) == false)
            {
                action = MenuActions.Help;
            }

            return (action, param);

            //switch (action.ToLower()) 
            //{
            //    case "add":
            //        output = MenuActions.Add;
            //        break;
            //    case "print":
            //        output = MenuActions.Print;
            //        break;
            //    case "printall":
            //        output = MenuActions.PrintAll;
            //        break;
            //    case "done":
            //        output = MenuActions.Done;
            //        break;
            //    case "exit":
            //        output = MenuActions.Exit;
            //        break;
            //    case "help":
            //        output = MenuActions.Help;
            //        break;
            //    default:
            //        break;
            //}
        }

        private static void Done(string todoNumber)
        {
            if (int.TryParse(todoNumber, out int todo))
            {
                todos.RemoveAt(todo);
            }
            else
            {
                Console.WriteLine("That was an invalid todo number");
            }
        }

        private static void PrintHelp()
        {
            Console.WriteLine("Action List:");
            Console.WriteLine("Add - Add an item to the list");
            Console.WriteLine("Print - Print the top 3 todos");
            Console.WriteLine("PrintAll - Print all of the todos");
            Console.WriteLine("Done - Complete a todo");
            Console.WriteLine("ReOrder - Changes the order of a todo");
            Console.WriteLine("Clear - Clears the screen");
            Console.WriteLine("Exit - Exit the application");
            Console.WriteLine("Help - Get help");
        }

        private static void AddToDo(string todo)
        {
            todos.Add(todo);
        }

        private static void Print(int count = 0)
        {
            if (count == 0 || count > todos.Count)
            {
                count = todos.Count;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{ i }: { todos[i] }");
            }
        }

        private static void Clear()
        {
            Console.Clear();
        }

        private static void ReOrder(string parameters) // ReOrder 5 7
        {
            string[] paramSet = parameters.Split(' ');

            if (paramSet.Length != 2)
            {
                Console.WriteLine("You need to pass in the correect number of parameters");
                return;
            }

            int from = 0;
            int to = 0;

            if (int.TryParse(paramSet[0], out from) == false)
            {
                Console.WriteLine("You need to pass a valid from number");
                return;
            }

            if (int.TryParse(paramSet[1], out to) == false)
            {
                Console.WriteLine("You need to pass a valid to number");
                return;
            }

            if (from < 0 || from > todos.Count - 1)
            {
                Console.WriteLine("From is not in a valid range");
                return;
            }

            if (to < 0 || to > todos.Count - 1)
            {
                Console.WriteLine("To is not in a valid range");
                return;
            }

            string todo = todos[from];

            todos.RemoveAt(from);

            todos.Insert(to, todo);
        }
    }

    public enum MenuActions
    {
        Add,
        Print,
        PrintAll,
        Done,
        ReOrder,
        Exit,
        Help,
        Clear
    }
}
