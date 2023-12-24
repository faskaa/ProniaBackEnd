using Microsoft.AspNetCore.Mvc;
using proniaBackEnd.DAL;
using proniaBackEnd.Entities;

namespace proniaBackEnd.Controllers
{
    public class HomeController : Controller
    {
        readonly ProniaDbContext _context;

        public HomeController(ProniaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            IEnumerable<Slider> model = _context.Sliders.AsEnumerable();
            return View(model);
        }
    }
}
