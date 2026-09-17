namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int z = 10;

            if (z == 12)
            {
                Console.WriteLine("z võrdub 12");
            }
            else if (z < 12) 
            {
                if (z == 28)

                {
                    Console.WriteLine("z võrdub 28");
                }
                else
                {
                    Console.WriteLine("z on vahemikus 24 kuni 27 kuni 29 kuni lõpmatus");
                }

            }
            else
            {
                Console.WriteLine("Mingid kahtlased numbrid");
            }
        }
    }
}
