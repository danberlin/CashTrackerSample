using System;
using TechTalk.SpecFlow;

namespace CashTracker
{
    [Binding]
    public class MakeWithdrawalSteps
    {
        [When(@"I withdraw \$(.*) from the tracker")]
        public void WhenIWithdrawFromTheTracker(Decimal p0)
        {
            var tracker = ScenarioContext.Current.ContainsKey("PettyCashTracker") 
                ? ScenarioContext.Current["PettyCashTracker"] as PettyCashTracker 
                : new PettyCashTracker(0);

            try
            {
                tracker.MakeWithdrawal(p0);
            }
            catch (Exception exception)
            {
                ScenarioContext.Current["LastError"] = exception.Message;
            }
        }
    }
}
