using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, temp = 0;
            int[]a=new int[100];
            Console.Write("Enter the values :");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("\nThe values ase :");
            for(i=0;i<n;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(i=0;i<n; i++)
            {
                for(j=i+1;j<n;j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.Write("Ascending order of the numbers :");
            for (i = 0; i < n; i++)
            {
                Console.Write(a[i]+" ");
            }


                Console.ReadLine(); 

        }
    }
}
