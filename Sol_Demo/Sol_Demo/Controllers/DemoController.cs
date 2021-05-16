using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sol_Demo.CustomExceptions;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/demo")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpPost("problem-demo")]
        public IActionResult DemoProblemDetails([FromBody] DemoModel demoModel)
        {
            // Demo Purpose
            //if (demoModel.Cost >= 100) return base.BadRequest(new ProblemDetails()
            //{
            //    Title = "Cost should not be more than 100.",
            //    Status = StatusCodes.Status400BadRequest
            //});

            //return Ok();

            // Demo Purpose - Custom Exception
            throw new OutofCreditException("You do not have enough credit.", cost: demoModel.Cost, balance: 30);
        }
    }
}