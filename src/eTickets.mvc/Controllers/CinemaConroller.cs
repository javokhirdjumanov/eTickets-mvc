using eTickets.mvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.mvc.Controllers
{
    public class CinemaConroller : Controller
    {
        private readonly AppDbContext context;
        public CinemaConroller(AppDbContext context)
            => this.context = context;

        public async Task<IActionResult> Index()
        {
            var data = await context.Cinemas.ToListAsync();
            return View();
        }
    }
}
