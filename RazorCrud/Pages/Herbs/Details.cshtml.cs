using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

namespace RazorCrud.Pages.Herbs
{
    public class DetailsModel : PageModel
    {
        private readonly RazorCrudHerbContext _context;

        public DetailsModel(RazorCrudHerbContext context)
        {
            _context = context;
        }

        public Herb Herb { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Herb = await _context.Herb.FirstOrDefaultAsync(m => m.ID == id);

            if (Herb == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
