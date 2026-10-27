using System;

namespace Kontroltöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali tegevus:");
            Console.WriteLine("1 - Korrutamistehe");
            Console.WriteLine("2 - Kui vana sa oled");
            Console.WriteLine("3 - Sõnum Miau");

            int valik = int.Parse(Console.ReadLine());

            switch (valik)
            {
                case 1:
                    Console.WriteLine("Kirjuta esimene arv:");
                    float number1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Kirjuta teine arv:");
                    float number2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Vastus: " + (number1 * number2));
                    break;

                case 2:
                    Console.WriteLine("Kui vana sa oled?");
                    int vanus = int.Parse(Console.ReadLine());

                    Console.WriteLine("Sa oled " + vanus + " aastat vana.");
                    break;

                case 3:
                    Console.WriteLine("Miau");
                    break;

                default:
                    Console.WriteLine("Sellist valikut pole!");
                    break;
            }
        }
    }
}