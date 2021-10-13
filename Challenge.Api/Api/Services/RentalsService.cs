using Challenge.Api.Domain.Entities;
using Challenge.Api.Services.Data.Repositories;
using Challenge.Api.Services.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.Api.Services
{
    public class RentalsService : BaseService<Rental, IRentalsRepository>, IRentalsService
    {
        public RentalsService(IRentalsRepository mainRepository) : base(mainRepository)
        { }

        public List<Rental> GetByIdAndDateRange(int movieId, DateTime from, DateTime to)
        {
            return _mainRepository.Get(x => x.IsActive && (x.CreatedAt >= from && x.CreatedAt <= to)).ToList();
        }

        protected override TaskResult<Rental> ValidateOnCreate(Rental entity)
        {
            return new TaskResult<Rental>();
        }

        protected override TaskResult<Rental> ValidateOnDelete(Rental entity)
        {
            return new TaskResult<Rental>();
        }

        protected override TaskResult<Rental> ValidateOnUpdate(Rental entity)
        {
            return new TaskResult<Rental>();
        }
    }

    public interface IRentalsService : IBaseService<Rental, IRentalsRepository>
    {
        List<Rental> GetByIdAndDateRange(int movieId, DateTime from, DateTime to);
    }
}
