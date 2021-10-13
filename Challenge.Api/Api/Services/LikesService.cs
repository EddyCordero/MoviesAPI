using Challenge.Api.Domain.Entities;
using Challenge.Api.Services.Data.Repositories;
using Challenge.Api.Services.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.Api.Services
{
    public class LikesService : BaseService<Like, ILikesRepository>, ILikesService
    {
        public LikesService(ILikesRepository mainRepository) : base(mainRepository)
        { }

        public List<Like> GetByIdAndDateRange(int movieId, DateTime from, DateTime to)
        {
            return _mainRepository.Get(x => x.IsActive && (x.CreatedAt >= from && x.CreatedAt <= to)).ToList();
        }

        protected override TaskResult<Like> ValidateOnCreate(Like entity)
        {
            return new TaskResult<Like>();
        }

        protected override TaskResult<Like> ValidateOnDelete(Like entity)
        {
            return new TaskResult<Like>();
        }

        protected override TaskResult<Like> ValidateOnUpdate(Like entity)
        {
            return new TaskResult<Like>();
        }
    }

    public interface ILikesService : IBaseService<Like, ILikesRepository>
    {
        List<Like> GetByIdAndDateRange(int movieId, DateTime from, DateTime to);
    }
}
