using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public delegate void MyDelegateA(int num);
    public class AnnonymousFuncDemo
    {

        public static void MyMethod1(int number)
        {
            number += 10;
            Console.WriteLine(number);
        }
    }
}
