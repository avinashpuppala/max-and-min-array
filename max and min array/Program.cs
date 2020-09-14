using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_and_min_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] arr = new int[6];
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entering the arraty elements");
            for(i=0;i<n;i++)
            {
                Console.WriteLine("the array elements are  {0} :", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(i=0;i<n;i++)
            {
                Console.WriteLine("the array elements are {0} :", arr[i]);

            }
            int max = arr[0];
            int min = arr[0];
            for (i = -0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
                Console.WriteLine("the max element is {0}\n", max);
                Console.WriteLine("the min element is {0}\n", min);
            
            Console.ReadLine();
        }
    }
}
