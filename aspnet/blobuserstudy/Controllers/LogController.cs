using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blobuserstudy.Controllers
{
    [ApiController]
    [Route("/")]
    public class LogController : ControllerBase
    {
        private readonly ILogger<LogController> _logger;

        public LogController(ILogger<LogController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {

            // TODO: Complete this section to retrieve a list of blobs in a container

            var res = "A sample response";
            return res;
        }

        [HttpPost]
        public async Task<string> Post()
        {
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                var body = await reader.ReadToEndAsync();

                // TODO: Complete this section to upload the body ("log data") to a Blob
                return body;
            }
        }
    }
}
