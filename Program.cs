using System.Net.NetworkInformation;

namespace Demo
{
    public class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter your option from below :-" +"\n1.Constructor Example." +
                                "\n2.Interface Example.");
          int Option=Convert.ToInt32( Console.ReadLine());

            switch(Option)
            {
                case 1:
                    ConstructorDemo obj = new ConstructorDemo(10, "Raj");
                    Console.WriteLine(obj.age);
                    Console.WriteLine(obj.name);
                    break;
                case 2:
                    Dog dog = new Dog();
                    dog.animalSound();
                    break; 
            }

        }
    }
}