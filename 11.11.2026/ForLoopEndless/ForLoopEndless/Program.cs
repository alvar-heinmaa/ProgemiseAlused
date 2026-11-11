namespace ForLoopEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("i väärtus on");

            //teha for loopiga löputu tsükkel, mis prindib konsooli: i väärtus on: number

            //kui i väärtus on 10, siis tsükkel lõpeb
            //for loopi tingimus peab olema tühjaks jäetud, et see oleks löputu
            short i = 0;

            for (; ; )
            {
                Console.WriteLine("i väärtus on: " + i);

                if (i==10)
                {
                    break;
                }
                i++;
            }
        }
    }
}
