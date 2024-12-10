using System;

class Program
{
    static void Main(string[] args)
    {
        // Лямбда-вираз у делегаті Func
        Func<int, int, int> squareOfProduct = (a, b) => (a * b) * (a * b);

        // Виклик лямбда-виразу
        Console.Write("Введіть перше число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int num2 = int.Parse(Console.ReadLine());

        // Обчислення результату
        int result = squareOfProduct(num1, num2);

        // Виведення результату
        Console.WriteLine($"Квадрат добутку чисел {num1} і {num2} дорівнює {result}");
    }
}
