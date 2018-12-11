// file:	StartUpFormUITest.cs
//
// summary:	Implements the start up form user interface test class

using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace POSOrderingSystemUITests
{
    /// <summary>   Summary description for CodedUITest1. </summary>
    ///
    /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

    [CodedUITest]
    public class StartUpFormUITest
    {
        /// <summary>   Full pathname of the file. </summary>
        private const string FILE_PATH = @"POSOrderingSystem\POSOrderingSystem\bin\Debug\POSOrderingSystem.exe";
        /// <summary>   The position ordering system title. </summary>
        private const string POS_ORDERING_SYSTEM_TITLE = "StartUpForm";

        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        public StartUpFormUITest()
        {
        }

        /// <summary>   (Unit Test Method) coded user interface test method. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod]
        public void CodedUITestMethod()
        {
            RunScriptPOSCustomerSideForm();
            Robot.SetForm("StartUpForm");
            RunScriptPOSRestaurantSideForm();
        }

        #region Additional test attributes

        /// <summary>   Use TestInitialize to run code before running each test. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestInitialize()]
        public void Initialize()
        {
            var solutionPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            var filePath = Path.Combine(solutionPath, FILE_PATH);
            Robot.Initialize(filePath, POS_ORDERING_SYSTEM_TITLE);
        }

        /// <summary>   /Use TestCleanup to run code after each test has run. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestCleanup()]
        public void Cleanup()
        {
            Robot.CleanUp();
        }

        #endregion

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for the
        /// current test run.
        /// </summary>
        ///
        /// <value> The test context. </value>

        public TestContext TestContext { get; set; }

        /// <summary>   Gets the map. </summary>
        ///
        /// <value> The user interface map. </value>

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        /// <summary>   Executes the script add operation. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        private void RunScriptPOSCustomerSideForm()
        {
            Robot.ClickButton("Start the Customer Program (Frontend)");
            Robot.SetForm("POSCustomerSideForm");
            Robot.ClickButton("Add");
            Robot.ClickButton("00");
            Robot.ClickButton("Add");
            Robot.DeleteDataGridViewRowByIndex("DGV", "1");
            Robot.ClickButton("Next Page");
            Robot.ClickButton("Previous Page");
            Robot.ClickTabControl("飲料");
            Robot.ClickButton("20");
            Robot.AssertEdit("description", "我是敘述0\r");
        }

        /// <summary>   Executes the script add operation. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        private void RunScriptPOSRestaurantSideForm()
        {
            Robot.ClickButton("Start the Restaurant Program (Backend)");
            Robot.SetForm("POSRestaurantSideForm");
            Robot.ClickButton("Add New Meal");
            Robot.ClickButton("Delete Selected Meal");
            Robot.SetComboBox("comboBox", "飲料");
            Robot.ClickButton("Browse...");
            Robot.CloseWindow("開啟");
            Robot.ClickTabControl("Category Manager");
        }
        /// <summary>   The map. </summary>
        private UIMap map;
    }
}
