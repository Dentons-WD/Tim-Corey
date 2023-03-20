using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleUsage.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleUsage.Pages
{
    public class DataDemoModel : PageModel
    {
        public List<PersonModel> People { get; set; } = new List<PersonModel>();

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; } = "";

        public async Task OnGetAsync()
        {
            List<PersonModel> output = new List<PersonModel>();

            output.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            output.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });
            output.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });

            if (string.IsNullOrWhiteSpace(SearchTerm) == false)
            {
                People = output.Where(x => x.LastName.StartsWith(SearchTerm)).ToList();
            }
            else
            {
                People = output;
            }
        }
    }
}
