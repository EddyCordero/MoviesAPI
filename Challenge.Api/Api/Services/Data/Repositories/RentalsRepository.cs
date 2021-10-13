using Challenge.Api.Domain.Entities;

namespace Challenge.Api.Services.Data.Repositories
{
    public class RentalsRepository : BaseRepository<Rental>, IRentalsRepository
    {
        public RentalsRepository(MoviesDbContext database) : base(database)
        {
        }
    }

    public interface IRentalsRepository : IBaseRepository<Rental> { }
}
