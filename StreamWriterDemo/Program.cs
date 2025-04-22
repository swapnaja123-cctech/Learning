
using System.IO;

namespace StreamWriterDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\myTxt.txt";
            using( FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                // using using(){} fun no need to close file
                Console.WriteLine("File created");
            }
            //  stream.Close();

            Console.WriteLine("Hello, World! Hi ");
            Console.ReadLine();
        }
    }
}
