namespace Challenge.Api.Domain.Entities
{
    public class Movie : Entity
    {
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public int Stock { get; set; }
        
        public decimal RentalPrice { get; set; }
        
        public decimal SalePrice { get; set; }
        
        public bool Available { get; set; }
    }
}
