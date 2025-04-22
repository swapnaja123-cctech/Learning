namespace GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
                   //Normal List
                        List<int> ints = new List<int>();
                        ints.Add(1);
                        ints.Add(2);
                        ints.Add(3);
                        ints.Add(4);
                        ints.Add(5);
                        ints.Add(6);
                         
                        Console.WriteLine(ints[5]);//we can access data through indexing also
                        Console.WriteLine(ints.Capacity);

                        foreach (int i in ints)
                        {
                            Console.WriteLine(i);
                        }


            //Complex Type list Employee

            Employee emp1 = new Employee()
            {
                name = "Aamir",
                age = 25,
                designation = "Manager"
            };
            Employee emp2 = new Employee()
            {
                name = "Anwar",
                age = 28,
                designation = "subManager"
            };
            Employee emp3 = new Employee()
            {
                name = "Anju",
                age = 35,
                designation = "Police"
            };



            List<Employee> emplist = new List<Employee>();
            emplist.Add(emp1);
            emplist.Add(emp2);  
            emplist.Add(emp3);

            foreach(Employee emp in emplist)
            {
                Console.WriteLine("Employee data : {0},{1},{2}",emp.name,emp.age,emp.designation);
            }

            emplist.RemoveAll(emp => emp.name== "Anju");//using predicate or lambada function

            foreach (Employee emp in emplist)
            {
                Console.WriteLine("Employee data : {0},{1},{2}", emp.name, emp.age, emp.designation);
            }
        }
    }
     



   
}