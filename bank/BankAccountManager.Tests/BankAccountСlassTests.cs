using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountManager;
using System;

namespace BankAccountManager.Tests
{
    [TestClass]
    public class BankAccountСlassTests
    {
        [TestMethod]
        public void Test1_GetOwnerName_ReturnsCorrectName()
        {
            var account = new BankAccount("user", 1000);
            var result = account.GetOwnerName();
            Assert.AreEqual("user", result);
        }

        [TestMethod]
        public void Test2_GetBalance_ReturnsCorrectBalance()
        {
            var account = new BankAccount("user", 1000);
            var result = account.GetBalance();
            Assert.AreEqual(1000, result);
        }

        [TestMethod]
        public void Test3_Deposit_IncreasesBalance()
        {
            var account = new BankAccount("user", 1000);
            account.Deposit(500);
            Assert.AreEqual(1500, account.GetBalance());
        }

        [TestMethod]
        public void Test4_Withdraw_DecreasesBalance()
        {
            var account = new BankAccount("user", 1000);
            account.Withdraw(300);
            Assert.AreEqual(700, account.GetBalance());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test5_Deposit_NegativeAmount_ThrowsException()
        {
            var account = new BankAccount("user", 1000);
            account.Deposit(-100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test6_Withdraw_NegativeAmount_ThrowsException()
        {
            var account = new BankAccount("user", 1000);
            account.Withdraw(-100);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test7_Withdraw_InsufficientFunds_ThrowsException()
        {
            var account = new BankAccount("user", 1000);
            account.Withdraw(1001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test8_CreateAccount_NegativeBalance_ThrowsException()
        {
            var account = new BankAccount("user", -500);
        }
    }

    [TestClass]
    public class BoundaryTests
    {
        [TestMethod]
        public void Test1_Deposit_ZeroAmount_BalanceUnchanged()
        {
            var account = new BankAccount("user", 1000);
            account.Deposit(0);
            Assert.AreEqual(1000, account.GetBalance());
        }

        [TestMethod]
        public void Test2_Withdraw_ZeroAmount_BalanceUnchanged()
        {
            var account = new BankAccount("user", 1000);
            account.Withdraw(0);
            Assert.AreEqual(1000, account.GetBalance());
        }

        [TestMethod]
        public void Test3_CreateAccount_ZeroBalance_Success()
        {
            var account = new BankAccount("user", 0);
            Assert.AreEqual(0, account.GetBalance());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test4_Deposit_OverLimit_ThrowsException()
        {
            var account = new BankAccount("user", 1000);
            account.Deposit(1000001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test5_Withdraw_OverLimit_ThrowsException()
        {
            var account = new BankAccount("user", 1000);
            account.Withdraw(1000001);
        }
    }
}