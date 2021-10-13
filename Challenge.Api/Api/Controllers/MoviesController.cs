using Challenge.Api.Domain.Entities;
using Challenge.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService _moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet]
        public ActionResult GetMovies()
        {
            var movies = _moviesService.GetAll();

            return Ok(movies);
        }

        [HttpGet("{id}", Name = "GetMovieById")]
        public IActionResult GetMovieById(int id)
        {
            var movie =  _moviesService.GetById(id);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (movie == null) return BadRequest();

            _moviesService.Create(movie);

            return CreatedAtRoute("GetMovieById",
                new { Id = movie.Id },
                movie);
        }

        [HttpPut]
        public ActionResult Update(Movie movie)
        {
            var movieFromDb = _moviesService.GetById(movie.Id);

            if (movieFromDb == null)
                return NotFound();

            _moviesService.Update(movie);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var movieFromDb = _moviesService.GetById(id);

            if (movieFromDb == null)
                return NotFound();

            _moviesService.Delete(movieFromDb);

            return NoContent();
        }


        //[HttpGet]
        //public ActionResult GetTransactions(int movieId, DateTimeOffset from, DateTimeOffset to)
        //{
        //    var movie = _moviesService.GetById(movieId);

        //    if (movie == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(movie);
        //}
    }
}
