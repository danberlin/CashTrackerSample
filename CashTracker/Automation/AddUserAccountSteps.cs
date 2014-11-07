using System.Runtime.InteropServices;
using System.Windows.Controls.Primitives;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CashTracker.Automation
{
    [Binding]
    public class AddUserAccountSteps
    {
        private static PettyCashTracker tracker;

        [Before]
        public void Setup()
        {
            // Create a new tracker with no users or money
            tracker = new PettyCashTracker(0);
        }

        [Given(@"there are no user accounts in the tracker")]
        public void GivenThereAreNoUserAccountsInTheTracker()
        {
            // Nothing needs to be done here
        }

        [Given(@"there is a user account ""(.*)""")]
        public void GivenThereIsAUserAccount(string p0)
        {
            tracker.AddUserAccount(p0);
        }

        [Given(@"user account ""(.*)"" has \$(.*)")]
        public void GivenUserAccountHas(string p0, int p1)
        {
            tracker.SetActiveUser(p0);
            tracker.MakeDeposit(p1);
        }

        [When(@"I add the user account ""(.*)""")]
        public void WhenIAddTheUserAccount(string p0)
        {
            tracker.AddUserAccount(p0);
        }

        [When(@"I set the active user to ""(.*)""")]
        public void WhenISetTheActiveUserTo(string p0)
        {
            tracker.SetActiveUser(p0);
        }

        [Then(@"I can set the active user to ""(.*)""")]
        public void ThenICanSetTheActiveUserTo(string p0)
        {
            tracker.SetActiveUser(p0);
        }
    }
}
