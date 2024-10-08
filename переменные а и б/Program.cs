//Михайлова Виктория. ИСП-232о. Задание:переменные

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace переменные_а_и_б
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Онлайн калькулятор");
            Console.Write("Введите значение a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите переменную с: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double sum = a + b;
            double difference = a - b;
            double product = a * b;
            double summ = (a + b) * c;
            Console.WriteLine($"Сумма a и b: {sum}");
            Console.WriteLine($"Разность a и b: {difference}");
            Console.WriteLine($"Произведение a и b: {product}");
            Console.WriteLine($"Выражение (а+b)*c: {summ}");
            Console.ReadLine();
        }
    }
}
