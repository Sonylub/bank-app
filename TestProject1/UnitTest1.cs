using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

[TestClass]
public class BankAccountUITests
{
    private FlaUI.Core.Application _app;
    private UIA3Automation _automation;
    private Window _mainWindow;

    [TestInitialize]
    public void TestInitialize()
    {
        // Запуск приложения
        _app = FlaUI.Core.Application.Launch(@"C:\Users\3291922-1\Desktop\bank-app\bank\bin\Debug\bank.exe");
        _automation = new UIA3Automation();
        _mainWindow = _app.GetMainWindow(_automation);
    }

    [TestCleanup]
    public void TestCleanup()
    {
        _automation?.Dispose();
        _app?.Close();
    }

    // TC-002: Проверка создания счёта с отрицательной суммой
    [TestMethod]
    public void TestCreateAccountWithNegativeAmount()
    {
        // Arrange
        var nameTextBox = _mainWindow.FindFirstDescendant(cf => cf.ByAutomationId("nameTextBox")).AsTextBox(); // Строка 39
        var amountTextBox = _mainWindow.FindFirstDescendant(cf => cf.ByAutomationId("amountTextBox")).AsTextBox(); // Строка 40
        var createButton = _mainWindow.FindFirstDescendant(cf => cf.ByAutomationId("createButton")).AsButton(); // Строка 41

        // Act
        nameTextBox.Enter("test");
        amountTextBox.Enter("-50");
        createButton.Click();

        // Assert
        var messageBox = _mainWindow.ModalWindows.FirstOrDefault(); // Строка 45
        var msgText = messageBox.FindFirstDescendant(cf => cf.ByAutomationId("65535")).AsLabel(); // Строка 46
        StringAssert.Contains(msgText.Text, "Начальная сумма не может быть отрицательной.");
        var okButton = messageBox.FindFirstDescendant(cf => cf.ByAutomationId("2")).AsButton(); // Строка 48
        okButton.Click();
    }