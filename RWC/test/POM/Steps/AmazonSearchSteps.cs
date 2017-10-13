using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Test.POM.Steps
{
    [Binding]
    public class AsAUserICanEnterInTheSearchTermQaTestingInTheSearchBoxAndSeeSteps
    {
        [Given(@"I open Amazon\.com")]
        public void GivenIOpenAmazon_Com()
        {
            BasePage.OpenUrl();
        }

        [Given(@"I introduce the term qa testing")]
        public void GivenIIntroduceTheTermQaTesting()
        {
            BasePage.SendTerm("QA testing");
        }
        
        [When(@"I perform the search")]
        public void WhenIPerformTheSearch()
        {
            BasePage.ClickSearchButton();
        }
        
        [Then(@"I see the results in the search page")]
        public void ThenISeeTheResultsInTheSearchPage()
        {
            Assert.IsTrue(BasePage.DetermineIfElementsArePositiveInt());
        }
    }
}
