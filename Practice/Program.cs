namespace Practice
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //        
            //            /*    //1.//Lambada Expression
            //                Func<int, int> square = Y => Y * Y;

            //                Console.WriteLine(square(5));

            //                Console.WriteLine("Hello, World!");

            //                //2.// Lambada Expression which takes two int inputs and returns int
            //                Func<int, int, int> add = (a, b) => a + b;
            //                Console.WriteLine(add(5, 3));

            //                //3.// Lambada with LINQ List

            //                List<int> list = new List<int> { 10, 20, 40, 29, 17, 50 };


            //                List<int> filtered = list.Where(l => l > 10).ToList();// l is input parameter

            //                Console.WriteLine(string.Join(",", filtered));


            //                //Lambada with Action Delegate
            //                Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
            //                greet("Alice");  // Output: Hello, Alice!

            //                //Lambada as a Predicate(Checking condition)
            //                List<int> numbers = new List<int> { 10, 38, 3635, 40, 14 };
            //                bool hasEven = numbers.Any(n => n % 2 == 0);
            //                Console.WriteLine(hasEven);
            //            */

            //            AnnonymousMethods annonymousMethods = new AnnonymousMethods();

            //            annonymousMethods.myDelegate ();

            /*
            //Code  Running
                        // creating class object in which delegate and method is present
                        DelegatePr obj = new DelegatePr();
                        ////Creating delegate instance and passing method reference classobj.methodname
                        MyAddition addition = new MyAddition(obj.Add);
                        int result = addition(5, 3,2);
                        Console.WriteLine("Result is: " + result);

                        // Call the Func<int, int, int> directly
                        Console.WriteLine("Result of addition with inline function is: " + obj.add(10, 20,2)); // Output: 30
            */

            //7/04/2025
            //AnnonymousFunction Demo 

            // MyDelegateA myDelegateA = new MyDelegateA(AnnonymousFuncDemo.MyMethod1);
            // myDelegateA.Invoke(5);

            /*          //  using Annonymous method::
                      MyDelegateA myDelegateA = delegate (int number)
                      {
                          number += 10;
                          Console.WriteLine(number);
                      };
                      myDelegateA.Invoke(5);
          */

            /*
                        ///8/04/2025
                     //   MyShow show = new MyShow(AnMethod.Show);// As we are calling Annonymous method so that it gives error
                       // show.Invoke(1);// and commented that method from AnMethod class
                        //Annonymous Method with Delegate object
                        MyShow delobj = delegate (int a)
                        {
                            a = a + 10;
                            Console.WriteLine(a);//as no return type mentioned to the delegates so printed directly

                        };
                        delobj(10);
            */

            //Lambada Expression  lambada as expession OR Expression Lamabada 

            MylambadaDelegate lambadaobj = (a) => a * a;
           Console.WriteLine( lambadaobj.Invoke(10));

            MylambadaDelegate1 obj2 = (a, b, c) => {
               
                return a + b + c;
                };
            int result =obj2.Invoke(10,20,20);

            // Console.WriteLine(obj2);// it prints only delegate object but not result of addition
            //to print result you have to capture it within some variable and then print it
            Console.WriteLine(result);
            //Console.ReadLine();
        }
    }

}