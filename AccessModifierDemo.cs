using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class AccessModifierDemo
    {
        public int id = 1;
        private string name = "Raj";
        internal int RollNumber = 7;
        protected string username = "Raj@";
    }
    public class Employee : AccessModifierDemo//inherited class for protected access modifier
    {
        public void Print()
        {
            Console.WriteLine(username);
        }
    }
}
