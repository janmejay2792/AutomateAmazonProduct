using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BrowseApplication.src;


namespace BrowseApplication
{
    [TestFixture]
    class _1_Amazon_Application
    {
        IWebDriver driver;
        static void main(string[] args) {
        }
        // Browse the Application
        [SetUp]
        public void setUp() {
            Browser browser = new Browser();
            browser.SelectBrowseForExecution();
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            Assert.Equals("Amazon", driver.FindElement(By.XPath("//span[text()='Amazon']")).GetAttribute("text"));

        }


        //Do the functionality what to need 
        [Test]
        public void searchProduct() {


            // Serach the Product in Amazon Website
            AmazonSearchProduct amazon = new AmazonSearchProduct();
            amazon.searchEdit("HP Laptop");

        }


        //Tear Down the Application
        public void tearDown() {
            driver.Quit();
        }


    }
}
