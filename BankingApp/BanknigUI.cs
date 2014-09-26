using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class BanknigUI : Form
    {
        public BanknigUI()
        {
            InitializeComponent();
        }
        Account anAccount = new Account();
        private void createButton_Click(object sender, EventArgs e)
        {
            
            anAccount.acNumber = accountNoTextBox.Text;
            anAccount.name = customerNameTextBox.Text;
            MessageBox.Show(anAccount.name+ ", Your Account Has Created!");
            createButton.Enabled = false;
            accountNoTextBox.Text = string.Empty;
            customerNameTextBox.Text= string.Empty;
        }

        private void depositeButton_Click(object sender, EventArgs e)
        {
            
            anAccount.Deposite(Convert.ToDouble(amountTextBox.Text));
            MessageBox.Show("Your Diposite amount is: "+ amountTextBox.Text +"Taka");
            amountTextBox.Text = string.Empty;
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            
            anAccount.Withdraw(Convert.ToDouble(amountTextBox.Text));
            MessageBox.Show("Your Withdrawal amount is: " + amountTextBox.Text + "Taka");
            amountTextBox.Text = string.Empty;
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(anAccount.name+", your account number: "+ anAccount.acNumber+ " and it's balance: " + anAccount.balance+ "Taka");
        }
    }
}
