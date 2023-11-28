using DataSourceApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace DataSourceApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "DataSource")]
        public IActionResult Get()
        {
            if(Request.Headers["X-Api-Key"] == "apiKey123123!@#")
            {
                List<FakeDataSourceModel> myObjectsList = new List<FakeDataSourceModel>
        {
            new FakeDataSourceModel
            {
                Id = 1,
                Name = "Object 1",
                Description = "This is the first object",
                NestedObject = new NestedObjectModel
                {
                    NestedId = 101,
                    NestedName = "Nested Object 1",
                    NestedDescription = "This is the nested object within Object 1"
                }
            },
            new FakeDataSourceModel
            {
                Id = 2,
                Name = "Object 2",
                Description = "This is the second object",
                NestedObject = new NestedObjectModel
                {
                    NestedId = 102,
                    NestedName = "Nested Object 2",
                    NestedDescription = "This is the nested object within Object 2"
                }
            },
            new FakeDataSourceModel
            {
                Id = 3,
                Name = "Object 3",
                Description = "This is the third object",
                NestedObject = new NestedObjectModel
                {
                    NestedId = 103,
                    NestedName = "Nested Object 3",
                    NestedDescription = "This is the nested object within Object 3"
                }
            },
            new FakeDataSourceModel
            {
                Id = 4,
                Name = "Object 4",
                Description = "This is the fourth object",
                NestedObject = new NestedObjectModel
                {
                    NestedId = 104,
                    NestedName = "Nested Object 4",
                    NestedDescription = "This is the nested object within Object 4"
                }
            }
        };
                return Ok(myObjectsList); 
            }
            else
            {
                return BadRequest();
            }
        }
    }
}