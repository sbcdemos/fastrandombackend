using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ultra_Fast_backend.Controllers
{
    public class SimpleRandom {
        public int Value {get; set;}
        public string Message {get; set;}
    }
    [ApiController]
    [Route("")]
    public class HomeForecastController : ControllerBase
    {
        [HttpGet]
        public SimpleRandom Get()
        {
            var v=new Random();
            return new SimpleRandom{
                Value = v.Next(),
                Message = "This is simple random generator"
            };

        }
    }

}