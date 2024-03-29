﻿
// Count Total Solutions Whose Addition Of Cubes Of Two Numbers Is Exactly Equal To Entered Number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,Cube,Cnt=0;

            Console.Write("\n Enter Number : ");
            N = Convert.ToInt32(Console.ReadLine());

            for (; N <= 0 || N == null; )
            {
                Console.Write("\n Enter Number : ");
                N = Convert.ToInt32(Console.ReadLine());
            }

                for (int i = 1; i <= N / 2; i++)
                {
                    for (int j = 1; j <= N / 2; j++)
                    {
                        Cube = (i * i * i) + (j * j * j);

                        if (Cube == N)
                        {
                            Cnt++;
                        }
                    }
                }

            Console.WriteLine("\n There are " + Cnt + " Solutions Whose Cube Addition is Exactly Equal To " + N);

            Console.ReadKey();
        }
    }
}
