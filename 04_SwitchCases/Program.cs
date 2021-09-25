using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            //int input = 1;

            //switch (input)
            //{
            //    case 1:
            //        Console.WriteLine("Hello world.");
            //        break;
            //    case 2:
            //        Console.WriteLine("What are you doing?");
            //        break;
            //    default:
            //        Console.WriteLine("This is default. It will be executed if no other case is evaluated.");
            //        break;
            //}

            //DayOfWeek today = DateTime.Today.DayOfWeek;
            //switch (today)
            //{
            //    case DayOfWeek.Monday:
            //        Console.WriteLine("Welcome to the beginning of a work week.");
            //        break;
            //    case DayOfWeek.Tuesday:
            //    case DayOfWeek.Wednesday:
            //    case DayOfWeek.Thursday:
            //    case DayOfWeek.Friday:
            //        Console.WriteLine("Still working.");
            //        break;
            //    case DayOfWeek.Saturday:
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("It's the weekend.");
            //        break;

           // }


            Console.WriteLine("How are you feeling today? 5 being best and 1 being the worst.");
            //string respons = Console.ReadLine(response); //then response where readline is.
            int range = int.Parse(Console.ReadLine());

            switch (range)
            {
         
                case 1:
                    Console.WriteLine("You should go to a doctor!");
                    break;
                case 2:
                    Console.WriteLine("I hope you feel better.");
                    break;
                case 3:
                    Console.WriteLine("You should get some rest.");
                    break;
                case 4:
                    Console.WriteLine("Not to bad.");
                    break;
                case 5:
                    Console.WriteLine("That's great!");
                    break;
                default:
                    Console.WriteLine("1-5 please.");
                    break;
            }

            Console.WriteLine("How are you feeling today? 5 being best and 1 being the worst.");
            //string respons = Console.ReadLine(response); //then response where readline is.
            string response = Console.ReadLine();

            switch (response)
            {
                _case "1":
                     Console.WriteLine("You should go to a doctor!");
                break;
                case "2":
                    Console.WriteLine("I hope you feel better.");
                break;
                case "3":
                    Console.WriteLine("You should get some rest.");
                break;
                case "4":
                    Console.WriteLine("Not to bad.");
                break;
                case "5":
                    Console.WriteLine("That's great!");
                break;
                default:
                    Console.WriteLine("1-5 please.");
                break;

           }

            Console.ReadKey();

        }
    }
}
