using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.R2
{
    public class IndexModel : PageModel
    {
        private readonly OdeToFood.Data.OdeToFoodDbContxet _context;

        public IndexModel(OdeToFood.Data.OdeToFoodDbContxet context)
        {
            _context = context;
        }

        public IList<Resturant> Resturant { get;set; }

        public async Task OnGetAsync()
        {
            Resturant = await _context.Resturants.ToListAsync();
        }
    }
}
