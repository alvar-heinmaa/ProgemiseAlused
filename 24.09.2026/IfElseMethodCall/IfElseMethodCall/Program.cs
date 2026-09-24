namespace IfElseMethodCall
{
    internal class Program
    {
        //Meil on meetod, mis läheb alati esimesena tööle
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //kasutada ja else.
            //kui kasutaja soovib, siis saab ta meetodi välja kutsuda
            Console.WriteLine("kui sooid meetotit välja kutsuda, siis kirjuta ja");
            string method = Console.ReadLine();

            if (method == "ja")
            {
                //kui kirjutan meetodi nime, siis seda nimetatakse
                //meetodi välja kutsumiseks
                Hellomethod();
            }
            else
            {
                Console.WriteLine("Ei soovinud midagi");
            }
            }
        //teha teine meetod siia ja nimeks on sellel HelloMethod
        static void Hellomethod()
        {
            Console.WriteLine("Hello Kitty");
        }
    }
}
    

