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
    public class IndexModel : PageModel
    {
        private readonly WikiC.Data.ApplicationDbContext _context;

        public IndexModel(WikiC.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Categoria> Categoria { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Categorias != null)
            {
                Categoria = await _context.Categorias.ToListAsync();
            }
        }
    }
}
