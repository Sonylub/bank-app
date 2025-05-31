namespace BankAccountManager
{
    partial class BankAccountForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.balancelabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(26, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(200, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Имя владельца";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(26, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(250, 23);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.Text = "Введите имя владельца";
            this.nameTextBox.Enter += new System.EventHandler(this.NameTextBox_Enter);
            this.nameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // amountLabel
            // 
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(23, 82);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(200, 13);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "Сумма";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountTextBox.Location = new System.Drawing.Point(26, 99);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(250, 23);
            this.amountTextBox.TabIndex = 4;
            this.amountTextBox.Text = "Введите сумму";
            this.amountTextBox.Enter += new System.EventHandler(this.AmountTextBox_Enter);
            this.amountTextBox.Leave += new System.EventHandler(this.AmountTextBox_Leave);
            // 
            // createAccountButton
            // 
            this.createAccountButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createAccountButton.Location = new System.Drawing.Point(26, 128);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(80, 23);
            this.createAccountButton.TabIndex = 3;
            this.createAccountButton.Text = "Создать счёт";
            this.createAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depositButton.Location = new System.Drawing.Point(121, 128);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(80, 23);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "Пополнить";
            this.depositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.withdrawButton.Location = new System.Drawing.Point(217, 128);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(80, 23);
            this.withdrawButton.TabIndex = 1;
            this.withdrawButton.Text = "Снять";
            this.withdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.balancelabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.withdrawButton);
            this.groupBox1.Controls.Add(this.depositButton);
            this.groupBox1.Controls.Add(this.amountLabel);
            this.groupBox1.Controls.Add(this.amountTextBox);
            this.groupBox1.Controls.Add(this.createAccountButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 209);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(6, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 259);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(36, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 293);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список счетов:";
            // 
            // balancelabel
            // 
            this.balancelabel.AutoSize = true;
            this.balancelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.balancelabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balancelabel.Location = new System.Drawing.Point(25, 171);
            this.balancelabel.Name = "balancelabel";
            this.balancelabel.Size = new System.Drawing.Size(61, 20);
            this.balancelabel.TabIndex = 8;
            this.balancelabel.Text = "Баланс:";
            // 
            // BankAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(415, 541);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BankAccountForm";
            this.Text = "Управление банковским счётом";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label balancelabel;
    }
}