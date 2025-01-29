using BasicInfo.API.Data.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicInfo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            var info = new InfoResponseDto
            {
                email = "kennaumeh@gmail.com",
                date_time = DateTime.UtcNow.ToString("o"),
                github_url = "https://github.com/ikennaumeh/basic-info"
            };

            return Ok(info);
        }
    }
}