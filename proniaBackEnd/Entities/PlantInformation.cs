namespace proniaBackEnd.Entities
{
    public class PlantInformation
    {
        public int Id { get; set; }
        public int PlantId { get; set; }
        public int InformationId { get; set; }
        public Plant Plant { get; set; }
        public Information Information { get; set; }
    }
}
