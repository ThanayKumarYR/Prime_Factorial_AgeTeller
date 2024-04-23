using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Factorial_AgeTeller
{

    public class Demo
    {
        public int i;
        static Demo()
        {
            Console.WriteLine("Static constructor is initialized");
        }
        public Demo()
        { 
            Console.WriteLine("Defualt constructor is initialized");
        }
        public Demo(int x)
        {
            i = x;
            Console.WriteLine("Parameterized Constructor is initialized");
        }
    }
    class AgeTeller
    {
        private int age = 34;
        public string name = "Thanay Kumar Y R";
        public int tellage() { return age; }

        static void Main() 
        
        {
        
            Console.WriteLine("Executing main function");
            Demo obg = new Demo();
            Demo obg1 = new Demo(10);
            Console.WriteLine($"Value of data member is: {obg1.i}");
            Console.ReadLine();
        }
    }
}
