using System.Linq;
using API_Interactive_Lab_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("cocktails")]
    public class CocktailController : ControllerBase
    {
        private readonly Cocktail[] cocktailArray = new Cocktail[] { new("Mojito", 10), new("Cosmopolitan", 20), new("Margarita", 15)};

        [HttpGet("{name}")]
        public Cocktail Get(string? name)
        {
            Cocktail cocktail = new("Water", 0);
            if (cocktailArray.Any(c => c.Name == name))
                cocktail = cocktailArray.Where(c => c.Name == name).First(); ;

            return cocktail;
        }

        [HttpGet("")]
        public string GetCocktailNoParams()
        {
            return "Thirsty?";
        }
    }
}
