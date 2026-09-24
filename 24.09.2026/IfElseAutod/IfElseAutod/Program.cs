using System.Threading.Channels;

namespace IfElseAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //kasuta if ja else
            //kirjuta automark 
            //valikus on BMW, Audi, Porsche, Fiat ja Skoda
            //Kui valitakse Skoda, siis seal sees on uuesti küsimus, et
            //mis mudelit soovid valida. Mudeli valikus on Kodiaq ja Octavia
            Console.WriteLine("sisesta automark");
            Console.WriteLine("valikus on BMW,Audi,Porsche, Fiat ja skoda");

            string mark = Console.ReadLine();

            if (mark == "BMW")
                Console.WriteLine("valisid on BMW");
            else if (mark == "Audi")
            {
                Console.WriteLine("valisid on Audi");
            }
            else if (mark == "Porsche")
            {
                Console.WriteLine("valisid Porsche");
            }
            else if (mark == "Fiat")
                Console.WriteLine("valisid on Fiat");
            else if (mark == "skoda")
                Console.WriteLine("valisid skoda");
            Console.WriteLine("Sisesta automudel, kas Kodiaq või Octavia");
            string model = Console.ReadLine();
            if (model == "Kodiaq")
                Console.WriteLine("valisid Octavia");
            else
                Console.WriteLine("Ei valinud autot");
        }
    }
}
