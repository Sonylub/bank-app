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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.balancelabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(10, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(200, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Имя владельца";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameTextBox.Location = new System.Drawing.Point(10, 36);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(250, 23);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.Text = "Введите имя владельца";
            this.nameTextBox.Enter += new System.EventHandler(this.NameTextBox_Enter);
            this.nameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // amountLabel
            // 
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.amountLabel.Location = new System.Drawing.Point(7, 70);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(200, 13);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "Сумма";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.amountTextBox.Location = new System.Drawing.Point(10, 87);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(250, 23);
            this.amountTextBox.TabIndex = 3;
            this.amountTextBox.Text = "Введите сумму";
            this.amountTextBox.Enter += new System.EventHandler(this.AmountTextBox_Enter);
            this.amountTextBox.Leave += new System.EventHandler(this.AmountTextBox_Leave);
            // 
            // createAccountButton
            // 
            this.createAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createAccountButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createAccountButton.Location = new System.Drawing.Point(10, 120);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(80, 30);
            this.createAccountButton.TabIndex = 4;
            this.createAccountButton.Text = "Создать счёт";
            this.createAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.depositButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.depositButton.Location = new System.Drawing.Point(90, 120);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(80, 30);
            this.depositButton.TabIndex = 5;
            this.depositButton.Text = "Пополнить";
            this.depositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdrawButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.withdrawButton.Location = new System.Drawing.Point(170, 120);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(80, 30);
            this.withdrawButton.TabIndex = 6;
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
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 200);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::bank.Properties.Resources._61122;
            this.pictureBox1.Location = new System.Drawing.Point(264, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // balancelabel
            // 
            this.balancelabel.AutoSize = true;
            this.balancelabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancelabel.Location = new System.Drawing.Point(9, 163);
            this.balancelabel.Name = "balancelabel";
            this.balancelabel.Size = new System.Drawing.Size(65, 18);
            this.balancelabel.TabIndex = 8;
            this.balancelabel.Text = "Баланс:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(6, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 214);
            this.listBox1.TabIndex = 1;
            this.listBox1.Click += new System.EventHandler(this.ListBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(10, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 260);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список счетов:";
            // 
            // BankAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BankAccountForm";
            this.Text = "Управление банковским счётом";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}