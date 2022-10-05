using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WikiC.Data;
using WikiC.Models;

namespace WikiC.Pages.Tags
{
    public class DetailsModel : PageModel
    {
        private readonly WikiC.Data.ApplicationDbContext _context;

        public DetailsModel(WikiC.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Tag Tag { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Tags == null)
            {
                return NotFound();
            }

            var tag = await _context.Tags.FirstOrDefaultAsync(m => m.Id == id);
            if (tag == null)
            {
                return NotFound();
            }
            else 
            {
                Tag = tag;
            }
            return Page();
        }
    }
}
