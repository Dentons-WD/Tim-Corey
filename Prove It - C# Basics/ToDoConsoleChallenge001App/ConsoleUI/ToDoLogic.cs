using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleUI
{
    public static class ToDoLogic
    {
        public static void AddToDo(List<ToDoModel> toDos, string body)
        {
            int id = 1;

            if (toDos.Count > 0)
            {
                id = toDos.OrderBy(x => x.Order).Last().Order + 1;
            }

            toDos.Add(new ToDoModel
            {
                Order = id,
                Body = body
            });
        }
    }
}
