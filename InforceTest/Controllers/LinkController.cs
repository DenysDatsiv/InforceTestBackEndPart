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

        // GET: api/Link
        [HttpGet]
        public IActionResult GetLinks()
        {
            var links = _linkService.List(); // Replace with your actual logic to get a list of links
            return Ok(links);
        }

        // GET: api/Link/5
        [HttpGet("{id}")]
        public IActionResult GetLink(int id)
        {
            var link = _linkService.Get(id); // Replace with your actual logic to get a single link by ID
            if (link == null)
            {
                return NotFound();
            }
            return Ok(link);
        }

        // POST: api/Link
        [HttpPost]
        public IActionResult CreateLink([FromBody] Link link)
        {
            if (link == null)
            {
                return BadRequest();
            }

            var createdLink = _linkService.Create(link); // Replace with your actual logic to create a new link
            return CreatedAtAction(nameof(GetLink), new { id = createdLink.Id }, createdLink);
        }

      
        // DELETE: api/Link/5
        [HttpDelete("{id}")]
        public IActionResult DeleteLink(int id)
        {
            var result = _linkService.Delete(id); // Replace with your actual logic to delete a link
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}