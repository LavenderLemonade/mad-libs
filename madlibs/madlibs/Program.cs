using System;
using System.Text.RegularExpressions;

namespace madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] words = new string[10];
            string[] desc = { "emotion", "game", "game", "s.o", "emotion" };
            int i; 
            Regex regex = new Regex("[_]{1,}");
            string text = System.IO.File.ReadAllText(@"C:\Users\samue\Desktop\Sam's Folder\Coding Journey\CSharp\madlibs\madlib.txt");
            Console.WriteLine("Welcome to the MadLib! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Ah, welcome " + name + "!" + " get ready for the MadLib!");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Give me a " + desc[i] + " word");
                words[i] = Console.ReadLine();
                text = regex.Replace(text, words[i], 1);
            }
            Console.WriteLine(text);


           



        }




    }
}
