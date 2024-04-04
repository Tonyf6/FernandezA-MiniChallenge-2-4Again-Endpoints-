using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FernandezA_MiniChallenge_2_4Again_Endpoints_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MathController : ControllerBase
    {
        [HttpGet("add")]
        public IActionResult Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return Ok($"The sum of {num1} and {num2} is {sum}.");
        }
        
         [HttpGet("nameTime")]
        public IActionResult NameTime(string name, string wakeupTime)
        {
            return Ok($"So {name}, you woke up at {wakeupTime}?");
        }

        [HttpGet("greaterthanLessthan")]
        public IActionResult GreaterThanLessThan(int num1, int num2)
        {
            string comparison1, comparison2;
            if (num1 > num2)
                comparison1 = "greater than";
            else if (num1 < num2)
                comparison1 = "less than";
            else
                comparison1 = "equal to";

            if (num2 > num1)
                comparison2 = "greater than";
            else if (num2 < num1)
                comparison2 = "less than";
            else
                comparison2 = "equal to";

            return Ok($"{num1} is {comparison1} the {num2}.\n{num2} is {comparison2} the {num1}.");
        }
    }
}