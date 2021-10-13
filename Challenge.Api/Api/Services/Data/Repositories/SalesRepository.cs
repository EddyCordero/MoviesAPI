using Challenge.Api.Domain.Entities;

namespace Challenge.Api.Services.Data.Repositories
{
    public class SalesRepository : BaseRepository<Sale>, ISalesRepository
    {
        public SalesRepository(MoviesDbContext database) : base(database)
        {
        }
    }

    public interface ISalesRepository : IBaseRepository<Sale> { }
}
