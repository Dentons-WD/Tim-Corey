using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfUi
{
    public static class ToDoLogic
    {
        public static void AddToDo(this List<ToDoModel> toDos, string toDoText)
        {
            int index = 0;

            if (toDos.Count > 0)
            {
                index = GetIndexOfLastInCompleteToDo(toDos) + 1;
            }

            toDos.Insert(index, new ToDoModel { Text = toDoText });
        }

        public static void RemoveToDo(this List<ToDoModel> toDos, ToDoModel toDoToRemove)
        {
            toDos.Remove(toDoToRemove);
        }

        public static void CompleteToDo(this List<ToDoModel> toDos, ToDoModel toDoToComplete)
        {
            int index = 0;

            if (toDos.Count > 1)
            {
                index = GetIndexOfLastInCompleteToDo(toDos);
            }

            toDos.Remove(toDoToComplete);
            toDos.Insert(index, new ToDoModel
            {
                Text = toDoToComplete.Text,
                IsComplete = true
            });
        }

        public static void ShiftToDoUp(this List<ToDoModel> toDos, ToDoModel toDoToShift)
        {
            if (toDoToShift.IsComplete == true)
            {
                return;
            }

            int index = 0;

            index = toDos.IndexOf(toDoToShift);

            if (index == 0)
            {
                return;
            }

            toDos.Remove(toDoToShift);
            toDos.Insert(index - 1, toDoToShift);
        }

        public static void ShiftToDoDown(this List<ToDoModel> toDos, ToDoModel toDoToShift)
        {
            if (toDoToShift.IsComplete == true)
            {
                return;
            }

            int index = 0;

            index = toDos.IndexOf(toDoToShift);

            if (index == GetIndexOfLastInCompleteToDo(toDos))
            {
                return;
            }

            toDos.Remove(toDoToShift);
            toDos.Insert(index + 1, toDoToShift);
        }

        private static int GetIndexOfLastInCompleteToDo(List<ToDoModel> toDos)
        {
            int output = 0;

            if (toDos.Where(x => x.IsComplete == true).FirstOrDefault() == null)
            {
                output = toDos.Count - 1;
            }
            else
            {
                for (int i = 0; i < toDos.Count; i++)
                {
                    if (toDos[i].IsComplete == true)
                    {
                        output = i - 1;

                        break;
                    }
                }
            }
            return output;
        }
    }
}
