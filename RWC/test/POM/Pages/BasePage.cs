using System;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace Test.POM
{
    class BasePage
    {
        #region Elements


        private static IWebElement searchInputField
        {
            get { return Driver.GetElement(By.Id("twotabsearchtextbox")); }
        }

        private static IWebElement searchButton
        {
            get { return Driver.GetElement(By.ClassName("nav-input")); }
        }
        
        private static IList<IWebElement> findWebElements
        {
            get { return Driver.Instance.FindElements(By.ClassName("s-result-item"));
            }
        }
        
        #endregion

        #region Methods

        public static bool DetermineIfElementsArePositiveInt()
        {
            return (findWebElements.Count > 0);   
        }

        public static void OpenUrl()
        {
            Driver.Instance.Navigate().GoToUrl(StaticComponents.Url);
        }

        public static void ClickSearchButton()
        {
            searchButton.Click();
        }

        public static void SendTerm(string testTerm)
        {
            searchInputField.SendKeys(testTerm);
        }

        public static bool ResultsPageContains(string resultsPageData)
        {
           return Driver.Instance.PageSource.Contains(resultsPageData);
        }
        #endregion 
    }
}