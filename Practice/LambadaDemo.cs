using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    public delegate int MylambadaDelegate(int x);

    public delegate int MylambadaDelegate1(int x, int y,int z);
    public class LambadaDemo
    {

        public int print(int a)
        {
            return a * a;
        }
    }
}
