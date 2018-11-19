using Microsoft.VisualStudio.TestTools.UnitTesting;
using POSOrderingSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSOrderingSystem.Model.Tests
{
    [TestClass()]
    public class MealTests
    {
        Meal meal;
        [TestInitialize()]
        public void TestInitialize()
        {
            meal = new Meal()
            {
                Category = new Category() { Name = "TestCategory" },
                Descript = "TestDescript",
                ImagePath = "Test/ImagePath.png",
                Name = "TestName",
                Price = 99
            };
        }
        [TestMethod()]
        public void GetButtonTextTest()
        {
            var actual = meal.GetButtonText();
            var expected = $"TestName{Environment.NewLine}${99}{"元"}";
            meal.Name = meal.Name + "1";
            meal.Name = meal.Name + "1";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CloneTest()
        {
            var actual = meal.Clone();
            var expected = meal;
            Assert.AreNotEqual(expected, actual);
        }
    }
}