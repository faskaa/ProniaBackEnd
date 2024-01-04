using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proniaBackEnd.DAL;
using proniaBackEnd.Entities;

namespace proniaBackEnd.Controllers
{
    public class PlantsController : Controller
    {
        private readonly ProniaDbContext _context;

        public PlantsController(ProniaDbContext context)
        {
            _context = context;
        }

        public IActionResult Details(int id)
        {
            if (id == 0) return BadRequest(); 
            Plant plant = _context.Plants
                .Include(p=>p.PlantInformations)
                .ThenInclude(p=>p.Information)
                .Include(p=>p.PlantCategories).ThenInclude(p=>p.Category)
                .FirstOrDefault(p => p.Id == id)!;
            if (plant == null) return NotFound(); 
            return View(plant);
        }
    }
}
