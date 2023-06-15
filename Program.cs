using System.Net.NetworkInformation;

namespace Demo
{
    public class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter your option from below :-" +"\n1.Constructor Example." +
                                "\n2.Interface Example." + "\n3.AccessModifier Example.");
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
                    case 3:
                    AccessModifierDemo person = new AccessModifierDemo();
                    Console.WriteLine(person.id);//created object for public class
                 // Console.WriteLine(person.name);//created object for private class
                    Console.WriteLine(person.RollNumber);//created object for internal class

                  //Console.WriteLine(person.username);//created object for protected class
                    Employee employee = new Employee();
                    employee.Print();

                    break;
            }

        }
    }
}