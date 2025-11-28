using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arrayN = Console.ReadLine().Split(' ');
            int m = int.Parse(Console.ReadLine());
            var arrayM = Console.ReadLine().Split(' ');
            var listikOfN = new List<int>();
            var listikOfM = new List<int>();
            int UnitN, UnitM;
            for(int i=0; i<n; i++)
            {
                UnitN = int.Parse(arrayN[i]);
                listikOfN.Add(UnitN);
            }
            for (int i = 0; i < m; i++)
            {
                UnitM = int.Parse(arrayM[i]);
                listikOfM.Add(UnitM);
            }
            int counter = 0;
            for(int i=0; i<listikOfN.Count(); i++)
            {
                for(int j=0; j < listikOfM.Count(); j++)
                {
                    if (listikOfN[i] > listikOfM[j])
                    {
                        listikOfM.Remove(listikOfM[j]);
                        listikOfN.Remove(listikOfN[i]);
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
