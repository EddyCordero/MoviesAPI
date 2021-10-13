using System.Collections.Generic;


namespace Challenge.Api.Domain.Entities
{
    public class Sale : Entity
    {
        public int MovieId { get; set; }

        public string CustomerEmail { get; set; }
        
        public decimal Price { get; set; }
    }
}
