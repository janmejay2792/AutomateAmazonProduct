using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowseApplication.src
{
    class Login
    {
        private IWebDriver driver;


        [FindsBy(How = How.XPath, Using = ".//*[@id='twotabsearchtextbox']")]
        private IWebElement Searchfield_XPATH { get; set; }

        public Login(IWebDriver driver) { 

         this.driver = driver;
          PageFactory.InitElements(driver, this);


           
    }

        



    }


}


    

