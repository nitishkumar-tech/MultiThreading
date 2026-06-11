using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadings
{
    class myclass
    {
        internal void fruitsdisplay()
        {
            string[] ar = new string[4] { "apple", "banana", "grapes", "orange" };
            foreach (string s in ar)
            {
                Console.WriteLine("fruits :" + s);
            }
        }
        internal void vegetablesdisplay()
        {
            string[] arr = new string[4] { "Onion", "carrot", "bottleguard", "potato" };
            foreach (string V in arr)
            {
                Console.WriteLine("Vegetables :" + V);
            }
        }
    }
    internal class MultiThread2
    {
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            ThreadStart tstart1 = new ThreadStart(obj.fruitsdisplay);
            Thread tr1 = new Thread(tstart1);
            tr1.Start();
            
            ThreadStart tstart2 = new ThreadStart(obj.vegetablesdisplay);
            Thread tr2 = new Thread(tstart2);
            tr2.Start();
        }
    }
}


