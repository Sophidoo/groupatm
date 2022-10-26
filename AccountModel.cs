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
    }
}
