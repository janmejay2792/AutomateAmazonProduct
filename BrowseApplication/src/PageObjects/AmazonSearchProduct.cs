using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowseApplication
{
    class AmazonSearchProduct
    {
        IWebDriver driver;
        public AmazonSearchProduct() {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
                  }

        [FindsBy(How = How.Name, Using = "field-keywords")]
        private IWebElement SearchBox { get; set; }
        // Search the product in Edit Field
        public void searchEdit(string product) {
            if(SearchBox.Displayed && SearchBox.Enabled)
            SearchBox.SendKeys(product);
        }


    }
}
