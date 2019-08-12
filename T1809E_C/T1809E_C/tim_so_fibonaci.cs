using System;
using System.Threading;

namespace T1809E_C
{
    public class tim_so_fibonaci
    {    

        public static void Main(string[] args)
        {
            Console.WriteLine("Input n=");
            int soN = Convert.ToInt32(Console.ReadLine());
            
            Fibo n=new Fibo();
            TG tg=new TG();
            Thread t1 = new Thread(delegate()
            {
                for ( tg.i = 0; true; tg.i++)
                {
                    for ( tg.j = 0; tg.j < 60; tg.j++)
                    {
                        lock (tg)
                        {
                            Console.WriteLine(tg.i.ToString("D2") +
                                              ":" + tg.j.ToString("D2"));
                            
                        }
                        Thread.Sleep(1000);
                    }
                }
            });
           

            Thread t3 = new Thread(delegate()
            {
                for (int i = 0; n.x1+n.x2 < soN; i++)
                {
                    n.x3 = n.x1 + n.x2;
                    n.x1 = n.x2;
                    n.x2 = n.x3;
                    Console.WriteLine("Fibo: " + n.x3);
                    Thread.Sleep(500);
                }
            });
            Thread t4 = new Thread(delegate()
            {
                for (int i = 0; n.x1 + n.x2 < soN; i++)
                {
                    lock (n)
                    {
                        n.x3 = n.x1 + n.x2;
                        n.x1 = n.x2;
                        n.x2 = n.x3;
                        Console.WriteLine("Fibo: " + n.x3);
                        
                    }
                    Thread.Sleep(500);
                }
            });
            Thread t5 = new Thread(delegate()
            {
                for (int i = 0; n.x1 + n.x2 < soN; i++)
                {
                    lock (n)
                    {
                        n.x3 = n.x1 + n.x2;
                        n.x1 = n.x2;
                        n.x2 = n.x3;
                        Console.WriteLine("Fibo: " + n.x3);
                        
                    }
                    Thread.Sleep(500);
                }
            });
            t1.IsBackground = true;
           
            t1.Start();
            t3.Start();
            t4.Start();
            t5.Start();
        }
    }

    public class Fibo
    {
       
        public int x1 = 1;
        public int x2 = 1;
        public int x3 = 2;
    }
    public class TG
    {
        
        public int i;
        public int j;
    }
}