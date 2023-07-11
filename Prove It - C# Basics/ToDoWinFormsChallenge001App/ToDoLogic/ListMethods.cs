using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoLogic.Models;

namespace ToDoLogic
{
    public class ListMethods
    {
        public List<ToDoModel> ToDoList { get; }

        public ListMethods(List<ToDoModel> toDoList)
        {
            ToDoList = toDoList;
        }

        public void AddToDo(string toDoText)
        {
            ToDoModel toDoToAdd = new ToDoModel();

            int maxPosition = 0;

            if (ToDoList.Count > 0)
            {
                 maxPosition = ToDoList.OrderByDescending(x => x.Position).First().Position;
            }

            toDoToAdd.Position = maxPosition + 1;
            toDoToAdd.Text = toDoText;
            toDoToAdd.IsComplete = false;

            ToDoList.Add(toDoToAdd);
        }

        public void RemoveToDo(ToDoModel toDoToRemove)
        {
            int maxPosition = ToDoList.OrderByDescending(x => x.Position).First().Position;

            if (toDoToRemove.Position != maxPosition)
            {
                foreach (var toDo in ToDoList)
                {
                    if (toDo.Position > toDoToRemove.Position)
                    {
                        toDo.Position -= 1;
                    }
                }
            }

            ToDoList.Remove(toDoToRemove);
        }

        public void MoveToDoUp(ToDoModel toDo)
        {
            int minPostition = 1;

            if (toDo.Position != minPostition)
            {
                ToDoModel toDoAbove = ToDoList.Where(x => x.Position == toDo.Position - 1).FirstOrDefault();

                toDo.Position = toDo.Position - 1;
                toDoAbove.Position = toDoAbove.Position + 1;
            }
        }

        public void MoveToDoDown(ToDoModel toDo)
        {
            int maxPosition = ToDoList.OrderByDescending(x => x.Position).First().Position;

            if (toDo.Position != maxPosition)
            {
                ToDoModel toDoBelow = ToDoList.Where(x => x.Position == toDo.Position + 1).FirstOrDefault();

                toDo.Position = toDo.Position + 1;
                toDoBelow.Position = toDoBelow.Position - 1;
            }
        }
    }
}
