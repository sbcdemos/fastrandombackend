using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ultra_Fast_backend.Controllers
{
    [ApiController]
    [Route("/api/func")]
    public class DeepPathDemoController : ControllerBase
    {
        [HttpGet]
        public ContentResult Get()
        {
            return 
                base.Content("<html><body><h3>Это некая базовая функция, которая работает не совсем так как нам нужно</h3></body></html>", "text/html", System.Text.Encoding.UTF8);
        }
    }
}