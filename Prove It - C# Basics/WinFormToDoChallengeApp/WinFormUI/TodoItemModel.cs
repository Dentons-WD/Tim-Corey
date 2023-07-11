using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormUI
{
    public class TodoItemModel : INotifyPropertyChanged
    {
        private bool _isComplete = false;
        private string _todoText;
        private int _positionNumber;

        public int PositionNumber
        { 
            get => _positionNumber; 
            set
            {
                _positionNumber = value;
                NotifyPropertyChanged();
            } 
        }

        public string TodoText 
        { 
            get => _todoText;
            set 
            {
                _todoText = value;
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

        public string ToDoDisplay => $"{ PositionNumber }: { TodoText } (Complete: { IsComplete })";

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
