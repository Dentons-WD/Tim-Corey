using System;
using System.Collections.Generic;
using System.Linq;

// GOAL
// Create a.NET Core Console app that has the following
// actions available to it: Add <todo>, Print (top 3),
// PrintAll, and Done (with todo number). Just store the
// data in memory. No need to store it in a database.

// BONUS
// Add a method called ReOrder that moves a todo up
// or down in priority by the user identifying the new
// number it should be.

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            List<ToDoModel> toDos = new List<ToDoModel>();

            toDos.Add(new ToDoModel
            {
                Order = 1,
                Body = "Test1"
            });
            toDos.Add(new ToDoModel
            {
                Order = 2,
                Body = "Test2"
            });
            toDos.Add(new ToDoModel
            {
                Order = 3,
                Body = "Test3"
            });
            toDos.Add(new ToDoModel
            {
                Order = 4,
                Body = "Test4"
            });

            Console.WriteLine("Commands: 'Add', 'Print', 'PrintAll', 'Order', 'Quit'");

            do
            {
                input = Console.ReadLine();

                if (input.ToLower() == "add")
                {
                    Console.WriteLine("Enter ToDo Body:");

                    input = "";

                    do
                    {
                        input = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(input));

                    ToDoLogic.AddToDo(toDos, input);

                }
                else if (input.ToLower() == "print")
                {
                    if (toDos.Count == 0)
                    {
                        Console.WriteLine("No ToDos to print.");
                    }
                    else
                    {
                        foreach (var toDo in toDos.OrderBy(x => x.Order))
                        {
                            if (toDo.Order <= 3)
                            {
                                Console.WriteLine(toDo.Body);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                else if (input.ToLower() == "printall")
                {
                    if (toDos.Count == 0)
                    {
                        Console.WriteLine("No ToDos to print.");
                    }
                    else
                    {
                        foreach (var toDo in toDos.OrderBy(x => x.Order))
                        {
                            Console.WriteLine(toDo.Body);
                        }
                    }
                }
                else if (input.ToLower() == "order")
                {
                    if (toDos.Count < 2)
                    {
                        Console.WriteLine("Not enough ToDos to print.");
                    }
                    else
                    {
                        int selectedOrder = 0;
                        int newOrder = 0;
                        int minOrder = 1;
                        int maxOrder = toDos.OrderByDescending(toDos => toDos.Order).First().Order;

                        foreach (var toDo in toDos.OrderBy(x => x.Order))
                        {
                            Console.WriteLine($"{ toDo.Order }) { toDo.Body }");
                        }

                        bool validOrder = false;

                        do
                        {
                            Console.WriteLine("Enter the position of the ToDo you want to move.");
                            input = Console.ReadLine();

                            if (int.TryParse(input, out selectedOrder))
                            {
                                if (selectedOrder >= minOrder && selectedOrder <= maxOrder)
                                {
                                    validOrder = true;
                                }
                            }

                            if (validOrder == false)
                            {
                                Console.WriteLine("Invalid position.");
                            }

                        } while (validOrder != true);

                        validOrder = false;

                        do
                        {
                            Console.WriteLine("Enter the new position of the ToDo.");
                            input = Console.ReadLine();

                            if (int.TryParse(input, out newOrder))
                            {
                                if (newOrder >= minOrder && newOrder <= maxOrder)
                                {
                                    validOrder = true;
                                }
                            }

                            if (validOrder == false)
                            {
                                Console.WriteLine("Invalid position.");
                            }

                        } while (validOrder != true);

                        toDos[selectedOrder - 1].Order = newOrder;
                        toDos[newOrder - 1].Order = selectedOrder;
                    }
                }
                else if (input.ToLower() != "quit" && !string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid Command");
                }

                Console.WriteLine("Commands: 'Add', 'Print', 'PrintAll', 'Order', 'Quit'");

            } while (input.ToLower() != "quit");
        }
    }
}
