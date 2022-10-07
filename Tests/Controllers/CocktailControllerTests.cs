using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
using NUnit.Framework;


namespace API_Interactive_Lab_1.Tests   
{
    public class CocktailControllerTests
    {
        [Test]
        public void Test_Get_NoParams()
        {
            string expectedContent = "Thirsty?";
            var controller = new CocktailController();
            var result = controller.GetCocktailNoParams();
            Assert.AreEqual(expectedContent, result);
        }

        [Test]
        public void Test_Get_Cocktail_By_Name()
        {
            string name = "Margarita";
            Cocktail expected = new (name, 15);

            var controller = new CocktailController();
            var result = controller.Get(name);
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Price, result.Price);
        }

        [Test]
        public void Test_Get_Cocktail_By_NotExistingName()
        {
            string name = "Soup";
            Cocktail expected = new("Water", 0);

            var controller = new CocktailController();
            var result = controller.Get(name);
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Price, result.Price);
        }
    }
}
