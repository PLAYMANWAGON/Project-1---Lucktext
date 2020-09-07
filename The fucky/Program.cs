using System;

namespace Luck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till min fursona creator" + Environment.NewLine);

            Console.WriteLine("Tryck enter för att fortsätta");

            Console.ReadLine();

            Console.Clear();


            string name;
            string age;
            string color;




            Console.WriteLine("Vad Heter Du? ");

            name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Hur gammal är din mamma? ");

            age = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Favorit färg? ");

            color = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Du heter " + name + " och är musky husky." + Environment.NewLine);
            Console.WriteLine("Tryck enter för att fortsätta");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Inom 5 dagar ska du fylla " + age + " år, och kommer få massor presenter av mamma." + Environment.NewLine);
            Console.WriteLine("Tryck enter för att fortsätta");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Din pälsfärg är " + color + " och är folk gillar att klappa dig." + Environment.NewLine);
            Console.WriteLine("Tryck enter för att fortsätta");
            Console.ReadLine();
            Console.Clear();

        }


    }
}
