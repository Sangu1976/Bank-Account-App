using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bank_Account_App
{
    public partial class Form1 : Form
    {
        List<Bank_Account> BankAccounts = new List<Bank_Account>();

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OwnerTxt.Text))
            {
                MessageBox.Show("Please enter a valid owner name.");
                return;
            }

            Bank_Account bankAccount = new Bank_Account(OwnerTxt.Text);
            BankAccounts.Add(bankAccount);
            RefreshGrid();
            OwnerTxt.Text = string.Empty;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                // Use nullable type for selectedBankAccount
                Bank_Account? selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as Bank_Account;

                if (selectedBankAccount != null)
                {
                    string message = selectedBankAccount.Deposit(AmountNum.Value);
                    RefreshGrid();
                    AmountNum.Value = 0;
                    MessageBox.Show(message);
                }
            }
            else
            {
                MessageBox.Show("Please select an account and enter a valid amount.");
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                // Use nullable type for selectedBankAccount
                Bank_Account? selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as Bank_Account;

                if (selectedBankAccount != null)
                {
                    string message = selectedBankAccount.Withdraw(AmountNum.Value);
                    RefreshGrid();
                    AmountNum.Value = 0;
                    MessageBox.Show(message);
                }
            }
            else
            {
                MessageBox.Show("Please select an account and enter a valid amount.");
            }
        }

        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = BankAccounts;
        }
    }
}
