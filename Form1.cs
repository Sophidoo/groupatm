namespace AtmMachineDesktop
{
    public partial class Form1 : Form
    {
        AccountModel account = new AccountModel();
           
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void submitCard_Click(object sender, EventArgs e)
        {
            if(accNo.TextLength < 10)
            {
                MessageBox.Show("Please Input a valid account number");
            }else if(accPin.TextLength < 4)
            {
                MessageBox.Show("Please Enter your 4 digit pin");
            }
            else
            {
                Form2 form = new Form2(account);
                account.setAccountNumber(accNo.Text);
                account.setAccountPin(accNo.Text);
                this.Hide();
                form.Show();
            }

        }
    }
}