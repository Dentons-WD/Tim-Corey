using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// GOAL
// Create a .NET Core WPFapp that captures and
// displays todo items. The user should be able to add,
// edit, complete, and remove todo items in a ListBox.
// When the user double-clicks on a todo, strike it
// through and mark it complete.

// BONUS
// Set up the ListBox so that the user can drag and drop
// the todosto reorder them. Also, ensure that all
// completed todo items are placed at the bottom by
// default.

namespace WpfUi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<ToDoModel> ToDos { get; set; } = new List<ToDoModel>();

        public MainWindow()
        {
            InitializeComponent();

            ToDosListView.ItemsSource = ToDos;
        }

        private void AddToDoButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(AddToDoTextBox.Text))
            {
                return;
            }

            ToDos.AddToDo(AddToDoTextBox.Text);
            ToDosListView.Items.Refresh();
            AddToDoTextBox.Text = String.Empty;
        }

        private void ToDosListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (ToDosListView.SelectedItem == null)
            {
                return;
            }

            ToDoModel selectedToDo = (ToDoModel)ToDosListView.SelectedItem;

            if (selectedToDo.IsComplete == true)
            {
                return;
            }

            ToDos.CompleteToDo(selectedToDo);
            ToDosListView.Items.Refresh();
        }

        private void ToDosListView_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (ToDosListView.SelectedItem == null)
            {
                return;
            }

            ToDoModel selectedToDo = (ToDoModel)ToDosListView.SelectedItem;

            if (e.Key == Key.Delete)
            {
                ToDos.RemoveToDo(selectedToDo);
                ToDosListView.Items.Refresh();
            }
            else if (e.Key == Key.Up)
            {
                ToDos.ShiftToDoUp(selectedToDo);
                ToDosListView.Items.Refresh();
            }
            else if (e.Key == Key.Down)
            {
                ToDos.ShiftToDoDown(selectedToDo);
                ToDosListView.Items.Refresh();
            }
        }
    }
}
