using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankAccountManager
{
    public partial class BankAccountForm : Form
    {
        private Dictionary<string, BankAccount> accounts = new Dictionary<string, BankAccount>();

        public BankAccountForm()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) || nameTextBox.Text == "Введите имя владельца")
            {
                MessageBox.Show("Введите имя!");
                return;
            }
            if (!decimal.TryParse(amountTextBox.Text, out decimal balance))
            {
                MessageBox.Show("Введите сумму!");
                return;
            }

            string name = nameTextBox.Text;
            if (accounts.ContainsKey(name))
            {
                MessageBox.Show("Счёт существует!");
                return;
            }

            try
            {
                accounts[name] = new BankAccount(name, balance);
                listBox1.Items.Add(name);
                balancelabel.Text = $"Баланс: {balance}";
                MessageBox.Show("Счёт создан!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            if (!accounts.TryGetValue(nameTextBox.Text, out BankAccount account))
            {
                MessageBox.Show("Счёт не найден!");
                return;
            }
            if (!decimal.TryParse(amountTextBox.Text, out decimal amount))
            {
                MessageBox.Show("Введите сумму!");
                return;
            }

            try
            {
                account.Deposit(amount);
                balancelabel.Text = $"Баланс: {account.GetBalance()}";
                MessageBox.Show("Счёт пополнен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            if (!accounts.TryGetValue(nameTextBox.Text, out BankAccount account))
            {
                MessageBox.Show("Счёт не найден!");
                return;
            }
            if (string.IsNullOrEmpty(amountTextBox.Text) || amountTextBox.Text == "Введите сумму")
            {
                MessageBox.Show("Введите сумму для снятия!");
                return;
            }
            decimal amount;
            if (!decimal.TryParse(amountTextBox.Text, out amount))
            {
                MessageBox.Show("Неверный формат суммы!");
                return;
            }
            try
            {
                account.Withdraw(amount);
                balancelabel.Text = $"Баланс: {account.GetBalance()}";
                MessageBox.Show("Средства сняты!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Введите имя владельца")
                nameTextBox.Text = "";
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
                nameTextBox.Text = "Введите имя владельца";
        }

        private void AmountTextBox_Enter(object sender, EventArgs e)
        {
            if (amountTextBox.Text == "Введите сумму")
                amountTextBox.Text = "";
        }

        private void AmountTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(amountTextBox.Text))
                amountTextBox.Text = "Введите сумму";
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string name = listBox1.SelectedItem.ToString();
                nameTextBox.Text = name;
                balancelabel.Text = $"Баланс: {accounts[name].GetBalance()}";
            }
        }
    }
}