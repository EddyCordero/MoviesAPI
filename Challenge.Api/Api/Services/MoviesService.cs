using Challenge.Api.Domain.Entities;
using Challenge.Api.Services.Data.Repositories;
using Challenge.Api.Services.Framework;

namespace Challenge.Api.Services
{
    public class MoviesService : BaseService<Movie, IMoviesRepository>, IMoviesService
    {
        public MoviesService(IMoviesRepository mainRepository) : base(mainRepository)
        { }

        protected override TaskResult<Movie> ValidateOnCreate(Movie entity)
        {
            return new TaskResult<Movie>();
        }

        protected override TaskResult<Movie> ValidateOnDelete(Movie entity)
        {
            return new TaskResult<Movie>();
        }

        protected override TaskResult<Movie> ValidateOnUpdate(Movie entity)
        {
            return new TaskResult<Movie>();
        }
    }

    public interface IMoviesService : IBaseService<Movie, IMoviesRepository>
    { }
}
