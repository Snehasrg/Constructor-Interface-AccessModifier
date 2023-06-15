using System.Net.NetworkInformation;

namespace Demo
{
    public class program
    {
        public static void Main(String[] args)
        {

            ConstructorDemo obj = new ConstructorDemo(10, "Raj");
            Console.WriteLine(obj.age);
            Console.WriteLine(obj.name);

        }
    }
}