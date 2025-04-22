using System.Collections;
using System.Timers;

namespace CollectionFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           
            

            //8/04/2025 Hashtable

            Hashtable htobj = new Hashtable();

            htobj.Add("Id", 101);
            htobj.Add("Name" , "Ruchira");
            htobj.Add("Address", "Pune");
            htobj.Add("Salary" , 1010000);
            htobj.Add("Designation" , "DevopsEngi");
            htobj.Add("IsMarried", false);
           Console.WriteLine( htobj.ContainsKey("Id"));
          //  htobj.Remove("IsMarried");
          //  htobj.Clear();
          Console.WriteLine(htobj.Count);

            Console.WriteLine(htobj["Salary"]);

            foreach(object ky in htobj.Keys)
            {
                Console.WriteLine(htobj[ky]);
            }


            //Stack (09/04/2025)
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push(101);
            myStack.Push("Hello");
            myStack.Push("Morning");
            myStack.Push("good");
            Console.WriteLine(myStack);//Does not print all the elements in stack require foreach loop
            // it only print type
            foreach(Object s in myStack)
            {
                Console.WriteLine(s);   
            }
            string name = myStack.Peek().ToString();// removes last element of the stack
            Console.WriteLine(name);
            Console.WriteLine(myStack.Count);// returns no of members in stack
            myStack.Pop();
            foreach (Object s in myStack)
            {
                Console.WriteLine(s);//removed good
            }
            Console.WriteLine(myStack.Contains("Morning"));
            myStack.Clear();
            foreach (Object s in myStack)
            {
                Console.WriteLine(s);//
            }
            Console.WriteLine("-------------------------------------------");           
            
            //Queue(09/04/2025)

            Queue queue = new Queue();
            queue.Enqueue("Hello");
            queue.Enqueue(501);
            queue.Enqueue('A');
            queue.Enqueue(true);
            queue.Enqueue(5.9);
            queue.Enqueue("Anup");
            foreach(object a in queue)
            {
                Console.WriteLine(a);
            }
            queue.Dequeue();
            Console.WriteLine(queue.Count);
            Console.WriteLine("///////////////////////");
            foreach (object a in queue)
            {
                Console.WriteLine(a);
            }
        }
    }
}
