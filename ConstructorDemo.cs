using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class ConstructorDemo
    {
        public int age;
        public string name;
        public ConstructorDemo()
        {
            age = 70;
        }
        public ConstructorDemo(int x)
        {
            age = x;

        }
        public ConstructorDemo(int x, string y)
        {
            age = x;
            name = y;
        }
    }
}
