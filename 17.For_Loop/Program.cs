using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the For loop ");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("Hi, we are looping");
                Console.WriteLine("This is i+2 = " +Convert.ToInt32(i +2));
            }
            Console.WriteLine();
            Console.WriteLine("**********");
            Console.WriteLine("End OF FOR LOOP");
            Console.WriteLine("**************");
            Console.WriteLine();
            Console.WriteLine("This is the While loop ");
            int j = 0;
            while (j <= 5)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.ReadLine();
        }
    }
}
