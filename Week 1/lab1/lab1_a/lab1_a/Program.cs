using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_a
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int a = int.Parse(Console.ReadLine());//Read the line and convert to int
            string s = Console.ReadLine();//Read the line and save it like string
            string[] d = s.Split();//Save every element to array of string divided by space 
            int[] array = new int[a];//create new array
            List <int> res = new List<int>();//create list for answer

            for (int i = 0; i < a; i++)
            {
                array[i] = int.Parse(d[i]);//convert every element of array d to int and save it in array "array"
            }

            for (int i = 0; i < a; i++)
            {
                if (array[i] == 1)
                { }
                else//if one of the answer is 1 remove it from our list
                {
                    int cnt = 0;//create counter
                    for (int j = 2; j <= Math.Sqrt(array[i]); j++)//check every element of array by 
                    {

                        if (array[i] % j == 0)
                        {
                            cnt++;//if element of array divides to j , then 
                        }
                    }
                    if (cnt == 0)
                    {
                        res.Add(array[i]);//add prime elements to list res
                    }
                }
            }

            Console.WriteLine(res.Count);//print the sum of numbers
            for (int i = 0; i < res.Count; i++)
            {
                Console.Write(res[i] + " ");//print every element of list res
            }
            Console.ReadKey();
        }
    }
}
