using System;
using System.IO;

namespace DemoFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"D:\NetIt\DemoFiles\DemoFiles\file\text.txt");
            //StreamWriter streamWriter = new StreamWriter(@"D:\NetIt\DemoFiles\DemoFiles\file\text.txt");
            int lineNumber = 0;
            string line = streamReader.ReadToEnd();

            while (line != null)
            {
                lineNumber++;
                Console.WriteLine($"{lineNumber}: {line}");
                line = streamReader.ReadLine();
            }
            
            streamReader.Close();
        }
    }
}
