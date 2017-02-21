using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    class example
    {
        public  int add(int a, int b)
        {
            int x = a + b;
            Console.WriteLine("Sum of first two numbers is {0}",x);
            return x;
        }
        public  int add(int a, int b,int c)
        {
            int y = a + b + c;
            Console.WriteLine("Sum of three numbers is {0}", y);
            return y;

        }
       
    }
    class Program
    {
        public static void Main(string[] args)
        {
            example ex = new example();
            Console.WriteLine("Enter the values ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            ex.add(x, y);
            ex.add(x,y,z);
            Console.ReadKey();
         
        }
    }
}
