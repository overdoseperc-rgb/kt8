namespace SumCalculator;

public static class Calculator
{
    public static int SumChecked(int[] numbers)
    {
        int sum = 0;

        try
        {
            foreach (int number in numbers)
            {
                sum = checked(sum + number);
            }

            return sum;
        }
        catch (OverflowException)
        {
            Console.WriteLine("Предупреждение: сумма превышает диапазон int.");
            return int.MaxValue;
        }
    }

    public static int ParseOrZero(string input)
    {
        return int.TryParse(input, out int result) ? result : 0;
    }
}
