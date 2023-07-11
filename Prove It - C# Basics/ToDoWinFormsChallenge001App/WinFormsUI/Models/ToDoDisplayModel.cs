using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoLogic.Models;

namespace WinFormsUI.Models
{
    public class ToDoDisplayModel : ToDoModel
    {
		public string DisplayText
		{
			get 
			{
				return $"{ Position }) { Text }";
			}
		}

	}
}
