using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();
            string strEmpty = "";
            for(int i=0; i<str1.Length; i++)
            {
                char j = Convert.ToChar(str1[i]);
                char k = Convert.ToChar(str2[i]);
                char g = Convert.ToChar(str3[i]);
                if(j>=g && j >= k)
                {
                    strEmpty += j;
                }else if(k>=g && k >= j)
                {
                    strEmpty += k;
                }
                else
                {
                    strEmpty += g;
                }
            }
            Console.WriteLine(strEmpty);
        }
    }
}
