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
    public class ListModel : PageModel
    {
        private readonly GestaoDeLaboratorios.DAL.InfnetDbContext _context;

        public ListModel(GestaoDeLaboratorios.DAL.InfnetDbContext context)
        {
            _context = context;
        }

        public IList<Computadores> Computadores { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Computadores = await _context.Computadores.ToListAsync();
        }
    }
}
