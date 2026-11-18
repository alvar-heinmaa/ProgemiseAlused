namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Korrutustabel");

            int k, i, n;

            Console.WriteLine("Sisesta tabelisse number, mis on viimane korrutis");

            //kaks for loopi ja üks teise sees.
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                for (i = 1; i <= 10; i++)
                {
                    for (k = 1; k <= n; k++)
                    {
                        int tulemus = i * k;
                        if (tulemus < 10)
                        {
                            Console.Write(k + "x" + i + " = " + tulemus + ", ");
                        }
                        else
                        {
                            Console.Write(k + "x" + i + " = " + tulemus + ", ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Viga!");
            }
        }
    }
}
