using Challenge.Api.Domain.Entities;
using Challenge.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalesController : ControllerBase
    {
        private readonly ISalesService _salesService;
        private readonly IMoviesService _moviesService;

        public SalesController(ISalesService salesService,
            IMoviesService moviesService)
        {
            _salesService = salesService;
            _moviesService = moviesService;
        }

        [HttpGet("{id}", Name = "GetSalesById")]
        public IActionResult GetSalesById(int id)
        {
            var sale = _salesService.GetById(id);

            if (sale == null)
            {
                return NotFound();
            }

            return Ok(sale);
        }

        //[HttpPost]
        //public ActionResult<Sale> Create(Sale sale)
        //{
        //    if (sale == null) return BadRequest();

        //    _salesService.Create(sale);

        //    return CreatedAtRoute("GetSalesById",
        //        new { Id = sale.Id },
        //        sale);
        //}

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateSale([FromBody]Sale sale)
        {
            var a = Request;

            if (sale == null) return BadRequest();

            _salesService.Create(sale);

            var movie = _moviesService.GetById(sale.MovieId);

            movie.Stock--;

            _moviesService.Update(movie);

            return CreatedAtRoute("GetSalesById",
                new { Id = sale.Id },
                new { sale.MovieId, sale.CustomerEmail, sale.Price });
        }
    }
}
