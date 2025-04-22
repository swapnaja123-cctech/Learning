using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public delegate int MyAddition(int a, int b , int c);// delegate declaration
    public class DelegatePr
    {
        public int Add(int x, int y,int c)// method creation
        {
            return x + y%c;
        }

        //By using Built-in delegate type
        //As builtin functions are private by defalut
         public Func<int, int, int , int> add = (a, b,c) => a + b-c;
        
    }
}
