using System;

namespace madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the MadLib! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Ah, welcome " + name + "!" + " get ready for the MadLib!");
            Console.WriteLine("Give me an emotion word.");
            string emo = Console.ReadLine();
            Console.WriteLine("Give me a board game name.");
            string board1 = Console.ReadLine();
            Console.WriteLine("Give me another board game name.");
            string board2 = Console.ReadLine();
            Console.WriteLine("Give me the name of someone close to you.");
            string ally = Console.ReadLine();
            Console.WriteLine("Finally, give me another emotion word.");
            string emo2 = Console.ReadLine();
            Console.WriteLine("I really really " + emo + " playing board games! From " + board1 + " to " + board2 + ", my " + ally + " and I " + emo2 + " playing board games!");

           
           
        }
    }
}
