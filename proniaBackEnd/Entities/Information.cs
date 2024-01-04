namespace proniaBackEnd.Entities
{
    public class Information
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public byte Order { get; set; }

        public ICollection<PlantInformation> PlantInformations { get; set; }
    }

}
