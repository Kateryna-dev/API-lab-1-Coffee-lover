﻿using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
using NUnit.Framework;

namespace API_Interactive_Lab_1.Tests
{
    public class CoffeeControllerTests
    {
        [Test]
        public void Test_Get_CoffeeLover()
        {
            string expectedContent = "I like coffee!";
            var controller = new CoffeeController();
            var result = controller.GetCoffeeLover();
            Assert.AreEqual(expectedContent, result);
        }

        [Test]
        public void Test_Get_Coffee_No_Params()
        {
            Coffee expected = new Coffee(-1, "latte");

            var controller = new CoffeeController();
            var result = controller.Get(null);

            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
        [Test]
        public void Test_Get_Coffee_By_Name()
        {
            string name = "cappuccino";
            Coffee expected = new Coffee(7, name);

            var controller = new CoffeeController();
            var result = controller.Get(name);
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
    }
}
