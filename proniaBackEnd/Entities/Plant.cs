namespace proniaBackEnd.Entities
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }


        public string SKU { get; set; }

        public ICollection<PlantCategory> PlantCategories { get; set; }
        public ICollection<PlantImage>  PlantImages { get; set; }
        public ICollection<PlantInformation> PlantInformations { get; set; }

    }
}
