using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmMachineDesktop
{
    public partial class Form2 : Form
    {
        public AccountModel account;
        public int count;
        Form1 forms = new Form1();

        private void Form2_Load(object sender, EventArgs e)
        {
            accBalance.Text = "$" + Convert.ToString(account.getAccountBalance()) + ".00";
        }


        public Form2(AccountModel account)
        {
            InitializeComponent();
            this.account = account;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(1);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(2);
        }

        private void withdraw_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(3);
            accBalance.Text = "$" + Convert.ToString(account.getAccountBalance()) + ".00";

        }

        private void label4_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(4);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(5);
        }

           
        private void label6_Click(object sender, EventArgs e)
        {
            forms.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if(account.getAccountBalance() < 500)
            {
                tabControl.SelectTab(6);
                alertText.Text  = "Insufficient Balance";
            }
            else
            {
                double newBalance = account.getAccountBalance() - 500;
                account.setAccountBalance(newBalance);
                tabControl.SelectTab(6);
                alertText.Text = "Transfer Successful";
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (account.getAccountBalance() < 30000)
            {
                tabControl.SelectTab(6);
                alertText.Text  = "Insufficient Balance";
            }
            else
            {
                double newBalance = account.getAccountBalance() - 30000;
                account.setAccountBalance(newBalance);
                tabControl.SelectTab(6);
                alertText.Text = "Transfer Successful";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (account.getAccountBalance() < 1000)
            {
                tabControl.SelectTab(6);
                alertText.Text  = "Insufficient Balance";
            }
            else
            {
                double newBalance = account.getAccountBalance() - 1000;
                account.setAccountBalance(newBalance);
                tabControl.SelectTab(6);
                alertText.Text = "Transfer Successful";
            }
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (account.getAccountBalance() < 2000)
            {
                tabControl.SelectTab(6);
                alertText.Text  = "Insufficient Balance";
            }
            else
            {
                double newBalance = account.getAccountBalance() - 2000;
                account.setAccountBalance(newBalance);
                tabControl.SelectTab(6);
                alertText.Text = "Transfer Successful";
            }
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (account.getAccountBalance() < 5000)
            {
                tabControl.SelectTab(6);
                alertText.Text  = "Insufficient Balance";
            }
            else
            {
                double newBalance = account.getAccountBalance() - 5000;
                account.setAccountBalance(newBalance);
                tabControl.SelectTab(6);
                alertText.Text = "Transfer Successful";
            }

            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (account.getAccountBalance() < 10000)
            {
                tabControl.SelectTab(6);
                alertText.Text  = "Insufficient Balance";
            }
            else
            {
                double newBalance = account.getAccountBalance() - 10000;
                account.setAccountBalance(newBalance);
                tabControl.SelectTab(6);
                alertText.Text = "Transfer Successful";
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (account.getAccountBalance() < 20000)
            {
                tabControl.SelectTab(6);
                alertText.Text  = "Insufficient Balance";
            }
            else
            {
                double newBalance = account.getAccountBalance() - 20000;
                account.setAccountBalance(newBalance);
                tabControl.SelectTab(6);
                alertText.Text = "Transfer Successful";
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (account.getAccountBalance() < 40000)
            {
                tabControl.SelectTab(6);
                alertText.Text  = "Insufficient Balance";
            }
            else
            {
                double newBalance = account.getAccountBalance() - 40000;
                account.setAccountBalance(newBalance);
                tabControl.SelectTab(6);
                alertText.Text = "Transfer Successful";
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(7);
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Hide();
            forms.Show();
        }

        private void submitPin_Click(object sender, EventArgs e)
        {
            count++;
            
            if(confirmPin.Text != account.getAccountPin() && count < 3)
            {
               MessageBox.Show("Incorrect Pin");
            }
            else if(count > 3){
                this.Hide();
                forms.Show();
            }
            else
            {
                count = 0;
                tabControl.SelectTab(0);
                confirmPin.Text = "";
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
        private void submitDeposit_Click(object sender, EventArgs e)
        {
            account.setAccountBalance(Convert.ToDouble(depositAmount.Text));
            tabControl.SelectTab(6);
            alertText.Text = "Transaction Successful";
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(receiverAccNumber.Text.Length != 10)
            {
                MessageBox.Show("Please enter a valid account number");
            }
            else if(receiverBank.Text.Length <= 0)
            {
                MessageBox.Show("Please enter the Beneficiary's bank");
            }
            else if(Convert.ToDouble(transferAmount.Text) < account.getAccountBalance())
            {
                MessageBox.Show("You don't have enough money for this transaction");
            }
            else if(transferAmount.Text.Length <= 0)
            {
                MessageBox.Show("Please Input Transfer Amount");
            }
            else
            {
                account.setBeneficiaryAccount(receiverAccNumber.Text);
                account.setBeneficiaryBank(receiverBank.Text);
                account.setTransferAmount(Convert.ToDouble(transferAmount.Text));
                tabControl.SelectTab(6);
                alertText.Text = "Transfer Successful";
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        private void label25_Click(object sender, EventArgs e)
        {
        }

        private void changeNewPin_Click(object sender, EventArgs e)
        {
            count++;
            if(oldPin.Text != account.getAccountPin() && count < 3)
            {
                MessageBox.Show("Old Pin Incorrect");
            }
            else if (newPin.Text != confirmNewPin.Text)
            {
                MessageBox.Show("Confirmation Pin doesn't match");
            }
            else{
                account.setAccountPin(confirmNewPin.Text);
                tabControl.SelectTab(6);
                alertText.Text = "Pin Successfully Changed";
            }
        }

        private void receiverBank_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void receiverAccNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void transferAmount_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
