using Microsoft.AspNetCore.Mvc;
using proniaBackEnd.DAL;
using proniaBackEnd.Entities;
using proniaBackEnd.ViewModels;

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

            HomeVM model = new HomeVM
            {
                
                Sliders = _context.Sliders.ToList(),
                Plants = _context.Plants.ToList(),

            };
            return View(model);
        }
    }
}
