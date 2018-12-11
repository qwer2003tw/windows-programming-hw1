// file:	Model\MealTests.cs
//
// summary:	Implements the meal tests class

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace POSOrderingSystem.Model.Tests
{
    /// <summary>   (Unit Test Class) a meal tests. </summary>
    ///
    /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

    [TestClass()]
    public class MealTests
    {
        /// <summary>   The meal. </summary>
        Meal meal;

        /// <summary>   Tests initialize. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

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

        /// <summary>   (Unit Test Method) tests get button text. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetButtonTextTest()
        {
            var actual = meal.GetButtonText();
            var expected = $"TestName{Environment.NewLine}${99}{"元"}";
            meal.Name = meal.Name + "1";
            meal.Name = meal.Name + "1";
            Assert.AreEqual(expected, actual);
        }

        /// <summary>   (Unit Test Method) tests clone. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void CloneTest()
        {
            var actual = meal.Clone();
            var expected = meal;
            Assert.AreNotEqual(expected, actual);
        }
    }
}