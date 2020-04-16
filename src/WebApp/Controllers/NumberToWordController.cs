using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Services.Interfaces;
using Services.Models;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberToWordController : ControllerBase
    {

        [HttpGet("{number:int}")]
        public ActionResult<ResponseModel> NumberToWord([FromServices] INumberToWord numberToWordService,
            [FromServices] IConfiguration configuration, int number)
        {

            return Ok(new ResponseModel
            {
                Data = numberToWordService.ToWord(number),
                AppEnvironment = GetEnvironmentVariable("APPENVIRONMENT"),
                AppHost = GetEnvironmentVariable("APPHOST")
            });
        }

        private string GetEnvironmentVariable(string name)
            => Environment.GetEnvironmentVariable(name.ToLower()) ?? Environment.GetEnvironmentVariable(name.ToUpper());
    }
}
