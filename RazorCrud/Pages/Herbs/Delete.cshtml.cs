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
    public class DeleteModel : PageModel
    {
        private readonly RazorCrudHerbContext _context;

        public DeleteModel(RazorCrudHerbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Herb = await _context.Herb.FindAsync(id);

            if (Herb != null)
            {
                _context.Herb.Remove(Herb);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
