using System;
using System.Text.RegularExpressions;

namespace madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] libs = new string[5];
            string[] desc = { "emotion", "game", "game", "s.o", "emotion" };
            int i;

            Console.WriteLine("Welcome to the MadLib! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Ah, welcome " + name + "!" + " get ready for the MadLib!");

            for (i = 0; i < 5; i++ )
            {
                Console.WriteLine("Give me a " + desc[i] + " word");
                libs[i] = Console.ReadLine();
               
            }

            Console.WriteLine("I really really " + libs[0] + " playing board games! From " + libs[1] + " to " + libs[2] + " my sweetie " + libs[3] + " and I really " + libs[4] + " playing games together!");


            */
            
            string[] red = { "one", "two", "three" }; // this is the array w strings inside
            var input = "hey ___ hey ___ hey ___";    // this is the string with spaces I wanna remove
            var counter = 0;                          // a counter variable
            var substring = Regex.Escape("___");      // telling Regex what I wanna pull out          
            var result = Regex.Replace(input, substring, (m) =>$"{red[counter++]}");
            Console.WriteLine(result);
                
           
           
            
            

            


        }




    }
}
