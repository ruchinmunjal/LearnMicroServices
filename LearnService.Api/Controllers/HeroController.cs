using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LearnService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroController : ControllerBase
    {
        

        private readonly ILogger<HeroController> _logger;
        // GET
        public HeroController(ILogger<HeroController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        public IEnumerable<Hero> Get()
        {

            return new List<Hero>()
            {
                new Hero()
                {
                    Name = "Bruce Wayne",
                    HeroName = "Batman",
                    SuperPowers = new List<SuperPower>()
                    {
                        new SuperPower()
                        {
                            Name = "Rich",
                            Strength = 10,
                            SuperPowerType = SuperPowerType.Natural
                        }
                    }
                },new Hero()
                {
                    Name = "Clark Kent",
                    HeroName = "Superman",
                    SuperPowers = new List<SuperPower>()
                    {
                        new SuperPower()
                        {
                            Name = "Flying",
                            Strength = 10,
                            SuperPowerType = SuperPowerType.SuperNatural
                        },
                        new SuperPower()
                        {
                            Name = "Heat Vision",
                            Strength = 8,
                            SuperPowerType = SuperPowerType.SuperNatural
                        }
                    }
                }
            };
        }
    }
}