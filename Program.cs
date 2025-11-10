internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"5 + 3 = {Calculator.Add(5, 3)}");
        Console.WriteLine($"5 - 3 = {Calculator.Subtract(5, 3)}");
        Console.WriteLine($"5 * 3 = {Calculator.Multiply(5, 3)}");
        Console.WriteLine($"5 / 3 = {Calculator.Divide(5, 3)}");
        Console.WriteLine($"5 / 0 = {Calculator.Divide(5, 0)}");
    }

}
internal class Calculator
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("На ноль делить нельзя");
            return double.NaN;
        }
        else
        {
            return a / b;
        }
    }
}