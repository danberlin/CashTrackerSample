using TechTalk.SpecFlow;

namespace CashTracker.Automation
{
    [Binding]
    public class AddUserAccountSteps
    {
        [Given(@"there are no user accounts in the tracker")]
        public void GivenThereAreNoUserAccountsInTheTracker()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"there is a user account ""(.*)""")]
        public void GivenThereIsAUserAccount(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"user account ""(.*)"" has \$(.*)")]
        public void GivenUserAccountHas(string p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I add the user account ""(.*)""")]
        public void WhenIAddTheUserAccount(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I set the active user to ""(.*)""")]
        public void WhenISetTheActiveUserTo(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I can set the active user to ""(.*)""")]
        public void ThenICanSetTheActiveUserTo(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
