using eTickets.mvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.mvc.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext context;
        public MovieController(AppDbContext context)
            => this.context = context;

        public async Task<IActionResult> Index()
        {
            var data = await context.Movies.ToListAsync();
            return View();
        }
    }
}
