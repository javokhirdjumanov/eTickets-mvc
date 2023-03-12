using eTickets.mvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.mvc.Controllers
{
    public class ProducerController : Controller
    {
        private readonly AppDbContext context;
        public ProducerController(AppDbContext context)
            => this.context = context;

        public async Task<IActionResult> Index()
        {
            var allProduces = await context.Producers.ToListAsync();

            return View("ProducerIndex", allProduces);
        }
    }
}
