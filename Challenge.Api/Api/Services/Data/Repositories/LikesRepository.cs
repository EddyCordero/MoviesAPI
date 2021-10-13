using Challenge.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Api.Services.Data.Repositories
{
    public class LikesRepository : BaseRepository<Like>, ILikesRepository
    {
        public LikesRepository(MoviesDbContext database) : base(database)
        {
        }
    }

    public interface ILikesRepository : IBaseRepository<Like> { }
}
