using System;

namespace Problema_9
{
    internal class Program
    {
        //You are given an integer CC representing a temperature measured in Celsius degrees.Find the value of CC in Fahrenheit degrees, and print it with no decimals.
        private static void Main(string[] args) => Console.WriteLine(((Int32)(Int32.Parse(Console.ReadLine()) * 1.8 + 32)).ToString());
    }
}