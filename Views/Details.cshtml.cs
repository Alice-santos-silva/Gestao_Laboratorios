using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GestaoDeLaboratorios.DAL;
using GestaoDeLaboratorios.Models;

namespace GestaoDeLaboratorios.Views
{
    public class DetailsModel : PageModel
    {
        private readonly GestaoDeLaboratorios.DAL.InfnetDbContext _context;

        public DetailsModel(GestaoDeLaboratorios.DAL.InfnetDbContext context)
        {
            _context = context;
        }

        public Computadores Computadores { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computadores = await _context.Computadores.FirstOrDefaultAsync(m => m.Id == id);
            if (computadores == null)
            {
                return NotFound();
            }
            else
            {
                Computadores = computadores;
            }
            return Page();
        }
    }
}
