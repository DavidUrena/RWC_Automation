using TechTalk.SpecFlow;
using Test;

namespace PollAutomation.Hooks
{
    [Binding]
    public sealed class TestFixtureHooks
    {
        [BeforeScenario]
        public void Initialize()
        {
            Driver.Initialize();
        }

        [AfterScenario]
        public void Terminate()
        {
            Driver.Terminate();
        }
    }
}