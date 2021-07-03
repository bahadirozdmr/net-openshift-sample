using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace campaign_service_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CampaignController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public CampaignController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        public IEnumerable<Campaign> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Campaign()
                {
                    Id = rng.Next(-20, 55),
                    Name = rng.Next(-20, 55).ToString() +"-Campaign",
                    CreateDate = DateTime.Now
                })
                .ToArray();
        }
    }
}