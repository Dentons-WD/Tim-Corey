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
    public class ShellViewModel
    {
        public BindableCollection<PersonModel> People { get; set; }

        public ShellViewModel()
        {
            DataAccess da = new DataAccess();
            People = new BindableCollection<PersonModel>(da.GetPeople());
        }

        public void AddPerson()
        {
            DataAccess dataAccess = new DataAccess();

            int maxId = 0;

            if (People.Count > 0)
            {
                People.Max(x => x.PersonId);
            }

            People.Add(dataAccess.GetPerson(maxId + 1));                  
        }

        public void RemovePerson()
        {
            DataAccess dataAccess = new DataAccess();

            if (People.Count == 0)
            {
                return;
            }

            PersonModel randomPerson = dataAccess.GetRandomItem(People.ToArray());

            People.Remove(randomPerson);
        }
    }
}
