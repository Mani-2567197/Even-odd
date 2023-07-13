using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_or_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the value for num:\t");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if (num<0)
            {
                Console.WriteLine("The number is Negative");
                
            }
            else if(num==0)
            {
                Console.WriteLine("The number is Zero");
            }
            else
            {
                Console.WriteLine("The number is Positive");
            }
            var result = (num % 2 == 0) ? "The number is Even" : "The number is Odd";
            Console.WriteLine(result);
            Console.ReadKey();
        }
        
    }
}
