using System;
using System.IO;

namespace DemoFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = (@"D:\NetIt\DemoFiles\DemoFiles\file\text2.txt");

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("New Line 4");
            }



        }
    }
}