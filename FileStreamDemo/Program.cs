using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        // Your custom path
        string path = @"F:\Test\myFile.txt";

        using (FileStream file = new FileStream(path, FileMode.Append))
        {
            using (StreamWriter writer = new StreamWriter(file,Encoding.UTF8))
            {
                //  writer.Write("I am sunshine");
                int[] arr = { 10, 20, 30, 30, 50 };
                foreach(var a in arr)
                {
                    writer.Write(a + " ");
                }

                Console.WriteLine("Data entered into file");
            }
           // writer.Close();
        }
            Console.WriteLine("File Created at: " + path);
       // file.Close();

        Console.ReadLine(); // Keeps console open
    }
}
