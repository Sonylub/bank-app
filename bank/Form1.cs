using System;
using System.Windows.Forms;

namespace BankAccountManager
{
    public partial class BankAccountForm : Form
    {
        private BankAccount account;
        private TextBox nameTextBox;
        private TextBox amountTextBox;
        private Label balanceLabel;
        private Button createAccountButton;
        private Button depositButton;
        private Button withdrawButton;
        private Label nameLabel;
        private Label amountLabel;

        public BankAccountForm()
        {
            this.Text = "Управление банковским счётом";
            this.Size = new System.Drawing.Size(400, 300);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            nameLabel = new Label
            {
                Location = new System.Drawing.Point(10, 10),
                Width = 200,
                Text = "Имя владельца"
            };

            nameTextBox = new TextBox
            {
                Location = new System.Drawing.Point(10, 30),
                Width = 250,
                Text = "Введите имя владельца"
            };
            nameTextBox.Enter += (s, e) => { if (nameTextBox.Text == "Введите имя владельца") nameTextBox.Text = ""; };
            nameTextBox.Leave += (s, e) => { if (string.IsNullOrEmpty(nameTextBox.Text)) nameTextBox.Text = "Введите имя владельца"; };

            amountLabel = new Label
            {
                Location = new System.Drawing.Point(10, 60),
                Width = 200,
                Text = "Сумма"
            };

            amountTextBox = new TextBox
            {
                Location = new System.Drawing.Point(10, 80),
                Width = 250,
                Text = "Введите сумму"
            };
            amountTextBox.Enter += (s, e) => { if (amountTextBox.Text == "Введите сумму") amountTextBox.Text = ""; };
            amountTextBox.Leave += (s, e) => { if (string.IsNullOrEmpty(amountTextBox.Text)) amountTextBox.Text = "Введите сумму"; };

            createAccountButton = new Button
            {
                Location = new System.Drawing.Point(10, 110),
                Text = "Создать счёт",
                Width = 80
            };
            createAccountButton.Click += CreateAccountButton_Click;

            depositButton = new Button
            {
                Location = new System.Drawing.Point(100, 110),
                Text = "Пополнить",
                Width = 80
            };
            depositButton.Click += DepositButton_Click;

            withdrawButton = new Button
            {
                Location = new System.Drawing.Point(190, 110),
                Text = "Снять",
                Width = 80
            };
            withdrawButton.Click += WithdrawButton_Click;

            balanceLabel = new Label
            {
                Location = new System.Drawing.Point(10, 140),
                Width = 200,
                Text = "Баланс: 0"
            };

            this.Controls.Add(nameLabel);
            this.Controls.Add(nameTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(amountTextBox);
            this.Controls.Add(createAccountButton);
            this.Controls.Add(depositButton);
            this.Controls.Add(withdrawButton);
            this.Controls.Add(balanceLabel);
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) || nameTextBox.Text == "Введите имя владельца")
            {
                MessageBox.Show("Введите имя владельца!");
                return;
            }
            if (string.IsNullOrEmpty(amountTextBox.Text) || amountTextBox.Text == "Введите сумму")
            {
                MessageBox.Show("Введите начальную сумму!");
                return;
            }
            decimal initialBalance;
            if (!decimal.TryParse(amountTextBox.Text, out initialBalance))
            {
                MessageBox.Show("Неверный формат суммы!");
                return;
            }
            account = new BankAccount(nameTextBox.Text, initialBalance);
            balanceLabel.Text = $"Баланс: {initialBalance}";
            MessageBox.Show("Счёт создан!");
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            if (account == null)
            {
                MessageBox.Show("Сначала создайте счёт!");
                return;
            }
            if (string.IsNullOrEmpty(amountTextBox.Text) || amountTextBox.Text == "Введите сумму")
            {
                MessageBox.Show("Введите сумму для пополнения!");
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
                account.Deposit(amount);
                balanceLabel.Text = $"Баланс: {account.GetBalance()}";
                MessageBox.Show("Счёт пополнен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            if (account == null)
            {
                MessageBox.Show("Сначала создайте счёт!");
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
                balanceLabel.Text = $"Баланс: {account.GetBalance()}";
                MessageBox.Show("Средства сняты!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}