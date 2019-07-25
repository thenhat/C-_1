using System;
using System.Collections.Generic;

namespace T1809E_C
{
    public class fibonacci
    {
        
        public static void Main(string[] args)
        {
            
            public static int Fibona(int x)
            {
                List<int> arrN = new List<int>();
                for (int i = 0; i < 100; i++)
                {
                    arrN.Add(i);
                }

                List<int> fibo = new List<int>();
                for (int j = 0; j < arrN.Count; j++)
                {

                    if (arrN[j+2] == arrN[j + 1] + arrN[j])
                    {
                        fibo.Add(arrN[j+2]);
                    }
                }
                return fibo[x];
            
            }
            
            Console.WriteLine("NHap so n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So Fibonacci thu " + n + " là: ");
            Console.WriteLine(Fibona(n));
        }
        
    }
}