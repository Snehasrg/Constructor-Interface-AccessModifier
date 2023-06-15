using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public interface IAnimal
    {
        void animalSound();
    }
    class Dog : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The Dog makes sound: Bhoo Bhoo");

        }
    }
}
