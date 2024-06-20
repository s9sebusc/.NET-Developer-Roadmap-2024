
using Command;

var calculatorProvider = new CalculatorProvider(); // Invoker
var calculator = new Calculator();                 // Receiver 

Console.WriteLine(calculator.CurrentValue);        // Result: 0

ICommand plusCommand = new PlusCommand(calculator, 99);
calculatorProvider.SetCommand(plusCommand);
calculatorProvider.ExecuteCommand();

Console.WriteLine(calculator.CurrentValue);        // Result: 99

ICommand minusCommand = new MinusCommand(calculator, 9);
calculatorProvider.SetCommand(minusCommand);
calculatorProvider.ExecuteCommand();
Console.WriteLine(calculator.CurrentValue);       // Result: 90

