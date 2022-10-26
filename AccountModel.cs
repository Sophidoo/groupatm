using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmMachineDesktop
{
    public class AccountModel
    {
        private string accountNumber;
        private string accountPin;
        private double accountBalance;
        private string confirmAccountPin;


        public void setAccountNumber(string accNo)
        {
            this.accountNumber = accNo;
        }
        public string getAccountNumber()
        {
            return accountNumber;
        }


        public void setAccountPin(string pin)
        {
            this.accountPin = pin;
        }
        public string getAccountPin()
        {
            return accountPin;
        }


        public void setAccountBalance(double accBalance)
        {
            this.accountBalance = accBalance;
        }
        public double getAccountBalance()
        {
            return accountBalance;
        }


        public void setConfirmAccountPin(string accConfirmPin)
        {
            this.confirmAccountPin = accConfirmPin;
        }
        public string getConfirmAccountPin()
        {
            return confirmAccountPin;
        }
    }
}
