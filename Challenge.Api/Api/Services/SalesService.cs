using Challenge.Api.Domain.Entities;
using Challenge.Api.Services.Data.Repositories;
using Challenge.Api.Services.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.Api.Services
{
    public class SalesService : BaseService<Sale, ISalesRepository>, ISalesService
    {
        public SalesService(ISalesRepository mainRepository) : base(mainRepository)
        { }

        public List<Sale> GetByIdAndDateRange(int movieId, DateTime from, DateTime to)
        {
            return _mainRepository.Get(x => x.IsActive && (x.CreatedAt >= from && x.CreatedAt <= to)).ToList();
        }

        protected override TaskResult<Sale> ValidateOnCreate(Sale entity)
        {
            return new TaskResult<Sale>();
        }

        protected override TaskResult<Sale> ValidateOnDelete(Sale entity)
        {
            return new TaskResult<Sale>();
        }

        protected override TaskResult<Sale> ValidateOnUpdate(Sale entity)
        {
            return new TaskResult<Sale>();
        }
    }

    public interface ISalesService : IBaseService<Sale, ISalesRepository>
    {
        List<Sale> GetByIdAndDateRange(int movieId, DateTime from, DateTime to);
    }
}
