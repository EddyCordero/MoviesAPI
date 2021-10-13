using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Api.Domain.Entities
{
    public class Rental : Entity
    {
        public int MovieId { get; set; }

        //public IList<Movie> Movies { get; set; }

        public string CustomerEmail { get; set; }

        public decimal Price { get; set; }
    }
}
