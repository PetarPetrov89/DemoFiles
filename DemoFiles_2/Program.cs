using System;
using System.IO;

namespace DemoFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter(@"D:\NetIt\DemoFiles\DemoFiles\file\text.txt", true)) 
            {
                writer.WriteLine("New Line 4");
            }
                  

            
        }
    }
}
