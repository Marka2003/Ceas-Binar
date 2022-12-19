using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _S1_P1
{
    internal class Program
    {
        static void Main(string[]args)
        {

            Console.Write(Convert.ToString(System.DateTime.Now.Hour));
            Console.Write(":");
            Console.Write(Convert.ToString(System.DateTime.Now.Minute));
            Console.Write(":");
            Console.WriteLine(Convert.ToString(System.DateTime.Now.Second));
            Console.Write(Convert.ToString(System.DateTime.Now.Hour, 2));
            Console.Write(":");
            Console.Write(Convert.ToString(System.DateTime.Now.Minute, 2));
            Console.Write(":");
            Console.WriteLine(Convert.ToString(System.DateTime.Now.Second, 2));
            Console.ReadKey();
        }
    }
    
}