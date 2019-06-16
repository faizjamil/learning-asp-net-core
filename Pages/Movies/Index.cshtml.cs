using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazerPagesMovie.Models;
using RazorPagesMovie.Models;

namespace RazerPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazerPagesMovie.Models.RazerPagesMovieContext _context;

        public IndexModel(RazerPagesMovie.Models.RazerPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
