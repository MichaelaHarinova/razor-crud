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
    public class IndexModel : PageModel
    {
        private readonly RazorCrudHerbContext _context;

        public IndexModel(RazorCrudHerbContext context)
        {
            _context = context;
        }

        public IList<Herb> Herb { get;set; }

        public async Task OnGetAsync()
        {
            Herb = await _context.Herb.ToListAsync();
        }
    }
}
