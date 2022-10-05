using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WikiC.Data;
using WikiC.Models;

namespace WikiC.Pages.Posts
{
    public class CreateModel : PageModel
    {
        private readonly WikiC.Data.ApplicationDbContext _context;

        public CreateModel(WikiC.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "NombreCat");
        ViewData["TagId"] = new SelectList(_context.Tags, "Id", "NombreTag");
            return Page();
        }

        [BindProperty]
        public Post Post { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Posts.Add(Post);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
