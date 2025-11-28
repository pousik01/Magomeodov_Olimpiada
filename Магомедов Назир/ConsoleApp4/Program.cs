using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            int amount = int.Parse(input[0]);
            int lvls = int.Parse(input[1]);
            int counterOfSecretlvl = 0;
            var listOfNums = new List<int>();
            var listOflvlsAndAmount = new List<int[]>();
            string dopLvls = "";
            for(int i=0; i<lvls; i++)
            {
                input = Console.ReadLine().Split(' ');
                var lvl = new int[] { int.Parse(input[0]), int.Parse(input[1]) };
                listOflvlsAndAmount.Add(lvl);
            }
            for(int i=0; i<listOflvlsAndAmount.Count(); i++)
            {
                if (amount == 0 && listOflvlsAndAmount.Count()-1 != i)
                {
                    amount += listOflvlsAndAmount[i][1];
                    counterOfSecretlvl++;
                    listOfNums.Add(i);
                }else if(amount < 0)
                {
                    counterOfSecretlvl = -1;
                    Console.WriteLine(counterOfSecretlvl);
                    break;
                }
                amount -= listOflvlsAndAmount[i][0];
            }
            if (counterOfSecretlvl != -1)
            {
                Console.WriteLine(counterOfSecretlvl);
                if (listOfNums.Count() > 0)
                {
                    for (int i = 0; i < listOfNums.Count(); i++)
                    {
                        if (i == listOfNums.Count() - 1)
                        {
                            dopLvls += listOfNums[i];
                        }
                        else
                        {
                            dopLvls += listOfNums[i] + " ";
                        }
                    }
                }
                if (dopLvls != "")
                {
                    Console.WriteLine(dopLvls);
                }
            }
        }
    }
}
