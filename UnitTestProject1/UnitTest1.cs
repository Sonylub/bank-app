using BankAccountManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // Проверка того, что новая операция добавляется в историю
        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            var history = new OperationHistory();

            // Act
            history.Add("Пополнение", 50);

            // Assert
            var ops = history.GetAll();
            Assert.AreEqual(1, ops.Count);
            Assert.AreEqual("Пополнение", ops[0].type);
            Assert.AreEqual(50, ops[0].sum);
        }

        // Проверка, что история очищается и добавляется запись "Очистка истории" с балансом
        [TestMethod]
        public void TestClear()
        {
            // Arrange
            var history = new OperationHistory();
            history.Add("Создание", 100);
            decimal balance = 200;

            // Act
            history.Clear(balance);

            // Assert
            var ops = history.GetAll();
            Assert.AreEqual(1, ops.Count);
            Assert.AreEqual("Очистка истории", ops[0].type);
            Assert.AreEqual(200, ops[0].sum);
        }

        // Проверка, что метод GetAll возвращает все операции из истории
        [TestMethod]
        public void TestGet()
        {

            // Arrange
            var history = new OperationHistory();
            history.Add("Создание", 100);
            history.Add("Пополнение", 50);

            // Act
            var ops = history.GetAll();

            // Assert
            Assert.AreEqual(2, ops.Count);
            Assert.AreEqual("Создание", ops[0].type);
            Assert.AreEqual("Пополнение", ops[1].type);
        }

        // Проверка того что, что операция создается с правильными типом, суммой и временем
        [TestMethod]
        public void TestMakeOperation()
        {
            // Arrange
            string type = "Тест";
            decimal sum = 100;

            // Act
            var op = new Operation(type, sum);

            // Assert
            Assert.AreEqual(type, op.type);
            Assert.AreEqual(sum, op.sum);
            Assert.IsNotNull(op.time);
        }
    }
}