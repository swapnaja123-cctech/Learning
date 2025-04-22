using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = "F:\\Adil\\Sample.exe
            Employee emp = new Employee(241,"Adil");
            FileStream fileStream = new FileStream(path,FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, emp);
            fileStream.Close();
            Console.WriteLine("File created Successfully "+ path);


            // DESERIALIZATION


            String path = "F:\\Adil\\Sample.txt";
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Employee emp = (Employee)formatter.Deserialize(fileStream);
            Console.WriteLine("EmployeeId: " + emp.Id);
            Console.WriteLine("EmployeeName: "+emp.Name);
            fileStream.Close();
            Console.ReadLine();
        }
    }
}
