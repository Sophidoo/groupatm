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
        private string beneficiaryBank;
        private string beneficiaryAccount;
        private double transferAmount;

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

        public void setBeneficiaryBank(string benBank)
        {
            this.beneficiaryBank = benBank;
        }
        public string getBeneficiaryBank()
        {
            return beneficiaryBank;
        }

        public void setBeneficiaryAccount(string benAcc)
        {
            this.beneficiaryAccount = benAcc;
        }
        public string getBeneficiaryAccount()
        {
            return beneficiaryAccount;
        }

        public void setTransferAmount(double amount)
        {
            this.transferAmount = amount;
        }
        public double getTransferAmount()
        {
            return transferAmount;
        }
    }
}
