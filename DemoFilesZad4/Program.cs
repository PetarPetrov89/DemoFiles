using System;
using System.IO;

namespace DemoFilesZad4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text4 = File.ReadAllLines(@"D:\NetIt\DemoFiles\DemoFiles\file\text4.txt");

            string[] text3 = File.ReadAllLines(@"D:\NetIt\DemoFiles\DemoFiles\file\text3.txt");

            int equals = 0;
            int nonEquals = 0;

            for (int i = 0; i < text3.Length; i++)
            {
                if (text3[i].Equals(text4[i]))
                {
                    equals++;
                }
                else
                {
                    nonEquals++;
                }
            }

            Console.WriteLine(equals);
            Console.WriteLine(nonEquals);
        }
    }
}
