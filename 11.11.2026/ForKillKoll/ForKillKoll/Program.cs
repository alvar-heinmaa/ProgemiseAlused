namespace ForKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Eelnevaid teadmisi kasutades kirjuta programm, mis väljastaks:
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //for loopi sees peab olema for loop
            //peab saama sisestada arvu, mitu korda soovib väljundit korrata
            //iga kord, kui hakkb väljundit kordama, siis näitab rea numbrit 
            Console.WriteLine("kui palju kordab");
            int kordab = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= kordab; i++)
            {
                Console.WriteLine("See on rida nr {0}", i);
                for (int j = 0; j < 3; j++)
                {
                    if (j == 2)
                    {
                        Console.WriteLine("killadi - koll");
                    }
                    else
                    {
                        Console.WriteLine( "kill - koll");
                    }

                }

            }
        }
    }
}
