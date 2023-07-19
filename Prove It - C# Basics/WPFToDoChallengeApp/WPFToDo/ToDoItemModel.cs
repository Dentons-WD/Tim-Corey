using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WPFToDo
{
    public class ToDoItemModel : INotifyPropertyChanged
    {
        private string _toDoText;
        private bool _isComplete = false;

        public string ToDoText
        {
            get => _toDoText;
            set
            {
                _toDoText = value;
                NotifyPropertyChanged();
            }
        }

        public bool IsComplete
        {
            get => _isComplete;
            set
            {
                _isComplete = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
