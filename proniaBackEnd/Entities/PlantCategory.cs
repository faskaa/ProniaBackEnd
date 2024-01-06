using System.Security.Policy;

namespace proniaBackEnd.Entities
{
    public class PlantCategory
    {
        public int Id { get; set; } 
        public int PlantId { get; set; }
        public int CategoryId { get; set; }

        public Plant Plant { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return Category.Name;   
        }
    }
}
