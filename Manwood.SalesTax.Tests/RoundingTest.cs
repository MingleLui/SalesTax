using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Manwood.SalesTax.Domain;

namespace Manwood.SalesTax.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class RoundingTest
    {
        public RoundingTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void RoundingUpTest()
        {
            Rounding rounding = new Rounding(0.05M);
            decimal rounded = rounding.Round(1.24M);
            Assert.AreEqual(1.25M, rounded);
        }

        [TestMethod]
        public void RoundingUpDefaultMidpointTest()
        {
            Rounding rounding = new Rounding(0.05M);
            decimal rounded = rounding.Round(1.225M);
            Assert.AreEqual(1.25M, rounded);
        }

        [TestMethod]
        public void RoundingDownTest()
        {
            Rounding rounding = new Rounding(0.05M);
            decimal rounded = rounding.Round(1.22M);
            Assert.AreEqual(1.20M, rounded);
        }
    }
}
