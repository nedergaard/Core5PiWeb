using Core5PiWeb.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5PiWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingsController : ControllerBase
    {
        private readonly ILogger<GreetingsController> _logger;

        public GreetingsController(ILogger<GreetingsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Greeting Get()
        {
            return
                new Greeting
                {
                    Message = "Hello world!",
                };
        }
    }
}
