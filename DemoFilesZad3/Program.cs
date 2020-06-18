using System;
using System.Collections.Generic;
using System.IO;

namespace DemoFilesZad3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> newText = new List<string>();

            using (StreamReader reader = new StreamReader(@"D:\NetIt\DemoFiles\DemoFiles\file\text4.txt"))
            {
                int lineNum = 1;

                string line = reader.ReadLine();

                while (!string.IsNullOrEmpty(line))
                {
                    line = $"{lineNum}. {line}";
                    newText.Add(line);


                    lineNum++;
                    line = reader.ReadLine();
                }
            }
            using (StreamWriter writer = new StreamWriter(@"D:\NetIt\DemoFiles\DemoFiles\file\text4.txt"))
            {
                writer.WriteLine(string.Join(Environment.NewLine, newText));
            }
        }
    }
}
