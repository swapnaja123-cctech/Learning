using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    [Serializable]
     class Employee
    {
        public int Id;
        public string Name;

        public Employee(int Id, String Name)
        {
            this.Id = Id;   
            this.Name = Name;   
            
        }
    }
}
