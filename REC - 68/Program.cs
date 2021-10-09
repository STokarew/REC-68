using System;

namespace REC_68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите пол: ");
            string sex = (Console.ReadLine());

            Console.Write("Введите рост: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Возраст: {age} Имя: {name} Пол: {sex} Рост: {height}м  $");

            Console.ReadKey();
        }
    }
}
