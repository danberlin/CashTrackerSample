using System;

namespace CashTracker
{
    public class PettyCashTracker
    {
        public PettyCashTracker(decimal initialBalance)
        {
            CashOnHand = initialBalance;
        }

        public decimal CashOnHand { get; private set; }

        public void MakeDeposit(decimal depositAmount)
        {
            if (depositAmount < 1)
                throw new Exception("The minimum deposit is $1.00");

            CashOnHand += depositAmount;
        }

        public void MakeWithdrawal(decimal withdrawalAmount)
        {
            if (withdrawalAmount < 1)
                throw new Exception("The minimum withdrawal is $1.00");

            if (withdrawalAmount > CashOnHand)
                throw new Exception("Insufficient funds available");

            CashOnHand -= withdrawalAmount;
        }

        public void AddUserAccount(string name)
        {
            throw new NotImplementedException();
        }

        public void SetActiveUser(string name)
        {
            throw new NotImplementedException();
        }
    }
}