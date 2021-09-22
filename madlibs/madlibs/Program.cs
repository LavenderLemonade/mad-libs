using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string text = System.IO.File.ReadAllText(@"C:\Users\samue\Desktop\Sam's Folder\Coding Journey\CSharp\madlibs\madlib.txt");
            int green = checkEmpty(text);
            string[] words = new string[green];
            string[] desc = { "emotion", "game", "game", "s.o", "emotion" };
            int i;
            Regex regex = new Regex("[_]{1,}");
            Console.WriteLine("Welcome to the MadLib! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Ah, welcome " + name + "!" + " get ready for the MadLib!");
            for (i = 0; i < green; i++)
            {
                Console.WriteLine("Give me a " + desc[i] + " word");
                words[i] = Console.ReadLine();
                text = regex.Replace(text, words[i], 1);
            }
            Console.WriteLine(text);
 
            static int checkEmpty(string input)
            {
                int blue = Regex.Matches(input, "[_]{1,}").Count;
                return blue;
            }
            
            // it's working





        }




    }
}
