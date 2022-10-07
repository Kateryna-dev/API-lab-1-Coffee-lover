using System.Linq;
using API_Interactive_Lab_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("coffee")]
    public class CoffeeController : ControllerBase

    {
        private Coffee[] coffeeArray = new Coffee[] { new (1,"espresso"), new (2, "americano"), new(7, "cappuccino") };

        [HttpGet("{name}")]
        public Coffee Get(string? name)
        {
            Coffee coffee = new(-1, "latte");
            if (coffeeArray.Any(c => c.Name == name))
                coffee = coffeeArray.Where(c => c.Name == name).First(); ;

            return coffee;
        }

        [HttpGet("")]
        public Coffee GetCoffeeNoParam()
        {
            return new (-1, "latte");
        }

        [HttpGet("lover")]
        public string GetCoffeeLover()
        {
            return "I like coffee!";
        }
    }
}
