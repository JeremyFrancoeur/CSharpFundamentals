using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //While loop
            int total = 1;
            while (total != 10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }

            //For Loop
            //for(initialize variable; condition; do something with my variable)
            //i++ => i + 1;
            //i-- = i -1;
            //1-- => i = i - 1
            int studentCount = 5;
            for(int i = 0; i != studentCount; i++) 

            {
                Console.WriteLine(i);
            }

            //Foreach Loop
            List<string> students = new List<string>();
            students.Add("Andrew");
            students.Add("Anna");
            students.Add("Colin");
            students.Add("Danny");
            foreach(string student in students)
            {
                Console.WriteLine(student);
            }
            //array int can have  neg num.
            int[] numbers = { 1, 2, 3, 900, 1000, -56 };
            foreach (int number in numbers) ;
            {


            //DoWhile Loop
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello.");
                    iterator++;
            }
            while (iterator < 5);



        Console.ReadKey();
        }
    }
}
