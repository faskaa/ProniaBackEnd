namespace proniaBackEnd.ViewModels
{
    public class BasketItem
    {
        //sual => burda niye cookieitem i saxliyiriq
        public List<CookieItem> CookieItems { get; set; } = null!;
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
