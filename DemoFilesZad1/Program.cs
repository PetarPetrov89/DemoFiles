using System;
using System.IO;

namespace DemoFilesZad1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"D:\NetIt\DemoFiles\DemoFiles\file\text3.txt")) 
            {
                int lineNumber = 1;

                string line = reader.ReadLine();

                while (!string.IsNullOrEmpty(line))
                {
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine($"Line {lineNumber}: {line}");
                    }

                    lineNumber++;

                    line = reader.ReadLine();
                }
            }
        }
    }
}
