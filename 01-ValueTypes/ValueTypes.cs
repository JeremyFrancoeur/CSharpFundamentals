using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_ValueTypes
{
    public enum PastryType
    {
        Cake,
        Danish,
        Croissant,
        Donut,
        Scone,
        Backlava,
    }
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void InitAndDeclareVariables()
        {
            // Declare a variable
            int numOne;
            numOne = 1;

            //Declare and initialize a variable
            int numTwo = 2;

            //Variable
            //named location in computer memeory AKA RAM

            //Stack vs Heap storage
        }
        [TestMethod]

        public void ValueTypesVariables()
        {
            //Whole numbers
            byte byteExample = 255;
            sbyte sByteExample = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            int intMax = 2147483647;
            Int32 anotherIntExample = 123456;
            long longMax = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            //Decimals
            double doubleExample = 1.23432; //can place a -d- but not need
            float floatExample = 1.79789f;
            decimal decimalExample = 1.457474747467m;

            Console.WriteLine(doubleExample);

            //Character
            char charExample = 'a';
            char number = '3';
            char symbol = '&';
            char space = ' ';
            char specialChar = '\n';

            //Bool
            bool isHungry = true;
            bool isTired = false;

            //Enum
            PastryType myPastry = PastryType.Backlava;

            //Structs
            DateTime today = DateTime.Now;
            Console.WriteLine(today);
        }
    }
}
