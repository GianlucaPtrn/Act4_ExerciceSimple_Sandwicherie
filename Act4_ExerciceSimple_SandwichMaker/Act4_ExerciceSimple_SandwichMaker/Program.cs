using System;

namespace Act4_ExerciceSimple_SandwichMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SandwichMaker sandwich = new SandwichMaker();
            string reload = "";

            Console.WriteLine("Bienvenu dans notre concepteur de de sandwich !!");
            Console.WriteLine();

            Console.WriteLine(" Vous composer un sandwich ! ");
            Console.WriteLine();

            Console.WriteLine(SandwichMaker.SentenceSandwich());
            Console.WriteLine();

            while (reload == "oui")
            {
                Console.WriteLine("Voulez vous composer un sandwich ? oui: 'oui' et non: n'importe quelle autre touche !");
                Console.WriteLine(" -> oui: 'oui' ");
                Console.WriteLine(" -> non: appuyer sur n'importe quelle autre touche !");
                reload = Console.ReadLine();

                Console.WriteLine(SandwichMaker.SentenceSandwich());
            }

            Console.ReadLine();
        }
    }
}
