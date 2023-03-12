using eTickets.mvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.mvc.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext context;
        public ActorsController(AppDbContext context) 
            => this.context = context;

        public async Task<IActionResult> Index()
        {
            var data = await context.Actors.ToListAsync();
            return View();
        }
    }
}
