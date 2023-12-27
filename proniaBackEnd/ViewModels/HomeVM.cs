using proniaBackEnd.Entities;

namespace proniaBackEnd.ViewModels
{
    public class HomeVM
    {
        public ICollection<Slider> Sliders { get; set; }
        public ICollection<Plant> Plants { get; set; }
    }
}
