﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowseApplication.src
{
    public class Browser
    {

        
        public IWebDriver SelectBrowseForExecution() {

             String browser = "Chrome";
            IWebDriver driver = null;

            switch (browser)
            {
                case "Chrome":
                    Console.WriteLine("Launching Chrome Browsert");
                    driver = new ChromeDriver();
                    break;
                case "Firefox":
                    driver= new FirefoxDriver();
                    Console.WriteLine("Launching FireFox Browsert");
                    break;
                case "IE":
                    Console.WriteLine("Launching FireFox Browsert");
                    break;
                default:
                    Console.WriteLine("Chrome Browser Launching");
                    driver = new ChromeDriver();
                    break;
            }return driver;

        }
        
    }
}
