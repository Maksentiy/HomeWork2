namespace Task1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите ваше Имя");
        var name = Console.ReadLine();

        Console.WriteLine("Введите ваш возраст");
        var age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите ваш рост");
        var height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Привет, {name} \n\tВаш возраст: {age} \n\t\tВаш рост: {height} м.");
    }
}
