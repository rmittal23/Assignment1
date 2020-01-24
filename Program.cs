using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                for (int i = n; i > 0; i--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                n--;
            }
           
                Console.Write("Enter a positive integer number: ");
                int k = Convert.ToInt32(Console.ReadLine());
                int j = 0;   
                for(int i=1; i<=k; i++)
                    {
                     j = j + i;   
                     Console.Write(j + ",");
                     
                    }
        }
            
    }
}
