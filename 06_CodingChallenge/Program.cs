using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CodingChallenge
{
    class Program
    {
        static void Main(string[] args
        {


            string superCopy = "Supercalifragilisticexpialidocious";
            string superLongWord = superCopy.ToLower();
            foreach (char letter in superLongWord)
            {
                Console.WriteLine(letter);
            }

            foreach (char letter in superLongWord)
            {
                string writeLine = (letter == 'i') ? "i" : "not an i";
                    Console.WriteLine(writeLine);

            }
            Console.WriteLine(superLongWord.Length);


            foreach(char letter in superLongWord)
            {
                string writeLine = (letter == 'i' || letter 'l') ? letter.ToString() : "Not an i.";
                Console.WriteLine(writeLine);
            }




            string words = ("Supercalifragilisticexpialidocious");
            foreach (char word in words)
            { 
                Console.WriteLine(word);
            }

           
            string letters = ("Supercalifragilisticexpialidocious");
            foreach (char letter in letters)
            {
                if (letter == 'i')
                {
                    Console.WriteLine("i");
                }

                else
                {
                    Console.WriteLine("Not an i.");

                }
     


            }



          
            
                

          

            Console.ReadKey();
        }


    }
}
