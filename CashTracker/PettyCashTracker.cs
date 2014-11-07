using System;
using System.Collections.Generic;

namespace CashTracker
{
    public class PettyCashTracker
    {
        public PettyCashTracker(decimal initialBalance)
        {
            CashOnHand = initialBalance;
        }

        private decimal _anonymousCashOnHand;

        public decimal CashOnHand
        {
            get {
                return _activeUser == null ? _anonymousCashOnHand : _userAccounts[_activeUser];
            }

            private set
            {
                if (_activeUser == null)
                    _anonymousCashOnHand = value;
                else
                    _userAccounts[_activeUser] = value;
            }
        }

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

        private Dictionary<string, decimal> _userAccounts = new Dictionary<string, decimal>();
        private string _activeUser;

        public void AddUserAccount(string name)
        {
            _userAccounts.Add(name, 0);
        }

        public void SetActiveUser(string name)
        {
            if (_userAccounts.ContainsKey(name))
                _activeUser = name;
        }
    }
}