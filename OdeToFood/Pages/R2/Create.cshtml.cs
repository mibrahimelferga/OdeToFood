using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.R2
{
    public class CreateModel : PageModel
    {
        private readonly OdeToFood.Data.OdeToFoodDbContxet _context;

        public CreateModel(OdeToFood.Data.OdeToFoodDbContxet context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Resturant Resturant { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Resturants.Add(Resturant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}