using System;

namespace TerracorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            LocationNumerals locationNumerals = new LocationNumerals();

            Console.WriteLine("Location Numerals of 9 is " + locationNumerals.IntegerToLocationNumeral(9).ToString());
            Console.WriteLine("Integer value of ad is " + locationNumerals.LocationNumeralToInteger("ad"));
            Console.WriteLine("Abbreviated form of abbc is " + locationNumerals.ToAbbreviate("abbc").ToString());
            
        }
    }
}
