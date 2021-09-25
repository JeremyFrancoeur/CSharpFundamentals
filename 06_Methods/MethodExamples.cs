using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Methods
{
    [TestClass]
    public class MethodExamples
    {
        [TestMethod]
        public void MethodExecution()
        {
            SayHello("Jeremy");
            int methodReturn = AddTwoNumbers(1, 2);
            Console.WriteLine(methodReturn);
            
            AddTwoNumbers(3.0, 4.0);
            AddTwoNumbers(3, 2.55);


            int age = CaculateAge(new DateTime(1892, 11, 24));
            Console.WriteLine($"My age is: {age}");
  

        }
        //Access Modifier (public in this on)
        //Return Type (void in this one)
        //Nethod Signature (a name "Say hello" and Parameters inside () 
           //Building = Parameters / Call Arugments
        //Body- the actual code
        [TestMethod]
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello world. And Hello {name}!");
        }
        [TestMethod]
        public int AddTwoNumbers(int numOne,int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        [TestMethod]
        public double AddTwoNumbers(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;

        }

        [TestMethod]
        public int CaculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            doubble totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
                 
        }
    }
}
