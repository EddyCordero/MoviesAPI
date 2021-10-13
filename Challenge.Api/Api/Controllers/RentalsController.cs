using Challenge.Api.Domain.Entities;
using Challenge.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RentalsController : ControllerBase
    {
        private readonly IRentalsService _rentalsService;
        private readonly IMoviesService _moviesService;

        public RentalsController(IRentalsService rentalsService,
            IMoviesService moviesService)
        {
            _rentalsService = rentalsService;
            _moviesService = moviesService;
        }

        [HttpGet("{id}", Name = "GetRentalById")]
        public IActionResult GetRentalById(int id)
        {
            var movie = _rentalsService.GetById(id);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        [HttpPost(Name = "CreateRental")]
        public ActionResult CreateRental([FromBody]Rental rental)
        {
            if (rental == null) return BadRequest();

            _rentalsService.Create(rental);
            var movie = _moviesService.GetById(rental.MovieId);

            movie.Stock--;

            _moviesService.Update(movie);

            return CreatedAtRoute("GetRentalById",
                new { Id = rental.Id },
                rental);
        }
    }
}
