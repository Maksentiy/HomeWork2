namespace Task2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число");
        var num1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Введите второе число");
        var num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"сумма: {num1 + num2}\tразность: {num1 - num2}\tпроизведение: {num1 * num2}\tчастное: {num1 / num2}");
    }
}
