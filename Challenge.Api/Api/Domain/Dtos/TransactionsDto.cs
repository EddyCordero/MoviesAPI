using Challenge.Api.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.Api.Domain.Dtos
{
    public class TransactionsDto
    {
        public int MovieId { get; set; }

        public string MovieTitle { get; set; }

        public decimal TotalRevenue => Rentals.Sum(x => x.Price) + Sales.Sum(x => x.Price);

        public IList<Rental> Rentals { get; set; }

        public IList<Sale> Sales { get; set; }
    }
}
