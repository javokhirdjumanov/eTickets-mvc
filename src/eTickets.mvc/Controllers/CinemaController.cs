using eTickets.mvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.mvc.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDbContext context;
        public CinemaController(AppDbContext context)
            => this.context = context;

        public async Task<IActionResult> Index()
        {
            var allCinemas = await context.Cinemas.ToListAsync();
            return View("CinemaIndex", allCinemas);
        }
    }
}
