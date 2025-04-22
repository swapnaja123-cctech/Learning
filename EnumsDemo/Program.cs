` namespace EnumsDemo
{

    enum Days
    {
        Sunday,//you can assign default values to enum members
        Monday,
        Tuesday,//if you assignvalue suppose Tuesday=5, then Wednesday becomes 6 and so on
        Wednesday,
        Thursday,
        Friday,
        Saturday
    };



    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello, World!");
                 //  Console.BackgroundColor = ConsoleColor.Green;
                 ////  Console.BackgroundColor = ConsoleColor.Blue;
                 //Console.BackgroundColor = ConsoleColor.Black;
                 //Console.WriteLine("I am Learning C#");
              //Console.WriteLine(Days.Sunday);
               //Or
               Days birthday=Days.Friday;
                 Console.WriteLine(birthday);//Friday

                 //Explicit Typecasting of Enums
                 Days myDay = (Days)1;
                 Console.WriteLine(myDay);//   Monday

                 int value = (int)Days.Sunday;
                 Console.WriteLine(value);//0*/


            String[] arr = (string[])Enum.GetNames(typeof(Days));

            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }
        }
    }
}