using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            var input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k1 = int.Parse(input[1]);
            int t1 = int.Parse(input[2]);
            int k2 = int.Parse(input[3]);
            int t2 = int.Parse(input[4]);
            double v1 = 0, v2 = 0;
            try
            {
                v1 = (double)k1 / t1;
                v2 = (double)k2 / t2;
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
            double m1 = n / v1;
            double m2 = n / v2;
            if(m1 > m2)
            {
                Console.WriteLine(Convert.ToInt32(Math.Ceiling(m2)));
            }
            else
            {
                Console.WriteLine(Convert.ToInt32(Math.Ceiling(m1)));
            }
        }
    }
}
