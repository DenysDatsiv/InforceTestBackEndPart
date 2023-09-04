using InforceTest.Models;
using InforceTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace InforceTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkController : ControllerBase
    {
        private readonly ILinkService _linkService;

        public LinkController(ILinkService linkService)
        {
            _linkService = linkService;
        }

        [HttpGet]
        public IActionResult GetLinks()
        {
            var links = _linkService.List(); 
            return Ok(links);
        }

        [HttpGet("{id}")]
        public IActionResult GetLink(int id)
        {
            var link = _linkService.Get(id); 
            if (link == null)
            {
                return NotFound();
            }
            return Ok(link);
        }

        [HttpPost]
        public IActionResult CreateLink([FromBody] Link link)
        {
            if (link == null)
            {
                return BadRequest();
            }

            var createdLink = _linkService.Create(link);
            return CreatedAtAction(nameof(GetLink), new { id = createdLink.Id }, createdLink);
        }

      
        [HttpDelete("{id}")]
        public IActionResult DeleteLink(int id)
        {
            var result = _linkService.Delete(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}