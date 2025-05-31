using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountManager;
using System;

namespace BankAccountManager.Tests
{
    [TestClass]
    public class BankAccountСlassTests
    {
        [TestMethod]
        // Возвращение имени владельца
        public void Test1_GetOwnerName_ReturnsCorrectName()
        {
            // Arrange
            var account = new BankAccount("user", 1000);

            // Act
            var result = account.GetOwnerName();

            // Assert
            Assert.AreEqual("user", result);
        }

        [TestMethod]
        // Проверка возврата баланса
        public void Test2_GetBalance_ReturnsCorrectBalance()
        {
            // Arrange
            var account = new BankAccount("user", 1000);

            // Act
            var result = account.GetBalance();

            // Assert
            Assert.AreEqual(1000, result);
        }

        [TestMethod]
        // Увеличение баланса
        public void Test3_Deposit_IncreasesBalance()
        {
            // Arrange
            var account = new BankAccount("user", 1000);

            // Act
            account.Deposit(500);

            // Assert
            Assert.AreEqual(1500, account.GetBalance());
        }

        [TestMethod]
        // Уменьшение баланса
        public void Test4_Withdraw_DecreasesBalance()
        {
            // Arrange
            var account = new BankAccount("user", 1000);

            // Act
            account.Withdraw(300);

            // Assert
            Assert.AreEqual(700, account.GetBalance());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Попытка внести отрицательную сумму
        public void Test5_Deposit_NegativeAmount_ThrowsException()
        {
            // Arrange
            var account = new BankAccount("user", 1000);

            // Act
            account.Deposit(-100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Попытка снять отрицательную сумму
        public void Test6_Withdraw_NegativeAmount_ThrowsException()
        {
            // Arrange
            var account = new BankAccount("user", 1000);

            // Act
            account.Withdraw(-100);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        // Попытка снять больше денег, чем есть
        public void Test7_Withdraw_InsufficientFunds_ThrowsException()
        {
            // Arrange
            var account = new BankAccount("user", 1000);

            // Act
            account.Withdraw(1001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Создание счёта с отрицательным балансом
        public void Test8_CreateAccount_NegativeBalance_ThrowsException()
        {
            var account = new BankAccount("user", -500);
        }
    }

    [TestClass]
    public class BoundaryTests
    {
        [TestMethod]
        // Баланс не должен меняться при внесении 0 денег
        public void Test1_Deposit_ZeroAmount_BalanceUnchanged()
        {
            // Arrange
            var account = new BankAccount("user", 1000);

            // Act
            account.Deposit(0);

            // Assert
            Assert.AreEqual(1000, account.GetBalance());
        }

        [TestMethod]
        // Баланс не должен меняться при снятии 0 денег
        public void Test2_Withdraw_ZeroAmount_BalanceUnchanged()
        {
            // Arrange
            var account = new BankAccount("user", 1000);

            // Act
            account.Withdraw(0);

            // Assert
            Assert.AreEqual(1000, account.GetBalance());
        }

        [TestMethod]
        // Создание счёта с нулевым балансом
        public void Test3_CreateAccount_ZeroBalance_Success()
        {
            // Arrange & Act
            var account = new BankAccount("user", 0);

            // Assert
            Assert.AreEqual(0, account.GetBalance());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Попытка внести больше лимита
        public void Test4_Deposit_OverLimit_ThrowsException()
        {
            // Arrange
            var account = new BankAccount("user", 1000);

            // Act
            account.Deposit(1000001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Попытка снять больше лимита
        public void Test5_Withdraw_OverLimit_ThrowsException()
        {
            // Arrange
            var account = new BankAccount("user", 1000);

            // Act
            account.Withdraw(1000001);
        }
 
    }
}