using System.Threading.Channels;

namespace ForLoopPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loome tärnidest püramiidi");
            Console.WriteLine("-------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Sisesta suurus:");


            //teha for loopiga püramiid
            int i, j, n;
            n = Convert.ToInt16(Console.ReadLine());

            // Teemandi ülemine pool
            for (i = 1; i <= n; i++)
            {
                // Trükib tühikud enne tärne
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                // Trükib tärnid
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            // Teemandi alumine pool
            for (i = n - 1; i >= 1; i--)
            {
                // Trükib tühikud enne tärne
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                // Trükib tärnid
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

        }
    }
}
