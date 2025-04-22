using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    delegate void MyDelegate(string message);//
   public class AnnonymousMethods
    {
        MyDelegate myDelegate = delegate (string message)
        {
            Console.WriteLine(message);
        };
       // public MyDelegate("Hello C# Its my Annonymous methods using delegate method");
    };
}
