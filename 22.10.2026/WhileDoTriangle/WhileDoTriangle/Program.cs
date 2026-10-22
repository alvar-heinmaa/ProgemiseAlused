namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmnurk");
            //ostida internetis while koodiga kolmnurga
            //kujundeid e tegmise viise
            //2.kui kood on leitud, siis kirjuta see siia
            //3. teha vooskeem
            {
                Console.WriteLine("Kolmnurk");
                int n = Convert.ToInt32(Console.ReadLine());
                int i = 1;

                do
                {
                    int j = 1;
                    do
                    {
                        Console.Write(j + " ");
                        j++;
                    } while (j <= i);

                    Console.WriteLine();
                    i++;
                } while (i <= n);
            }
        }
    }
}
