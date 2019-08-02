using System;
using System.Threading;

namespace T1809E_C
{
    public class Demgio
    {
        public static void Main(string[] args)
        {
            Thread t4 = new Thread(delegate()
            {
                for (int i = 9; i >= 0; i--)
                {
                    for (int j = 59; j >= 0; j--)
                    {
                        string strh=i.ToString("D2");
                        string strs=j.ToString("D2");
                        Console.WriteLine(strh + ":" + strs);
                        Thread.Sleep(100);
                    }
                }
            });
            t4.Start();
        }
    }
}