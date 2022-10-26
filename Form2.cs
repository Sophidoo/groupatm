using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Form1 forms = new Form1();
            forms.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if(account.getAccountBalance() < 500)
            {
                tabControl.SelectTab(6);
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
            tabControl.SelectTab(0);
        }

        private void submitPin_Click(object sender, EventArgs e)
        {
            count++;
            if (confirmPin.Text.Length != 4)
            {
                MessageBox.Show("Please enter your 4 digit pin");
            }
            
            if(confirmPin.Text != account.getAccountPin() && count < 3)
            {
                
                
                MessageBox.Show("Incorrect Pin");
            }
            else if(count > 3){
                tabControl.SelectTab(0);
            }
            else
            {
                count = 0;
                tabControl.SelectTab(1);
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
