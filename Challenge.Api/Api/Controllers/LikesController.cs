using Challenge.Api.Domain.Entities;
using Challenge.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LikesController : ControllerBase
    {
        private readonly ILikesService _likesService;

        public LikesController(ILikesService likesService)
        {
            _likesService = likesService;
        }


        [HttpGet("{id}", Name = "GetLikeById")]
        public IActionResult GetLikeById(int id)
        {
            var like = _likesService.GetById(id);

            if (like == null)
            {
                return NotFound();
            }

            return Ok(like);
        }

        [HttpPost]
        public ActionResult CreateLike([FromBody]Like like)
        {
            if (like == null) return BadRequest();

            _likesService.Create(like);

            return CreatedAtRoute("GetLikeById",
                new { Id = like.Id },
                like);
        }
    }
}
