using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// https://github.com/punker76/gong-wpf-dragdrop

namespace WPFToDo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<ToDoItemModel> todoList = new BindingList<ToDoItemModel>();

        public MainWindow()
        {
            InitializeComponent();

            todoListBox.ItemsSource = todoList;
        }

        private void AddNewToDo_Click(object sender, RoutedEventArgs e)
        {
            ToDoItemModel todo = new ToDoItemModel
            {
                ToDoText = newToDoItem.Text
            };

            todoList.Add(todo);

            newToDoItem.Text = "";
        }

        private void DeleteToDo_Click(object sender, RoutedEventArgs e)
        {
            if (todoListBox.SelectedItem == null)
            {
                return;
            }

            ToDoItemModel todo = (ToDoItemModel)todoListBox.SelectedItem;

            todoList.Remove(todo);
        }

        ToDoItemModel editingItem = null;

        private void EditToDo_Click(object sender, RoutedEventArgs e)
        {
            if (todoListBox.SelectedItem == null)
            {
                return;
            }

            editingItem = (ToDoItemModel)todoListBox.SelectedItem;

            updateToDoItem.Text = editingItem.ToDoText;

            editToDoPanel.Visibility = Visibility.Visible;
            newToDoPanel.Visibility = Visibility.Collapsed;
        }

        private void UpdateToDo_Click(object sender, RoutedEventArgs e)
        {
            editingItem.ToDoText = updateToDoItem.Text;

            editToDoPanel.Visibility = Visibility.Collapsed;
            newToDoPanel.Visibility = Visibility.Visible;

            updateToDoItem.Text = "";
        }

        private void TodoListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (todoListBox.SelectedItem == null)
            {
                return;
            }

            ToDoItemModel todo = (ToDoItemModel)todoListBox.SelectedItem;

            todo.IsComplete = !todo.IsComplete;

            if (todo.IsComplete)
            {
                todoList.Remove(todo);
                todoList.Add(todo);
            }
        }
    }
}
