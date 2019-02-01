using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] d = s.Split();
            int[] arr = new int[a];
            //List<int> res = new List<int>();
            for(int i = 0; i<a; i++)
            {
                arr[i]=(int.Parse(d[i]));
            }
            for(int i = 0; i<a; i++)
            {
                for(int j = 0; j<2; j++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
