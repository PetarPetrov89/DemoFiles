using System;
using System.IO;

namespace DemoFilesZad2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = File.ReadAllText(@"D:\NetIt\DemoFiles\DemoFiles\file\text3.txt");
            string text2 = File.ReadAllText(@"D:\NetIt\DemoFiles\DemoFiles\file\text4.txt");

            File.WriteAllText(@"D:\NetIt\DemoFiles\DemoFiles\file\text3T.txt", text1 + Environment.NewLine + text2);
        }
    }
}
