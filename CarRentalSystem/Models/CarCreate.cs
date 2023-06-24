namespace CarRentalSystem.Models
{
    public class CarCreate
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string CarId { get; set; }
        public string CarModel { get; set; }
        
        public double CarPrice { get; set; }
        public string CarDescription { get; set; }
        public string CompanyName { get; set; }
        
    }
}
