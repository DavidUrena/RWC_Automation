using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace Test
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }


        public static void Initialize()
        {

            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromMinutes(5));
        }

        public static void Terminate()
        {
            Instance.Quit();
        }

        public static IWebElement GetElement(By by)
        {
            try
            {
                return Driver.Instance.FindElement(by);
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }
    }
}