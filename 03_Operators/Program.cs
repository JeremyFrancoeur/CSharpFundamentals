using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 7;
            int numTwo = 20;

            //Addition
            int sum = numOne + numTwo;
            Console.WriteLine(sum);

            //Subtraction
            int difference = numOne - numTwo;
            Console.WriteLine(difference);

            //Multiplication
            int product = numOne * numTwo;
            Console.WriteLine(product);

            //Division
            int quotient = numOne / numTwo;
            Console.WriteLine(quotient);

            //Remainder
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            //Timespan
            DateTime today = DateTime.Now;
            DateTime someDay = new DateTime(1997, 5, 6);
            TimeSpan timeSpan = today - someDay;
            Console.WriteLine(timeSpan);

            //Conversions
            //Casting Try to force type another type
            //type name = (casttype)value
            int five = 5;
            double doubleFive = (double)five;

            char a = 'a';
            int valueA = (int)a;
            Console.WriteLine(valueA);

            //can not cast this 
            //string myString = "this is my string.";
            //byte myByte = (byte)myString;

            decimal myMoney = 5.87m;
            int intMoney = (int)myMoney; //5

            //Conversion
            //type = Convert.ToType(Value);

            int intFive = 5;
            decimal decimalFive = Convert.ToDecimal(five);


            decimal deccimalTwo = 2.55m;
            int intTwo = Convert.ToInt32(decimalTwo); // 3

            //Parsing just for strings
            //type name = type.Parse(string)
            string decimalString = "5.69878";
            decimal decimalValue = decimal.Parse(decimalString);

            //is as and typeOf keywords to look up for Conversions


            //Comparison Operators
            Console.WriteLine("Enter your age.");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            Console.WriteLine("Enter in your name.");
            string userName = Console.ReadLine();

            bool equals = age == 41;
            Console.WriteLine("User is 41:" + equals);
            Console.WriteLine(equal);

            bool notEquals = age != 41;
            Console.WriteLine($"User is not 41.": + {notEquals});
            Console.WriteLine(notEquals);


            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine("Liasts are equal:" + listsAreEqual);


            //< > <=
            bool greaterThan = age > 12;
            bool greatThanOrEqual = age >= 55;
            bool lessThan = age < 1;
            bool lessThanOrEqual = age <= 99;


            bool orValue = equals || notEquals;

            //One side true to deliver a true bool (|| = OR)
            bool tOrT = true || true;
            bool tOrF = true || false;
            bool fOrT= false || true;
            bool fOrF = false || false;

            //Both sides have to be true to deliver a true bool (&& = AND)
            bool andValue = equals && notEquals;
             tOrT = true && true;
             tOrF = true && false;
             fOrT = false && true;
             fOrF = false && false;
            int x = 13;
            bool test = x < 44 && x > 10;
            Console.WriteLine(test);

            int y = 10;
            bool testTwo = y > 20 || y < 15; // is 10 greater than 20 OR is ten less than 15: True less than 15
            Console.WriteLine(testTwo);


            Console.ReadKey();

        }
    }
}
