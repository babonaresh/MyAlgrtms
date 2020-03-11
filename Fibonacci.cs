using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{ 
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the limit for the fibionoci series such as first 10 numbers etc.. ");
            int input = int.Parse(Console.ReadLine());
            int i = 0, j = 1,number;
            Console.Write(" Fobonacci series : " + i + " " + j + " ");
            for(int k = 2; k < input; k++)
            {
                number = i + j;
                Console.Write(number + " ");
                i = j;
                j = number;
                
            }

        }
    }
}
