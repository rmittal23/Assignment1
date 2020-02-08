using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // First Program to print the pattern 
            Console.Write("Enter a positive integer number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintPattern(n);
            Console.WriteLine();

            // Second program to print the Series
            Console.Write("Enter a positive integer number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            PrintSeries(n2);
            Console.WriteLine();

            // Third program to find the time i.e. USFTime of another planet
            Console.Write("Enter a time in \"hh:mm:ss pm/am:\": ");
            string s = Console.ReadLine();
            string t = UsfTime(s);
            Console.WriteLine(t);

            // Fourth program to find the unique series of numbers and characters
            Console.Write("Total numbers to be there to present a unique series: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many numbers per line: ");
            int k = Convert.ToInt32(Console.ReadLine());
            UsfNumbers(n3, k);
            Console.WriteLine();

            // Fifth Program to find Pallindrome within an array of strings
            Console.Write("How many words you want to enter for pallindrome check: ");
            int no = Convert.ToInt32(Console.ReadLine());
            if(no > 1)
            {
                string[] words = new string[no];
                for (int st = 0; st < no; st++)
                {
                    Console.WriteLine("Enter " + (st + 1) + " word: ");
                    words[st] = Console.ReadLine();
                }
                PalindromePairs(words);
            }
            else
            {
                Console.WriteLine("Please enter more than 2 words");
            }
            Console.WriteLine();

            // Sixth program for playing a game of stones
            Console.Write("Enter number of stones to check if you win or lose in a game: ");
            int n4 = Convert.ToInt32(Console.ReadLine());
            Stones(n4);
        }
        private static void PrintPattern(int n)
        {
            try
            {
                while (n > 0)
                {
                    for (int i = n; i > 0; i--)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                    n--;
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }
        private static void PrintSeries(int n2)
        {
            try
            {
                int j = 0;
                for (int i = 1; i <= n2; i++)
                {
                    if (i != n2)
                    {
                        j = j + i;
                        Console.Write(j + ",");
                    }
                    else
                    {
                        j = j + i;
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }
        public static string UsfTime(string s)
        {
            try
            {
                DateTime someDate = Convert.ToDateTime(s);
                string timeOfDay = someDate.ToString("HH:mm:ss");
                double seconds = ((TimeSpan.Parse(timeOfDay).TotalSeconds));
                int h = 60 * 45;
                int m = 45;
                double hr = Math.Floor(seconds / h);
                double mi = Math.Floor((seconds / m) % 60);
                int sec = Convert.ToInt32(seconds % 45);
                Console.WriteLine(hr + ":" + mi + ":" + sec);
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }
        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                for (int b = 1; b <= n3; b += k)
                {
                    int g = b;
                    for (int i = 1; i <= k; i++)
                    {
                        if (g % 3 == 0 && g % 5 != 0 && g % 7 != 0)
                        {
                            Console.Write("U" + " ");
                        }
                        if (g % 5 == 0 && g % 3 != 0 && g % 7 != 0)
                        {
                            Console.Write("S" + " ");
                        }
                        if (g % 7 == 0 && g % 5 != 0 && g % 3 != 0)
                        {
                            Console.Write("F" + " ");
                        }
                        if (g % 3 == 0 && g % 5 == 0 && g % 7 != 0)
                        {
                            Console.Write("US" + " ");
                        }
                        if (g % 7 == 0 && g % 5 == 0 && g % 3 != 0)
                        {
                            Console.Write("SF" + " ");
                        }
                        if (g % 3 == 0 && g % 7 == 0 && g % 5 != 0)
                        {
                            Console.Write("UF" + " ");
                        }
                        if (g % 3 == 0 && g % 7 == 0 && g % 5 == 0)
                        {
                            Console.Write("USF" + " ");
                        }
                        if (g % 3 != 0 && g % 7 != 0 && g % 5 != 0)
                        {
                            Console.Write(g + " ");
                        }
                        g++;
                    }
                    Console.WriteLine();
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }
        public static void PalindromePairs(string[] words)
        {
            try
            {
                for (int x = 0; x < words.Length; x++)
                {
                    for (int y = 0; y < words.Length; y++)
                    {
                        if (y != x)
                        {
                            string z = words[x] + words[y];
                            char[] chars = z.ToCharArray();
                            char[] result = new char[chars.Length];
                            for (int i = 0, jm = chars.Length - 1; i < chars.Length; i++, jm--)
                            {
                                result[i] = chars[jm];
                            }
                            string com = new string(result);
                            if (z == com)
                            {
                                Console.WriteLine(x + "," + y + " is pallindrome");
                            }

                        }
                    }
                }
            }
            catch
            {

                Console.WriteLine("Exception occured while computing PalindromePairs()");
            }
        }
        public static void Stones(int n4)
        {
            try
            {
                if (n4 % 4 == 0)
                {
                    Console.WriteLine("You can never win");
                }
                else
                {
                    Console.WriteLine(" In order to win the game you have to take each step such that it is \n(no. of stones left in the bag % 4) i.e"
                        + " the remainder of (stones in bag by 4).");
                /* We can find the series of steps that makes you to win, by adding to the list
                 the no. of stones left in the bag % 4 at the odd time interval and for even time interval
                 when the opponent take his turn then consider 3 cases of (1,2,3).*/ 
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }


    }
}


    


           
            
            
            