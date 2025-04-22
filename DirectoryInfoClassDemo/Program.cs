
using System.IO;
using System.Numerics;
namespace DirectoryInfoClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string path = "F:\\MyDirectory";
            string path1 = "F:\\New";
            DirectoryInfo obj = new DirectoryInfo(path1);
            // obj.Create();
            //obj.MoveTo(path1);// As we have moved the file and dir into New folder MyDirectory gets deleted.
            //obj.Delete();
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.FullName);
            Console.WriteLine(obj.Attributes);
            Console.WriteLine(obj.CreationTime);
            Console.WriteLine(obj.LastAccessTime);
            Console.WriteLine(obj.LastWriteTime);
            Console.WriteLine(obj.Name);
             
            DirectoryInfo[] count= obj.GetDirectories();
            foreach(var c in count)
            {
                Console.WriteLine(c.Name);
            }

            //obj.CreateSubdirectory("SubDir");
            Console.WriteLine("Directory Created");
        }
    }
}
