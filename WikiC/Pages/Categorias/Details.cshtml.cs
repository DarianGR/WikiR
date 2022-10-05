using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WikiC.Data;
using WikiC.Models;

namespace WikiC.Pages.Categorias
{
    public class DetailsModel : PageModel
    {
        private readonly WikiC.Data.ApplicationDbContext _context;

        public DetailsModel(WikiC.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Categoria Categoria { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Categorias == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categorias.FirstOrDefaultAsync(m => m.Id == id);
            if (categoria == null)
            {
                return NotFound();
            }
            else 
            {
                Categoria = categoria;
            }
            return Page();
        }
    }
}
