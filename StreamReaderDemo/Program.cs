using System.IO;
namespace StreamReaderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\Test\myFile.txt";
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    string line= sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
               //FileStream class is must to use in FileHandling
             //coz it represends the file stored in specific location in harddisk and on which we can perform different 
             //operations like open....through FileMode

               Console.ReadLine();// To pause console window

            Console.WriteLine("Hello, World!");
        }
    }
}
