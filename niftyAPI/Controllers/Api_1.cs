using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using niftyAPI.Models;

namespace niftyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Api_1 : ControllerBase
    {

        // GET api/api_1//operation/value
        [HttpGet("{operation}/{value}")]
        public string GetQuery(string operation, int value)
        {
            StaticFunctions.HistoryInput(operation.Trim(),value);
            switch (operation)
            {
                case "sq":
                    return StaticFunctions.square(value).ToString();

                case "sqrt":
                    return StaticFunctions.squareRoot(value).ToString();

                case "fact":
                    return StaticFunctions.factorial(value).ToString();
                    
                case "fibbo":
                    return StaticFunctions.fibonacci(value).ToString();

                default:
                    return "Invalid Operation";
                    
            }

            //return $"{firstName}:{lastName}:{address}";
        }
    }
}
