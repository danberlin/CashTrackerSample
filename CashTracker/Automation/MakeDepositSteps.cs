using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CashTracker
{
    [Binding]
    public class MakeDepositSteps
    {
        [Given(@"I have \$(.*) in cash")]
        public void GivenIHaveInCash(Decimal p0)
        {
            // Create a new tracker with the initial balance.
            var tracker = new PettyCashTracker(p0);
            ScenarioContext.Current["PettyCashTracker"] = tracker;

            Assert.That(tracker.CashOnHand == p0, "Initial balance was not correct.");
        }
                
        [When(@"I deposit \$(.*) into the tracker")]
        public void WhenIDepositIntoTheTracker(Decimal p0)
        {
            // Create a new default tracker if one is not created by a given step
            var tracker = ScenarioContext.Current.ContainsKey("PettyCashTracker") 
                ? ScenarioContext.Current["PettyCashTracker"] as PettyCashTracker 
                : new PettyCashTracker(0);

            try
            {
                tracker.MakeDeposit(p0);
            }
            catch (Exception exception)
            {
                ScenarioContext.Current["LastError"] = exception.Message;
            }
        }

        [Then(@"I should have \$(.*) in cash")]
        public void ThenIShouldHaveInCash(Decimal p0)
        {
            var tracker = ScenarioContext.Current["PettyCashTracker"] as PettyCashTracker;
            Assert.That(tracker, Is.Not.Null);
            Assert.That(tracker.CashOnHand, Is.EqualTo(p0));
        }
        
        [Then(@"I should get an error that says ""(.*)""")]
        public void ThenIShouldGetAnErrorThatSays(string p0)
        {
            Assert.That(ScenarioContext.Current.ContainsKey("LastError"), "No error was generated!");
            Assert.That(ScenarioContext.Current["LastError"], Is.EqualTo(p0));
        }
    }
}
