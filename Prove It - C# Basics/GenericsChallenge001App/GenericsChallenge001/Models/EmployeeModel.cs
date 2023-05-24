using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsChallenge001.Models
{
    public class EmployeeModel
    {
        public PersonModel Person { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
    }
}
