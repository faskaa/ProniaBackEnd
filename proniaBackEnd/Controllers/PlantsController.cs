using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NuGet.Protocol.Plugins;
using proniaBackEnd.DAL;
using proniaBackEnd.Entities;
using proniaBackEnd.ViewModels;
using System.Text.Json.Serialization;

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
                .Include(p=>p.PlantInformations).ThenInclude(p=>p.Information)
                .Include(p=>p.PlantCategories).ThenInclude(p=>p.Category)
                .Include(p=>p.PlantImages)
                .FirstOrDefault(p => p.Id == id)!;
            if (plant == null) return NotFound(); 
            return View(plant);
        }

        public IActionResult AddBasket(int id)
        {
            if (id == 0) return BadRequest();
            Plant plant = _context.Plants.FirstOrDefault(p => p.Id == id)!;
            if (plant == null) return NotFound();
            string basket= HttpContext.Request.Cookies["basket"];
            CookieItem cookiePlant = new CookieItem
            {
               Id = plant.Id,
               Name = plant.Name,
               Price = plant.Price,
               Quantity = 1
            };

            BasketItem basketItem = new BasketItem();
            if (basket is null)
            {
                basketItem.CookieItems  = new List<CookieItem>
                {
                   cookiePlant
                };

            }
            else
            {
                basketItem = JsonConvert.DeserializeObject<BasketItem>(basket)!;
                CookieItem existedPlant= basketItem.CookieItems.FirstOrDefault(p => p.Id == id);
                if (existedPlant is null)
                {

                    basketItem.CookieItems.Add(cookiePlant);
                }
                else
                {
                    existedPlant.Quantity++;
                    existedPlant.Price += plant.Price;
                }
            }
            basketItem.Count= basketItem.CookieItems.Sum(p => p.Quantity);
            basketItem.TotalPrice = basketItem.CookieItems.Sum(p=>p.Price);

            var plantsStr = JsonConvert.SerializeObject(basketItem);
            HttpContext.Response.Cookies.Append("basket", plantsStr);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult ShowBasket()
        {
            var basket = HttpContext.Request.Cookies["basket"]?? ""; 
            //burdaki listler plant idi , cookieitem a deyisdirdim duzeldi
            BasketItem convertedPlant = JsonConvert.DeserializeObject<BasketItem>(basket);
            return Json(convertedPlant);
        }
    }
}
