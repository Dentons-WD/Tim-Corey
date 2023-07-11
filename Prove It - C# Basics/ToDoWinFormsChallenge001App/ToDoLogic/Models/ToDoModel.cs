using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLogic.Models
{
    public class ToDoModel
    {
        public int Position { get; set; }

        public bool IsComplete { get; set; }

        public string Text { get; set; }
    }
}
