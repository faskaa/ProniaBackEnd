using Newtonsoft.Json;
using proniaBackEnd.ViewModels;
using System.Text.Json.Serialization;

namespace proniaBackEnd.Services
{
    public class LayoutService
    {
        private readonly IHttpContextAccessor _http;

        public LayoutService(IHttpContextAccessor http)
        {
            _http = http;
        }

        public BasketItem GetBasket()
        {
            string basketStr = _http.HttpContext.Request.Cookies["basket"]?? "";
            BasketItem basket = JsonConvert.DeserializeObject<BasketItem>(basketStr)!;
            return basket;
        }
    }
}
