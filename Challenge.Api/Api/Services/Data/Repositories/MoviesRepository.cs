using Challenge.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Api.Services.Data.Repositories
{
    public class MoviesRepository : BaseRepository<Movie>, IMoviesRepository
    {
        public MoviesRepository(MoviesDbContext database) : base(database)
        {
        }
    }

    public interface IMoviesRepository : IBaseRepository<Movie> { }
}
