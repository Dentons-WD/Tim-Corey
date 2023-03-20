using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleUsage.Models;
using System.Threading.Tasks;

namespace SimpleUsage.Pages
{
    public class TwoFormsModel : PageModel
    {
        [BindProperty]
        public PersonModel NewPerson { get; set; }

        [BindProperty]
        public AddressModel NewAddress { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostPersonAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostAddressAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage();
        }
    }
}
