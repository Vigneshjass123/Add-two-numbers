using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // n1= [2,4,3]   n2=  [5,6,4]
            // output [7,0,8]

            int[] n1 = { 2, 4, 3 };
            int[] n2 = { 5, 6, 4 };
            int sum = 0;
            int sum1 = 0;
            int sum3 = 0;

            sum = n1[0] + n2[0];
            sum1 = n1[1] + n2[1];
            sum3 = n1[2] + n2[2];
            {
                if (sum1 == 10)
                {
                    sum1 = sum1 - 10;
                }
                if (sum3 == 7)
                {
                    sum3 = sum3 + 1;
                }
            }
            Console.WriteLine(sum + " ," + sum1 + " ," + sum3);
        }
    }
}
           
           



          

   


