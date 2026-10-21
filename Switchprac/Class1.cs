
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Vali number 1-7:");
        int number = Convert.ToInt32(Console.ReadLine());

        switch (number)
        {
            case 1:
                Console.WriteLine("Esmaspäev");
                break;

            case 2:
                Console.WriteLine("Teisipäev");
                break;

            case 3:
                Console.WriteLine("Kolmapäev");
                break;

            case 4:
                Console.WriteLine("Neljapäev");
                break;

            case 5:
                Console.WriteLine("Reede");
                break;

            case 6:
                Console.WriteLine("Laupäev");
                break;

            case 7:
                Console.WriteLine("Pühapäev");
                break;

            default:
                Console.WriteLine("Vale number!");
        }
    }
}


