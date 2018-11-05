using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace BrowseApplication
{
    [TestFixture]
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("heklo");
        }
        IWebDriver driver;
        [Test]
        public void launch() {
            Console.WriteLine("Hello");
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://demo.guru99.com/test/newtours/register.php");
            UtilityFunction fun = new UtilityFunction();

            IWebElement firstName = driver.FindElement(By.XPath("//*[@name='firstName']"));
            fun.editBox(driver, firstName, "Hello World");
            Thread.Sleep(2000);
            IWebElement dD = driver.FindElement(By.XPath("//*[@name='country']"));
            SelectElement selectEle = new SelectElement(dD);
            selectEle.SelectByIndex(10);




        }


    }
}
