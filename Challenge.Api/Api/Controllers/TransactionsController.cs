using Challenge.Api.Domain.Dtos;
using Challenge.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Challenge.Api.Controllers
{
    [ApiController]
    [Route("movies/{movieId}/transactions")]
    public class TransactionsController : ControllerBase
    {

        private readonly ISalesService _salesService;
        private readonly IRentalsService _rentalsService;
        private readonly IMoviesService _moviesService;

        public TransactionsController(ISalesService salesService, 
            IRentalsService rentalsService,
            IMoviesService moviesService)
        {
            _salesService = salesService;
            _rentalsService = rentalsService;
            _rentalsService = rentalsService;
            _moviesService = moviesService;
        }

        [HttpGet]
        public ActionResult GetTransactions([FromRoute]int movieId, [FromQuery] DateTime from, DateTime to)
        {
            var movie = _moviesService.GetById(movieId);

            if (movie == null)
            {
                return NotFound();
            }

            var sales = _salesService.GetByIdAndDateRange(movieId, from, to);
            var rentals = _rentalsService.GetByIdAndDateRange(movieId, from, to);

            var transaction = new TransactionsDto
            {
                MovieId = movieId,
                MovieTitle = movie.Title,
                Rentals = rentals,
                Sales = sales
            };

            return Ok(transaction);
        }
    }
}
