using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.UIA3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

[TestClass]
public class BankAccountUITests
{
    private FlaUI.Core.Application _app;
    private UIA3Automation _automation;
    private Window _mainWindow;

    [TestInitialize]
    public void TestInitialize()
    {
        Console.WriteLine("Starting application...");
        _app = FlaUI.Core.Application.Launch(@"C:\Users\Maxim\Desktop\bank-app\bank\bin\Debug\net8.0-windows\bank.exe");
        Console.WriteLine("Initializing automation...");
        _automation = new UIA3Automation();
        Console.WriteLine("Getting main window...");
        _mainWindow = _app.GetMainWindow(_automation);
        Assert.IsNotNull(_mainWindow, "Главное окно не найдено.");
    }

    [TestCleanup]
    public void TestCleanup()
    {
        Console.WriteLine("Cleaning up...");
        _automation?.Dispose();
        _app?.Close();
    }

    // TC-001: Проверка создания банковского счета с корректными данными
    [TestMethod]
    public void TestCreateAccountWithValidData()
    {
        var conditionFactory = new ConditionFactory(new UIA3PropertyLibrary());

        // Arrange
        var nameTextBox = _mainWindow.FindFirstDescendant(conditionFactory.ByAutomationId("nameTextBox"))?.AsTextBox();
        Assert.IsNotNull(nameTextBox, "Поле 'nameTextBox' не найдено.");

        var amountTextBox = _mainWindow.FindFirstDescendant(conditionFactory.ByAutomationId("amountTextBox"))?.AsTextBox();
        Assert.IsNotNull(amountTextBox, "Поле 'amountTextBox' не найдено.");

        var createButton = _mainWindow.FindFirstDescendant(conditionFactory.ByAutomationId("createAccountButton"))?.AsButton();
        Assert.IsNotNull(createButton, "Кнопка 'createAccountButton' не найдена.");

        var balanceLabel = _mainWindow.FindFirstDescendant(conditionFactory.ByAutomationId("balancelabel"))?.AsLabel();
        Assert.IsNotNull(balanceLabel, "Метка 'balancelabel' не найдена.");

        // Act
        nameTextBox.Text = "user";
        amountTextBox.Text = "100";
        createButton.Invoke();
        Thread.Sleep(500); // Задержка для рендеринга MessageBox

        // Assert
        var messageBox = _mainWindow.FindFirstDescendant(conditionFactory.ByControlType(FlaUI.Core.Definitions.ControlType.Window));
        Assert.IsNotNull(messageBox, "Модальное окно (MessageBox) не найдено.");

        var msgText = messageBox.FindFirstDescendant(conditionFactory.ByAutomationId("65535"))?.AsLabel();
        Assert.IsNotNull(msgText, "Текст сообщения в MessageBox не найден.");
        StringAssert.Contains(msgText.Text, "Счёт создан");

        var okButton = messageBox.FindFirstDescendant(conditionFactory.ByAutomationId("2"))?.AsButton();
        Assert.IsNotNull(okButton, "Кнопка 'OK' в MessageBox не найдена.");
        okButton.Invoke();

        StringAssert.Contains(balanceLabel.Text, "Баланс: 100");
    }

    // TC-002: Проверка создания счёта с отрицательной суммой
    [TestMethod]
    public void TestCreateAccountWithNegativeAmount()
    {
        var conditionFactory = new ConditionFactory(new UIA3PropertyLibrary());

        // Arrange
        var nameTextBox = _mainWindow.FindFirstDescendant(conditionFactory.ByAutomationId("nameTextBox"))?.AsTextBox();
        Assert.IsNotNull(nameTextBox, "Поле 'nameTextBox' не найдено.");

        var amountTextBox = _mainWindow.FindFirstDescendant(conditionFactory.ByAutomationId("amountTextBox"))?.AsTextBox();
        Assert.IsNotNull(amountTextBox, "Поле 'amountTextBox' не найдено.");

        var createButton = _mainWindow.FindFirstDescendant(conditionFactory.ByAutomationId("createAccountButton"))?.AsButton();
        Assert.IsNotNull(createButton, "Кнопка 'createAccountButton' не найдена.");

        // Act
        nameTextBox.Text = "test";
        amountTextBox.Text = "-50";
        createButton.Invoke();
        Thread.Sleep(500); // Задержка для рендеринга MessageBox

        // Assert
        var messageBox = _mainWindow.FindFirstDescendant(conditionFactory.ByControlType(FlaUI.Core.Definitions.ControlType.Window));
        Assert.IsNotNull(messageBox, "Модальное окно (MessageBox) не найдено.");

        var msgText = messageBox.FindFirstDescendant(conditionFactory.ByAutomationId("65535"))?.AsLabel();
        Assert.IsNotNull(msgText, "Текст сообщения в MessageBox не найден.");
        StringAssert.Contains(msgText.Text, "Введите сумму");

        var okButton = messageBox.FindFirstDescendant(conditionFactory.ByAutomationId("2"))?.AsButton();
        Assert.IsNotNull(okButton, "Кнопка 'OK' в MessageBox не найдена.");
        okButton.Invoke();
    }
}