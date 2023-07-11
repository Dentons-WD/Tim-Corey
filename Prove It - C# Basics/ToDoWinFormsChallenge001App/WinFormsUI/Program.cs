using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    // GOAL
    // Create a WinFormsapp that maintains a todo list in a
    // ListBox. Allow a user to add, remove, edit, and
    // complete items. Double-clicking on a list item should
    // mark it complete.

    // BONUS
    // Set up the ListBoxso that when an item is selected,
    // you can use the arrow keys to move it up or down in
    // priority. Ensure that the priority number is displayed
    // on the item and that it changes when the item
    // moves.

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ToDoForm());
        }
    }
}
