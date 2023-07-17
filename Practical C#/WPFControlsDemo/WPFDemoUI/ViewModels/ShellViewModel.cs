using Caliburn.Micro;
using DemoLibrary;
using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemoUI.ViewModels
{
    public class ShellViewModel : Screen
    {
        public BindableCollection<PersonModel> People { get; set; }

        private PersonModel _selectedPerson;

        public PersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set 
            {
                _selectedPerson = value;
                SelectedAddress = value.PrimaryAddress;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }

        private AddressModel _selectedAddress;

        public AddressModel SelectedAddress
        {
            get { return _selectedAddress; }
            set 
            { 
                _selectedAddress = value;
                SelectedPerson.PrimaryAddress = value;
                NotifyOfPropertyChange(() => SelectedAddress);
            }
        }


        public ShellViewModel()
        {
            DataAccess da = new DataAccess();
            People = new BindableCollection<PersonModel>(da.GetPeople());
        }
    }
}
