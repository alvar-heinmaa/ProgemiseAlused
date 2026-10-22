namespace Kontroltöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta korrudamis tehe");
            float number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("kirjuta esimene arv");
            Console.WriteLine("korrutamise märk * ");
            Console.WriteLine("kirjuta teine arv");
            float number2 = int.Parse(Console.ReadLine());
            string korrutis = Console.ReadLine();
            switch (korrutis)
            {
                case 1:
                    Console.WriteLine("Vastus" * (number1 * number2));
                    break;
                    Console.WriteLine("kui vana sa oled");
                case 2:
                    Console.WriteLine("sa oled 16 aastat vana");
                    break;
                default:
                    Console.WriteLine("sa oled 16 aastane");
                    break;
                    Console.WriteLine("sinule tuli sõnum");
                case 3:
                    Console.WriteLine("Miau");
                    break;
            }
        }
    }
}
