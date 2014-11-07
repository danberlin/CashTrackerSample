using System;
using System.Collections.Generic;
using NUnit.Framework;

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

        private List<string> _userAccounts = new List<string>();
        private string _activeUser = null;

        public void AddUserAccount(string name)
        {
            _userAccounts.Add(name);
        }

        public void SetActiveUser(string name)
        {
            if (_userAccounts.Contains(name))
                _activeUser = _userAccounts.Find(match => match.Equals(name));
        }
    }
}