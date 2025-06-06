using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankAccountManager
{
    public partial class BankAccountForm : Form
    {
        private Dictionary<string, BankAccount> accounts = new Dictionary<string, BankAccount>();
        private Dictionary<string, List<Operation>> ops = new Dictionary<string, List<Operation>>();

        public BankAccountForm()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || nameTextBox.Text == "Введите имя владельца")
            {
                MessageBox.Show("Введите имя!");
                return;
            }
            decimal balance;
            if (!decimal.TryParse(amountTextBox.Text, out balance))
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
                ops[name] = new List<Operation>();
                ops[name].Add(new Operation("Создание", balance));
                listBox1.Items.Add(name);
                balancelabel.Text = "Баланс: " + balance;
                MessageBox.Show("Счёт создан!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            if (!accounts.ContainsKey(nameTextBox.Text))
            {
                MessageBox.Show("Счёт не найден!");
                return;
            }
            decimal amount;
            if (!decimal.TryParse(amountTextBox.Text, out amount))
            {
                MessageBox.Show("Введите сумму!");
                return;
            }

            try
            {
                accounts[nameTextBox.Text].Deposit(amount);
                ops[nameTextBox.Text].Add(new Operation("Пополнение", amount));
                balancelabel.Text = "Баланс: " + accounts[nameTextBox.Text].GetBalance();
                MessageBox.Show("Счёт пополнен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            if (!accounts.ContainsKey(nameTextBox.Text))
            {
                MessageBox.Show("Счёт не найден!");
                return;
            }
            if (amountTextBox.Text == "" || amountTextBox.Text == "Введите сумму")
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
                accounts[nameTextBox.Text].Withdraw(amount);
                ops[nameTextBox.Text].Add(new Operation("Снятие", amount));
                balancelabel.Text = "Баланс: " + accounts[nameTextBox.Text].GetBalance();
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
            if (nameTextBox.Text == "")
                nameTextBox.Text = "Введите имя владельца";
        }

        private void AmountTextBox_Enter(object sender, EventArgs e)
        {
            if (amountTextBox.Text == "Введите сумму")
                amountTextBox.Text = "";
        }

        private void AmountTextBox_Leave(object sender, EventArgs e)
        {
            if (amountTextBox.Text == "")
                amountTextBox.Text = "Введите сумму";
        }

        private void ListBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string name = listBox1.SelectedItem.ToString();
                nameTextBox.Text = name;
                balancelabel.Text = "Баланс: " + accounts[name].GetBalance();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите счёт!");
                return;
            }
            string name = listBox1.SelectedItem.ToString();
            Form2 f = new Form2(ops[name]);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                ops[name].Clear();
                ops[name].Add(new Operation("Очистка истории", accounts[name].GetBalance()));
            }
        }
    }
}