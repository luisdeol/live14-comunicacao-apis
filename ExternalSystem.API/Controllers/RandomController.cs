using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExternalSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        [HttpPost]
        public IActionResult Get(Ping ping)
        {
            var headers = new List<string>();

            foreach (var header in Request.Headers)
                headers.Add($"{header.Key}: {header.Value}");

            return Ok(new { Headers = headers, Data = ping });
        }
    }

    public class Ping {
        public string Message { get; set; }
    }
}