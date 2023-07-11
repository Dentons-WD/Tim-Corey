using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoLogic;
using ToDoLogic.Models;
using WinFormsUI.Models;

namespace WinFormsUI
{
    public partial class ToDoForm : Form
    {
        public List<ToDoModel> ToDoList { get; set; } = new List<ToDoModel>();
        public BindingList<ToDoDisplayModel> ToDoBindingList { get; set; }
        public ListMethods ListMethods { get; set; }

        public ToDoForm()
        {
            InitializeComponent();

            ListMethods = new ListMethods(ToDoList);

            DemoAddToDos();
            //DemoRemoveToDos();

            

            SyncLists();
        }

        private void SyncLists()
        {
            ToDoBindingList = new BindingList<ToDoDisplayModel>();

            foreach (var toDo in ToDoList)
            {
                ToDoBindingList.Add(new ToDoDisplayModel 
                {
                    Position = toDo.Position,
                    IsComplete = toDo.IsComplete,
                    Text = toDo.Text
                });
            }

            ToDoListBox.DataSource = ToDoBindingList;
            ToDoListBox.DisplayMember = "DisplayText";
        }

        private void DemoAddToDos()
        {
            ListMethods.AddToDo("Test 1");
            ListMethods.AddToDo("Test 2");
            ListMethods.AddToDo("Test 3");
            ListMethods.AddToDo("Test 4");
        }

        private void DemoRemoveToDos()
        {
            ListMethods.RemoveToDo(ToDoList[2]);
        }

        private void AddToDoButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(AddToDoTextBox.Text))
            {
                ListMethods.AddToDo(AddToDoTextBox.Text);
                SyncLists();
                AddToDoTextBox.Text = "";
            }
        }

        private void ToDoListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (ToDoListBox.SelectedItem != null)
            {
                ToDoDisplayModel bindingToDo = (ToDoDisplayModel)ToDoListBox.SelectedItem;
                ToDoModel selectedToDo = ToDoList.Where(x => x.Position == bindingToDo.Position).FirstOrDefault();

                if (e.KeyCode == Keys.Delete)
                {
                    ListMethods.RemoveToDo(selectedToDo);
                    SyncLists();
                }
                else if (e.KeyCode == Keys.Up)
                {
                    ListMethods.MoveToDoUp(selectedToDo);
                    SyncLists();
                }
                else if (e.KeyCode == Keys.Down)
                {
                    ListMethods.MoveToDoDown(selectedToDo);
                    SyncLists();
                }
            }
        }
    }
}
