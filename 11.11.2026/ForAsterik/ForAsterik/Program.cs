namespace ForAsterik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //tuleb kasutada for loopi
            //sisestan konsooli ridade arvu ja prindib vastavald ridade arvule tärne 
            //kasutada for loopi
            //teha vooskeem

            Console.Write("Sisesta ridade arv: ");
            int ridadeArv = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= ridadeArv; i++)
            {

                {
                    Console.WriteLine("*");
                }
            }
        }
    }
}
