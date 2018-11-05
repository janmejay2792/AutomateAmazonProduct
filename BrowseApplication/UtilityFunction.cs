using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowseApplication
{

    class UtilityFunction
    {

        public void editBox(IWebDriver driver, IWebElement element, String value) {

            if (element != null && element.Displayed && element.Enabled)
                element.SendKeys(value);
            else
                Console.WriteLine("Object Not Found");

        

        }


    }
}
