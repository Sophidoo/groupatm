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
            double newBalance = account.getAccountBalance() - 500;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            
        }
    }
}
