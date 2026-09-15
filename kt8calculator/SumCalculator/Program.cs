using SumCalculator;

int[] numbers = { 1, 2, 3 };
Console.WriteLine($"Сумма: {Calculator.SumChecked(numbers)}");

int[] overflowNumbers = { int.MaxValue, 1 };
Console.WriteLine($"Сумма с переполнением: {Calculator.SumChecked(overflowNumbers)}");

Console.WriteLine("Введите число:");
string input = Console.ReadLine() ?? string.Empty;
Console.WriteLine($"Результат: {Calculator.ParseOrZero(input)}");
