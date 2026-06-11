//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace MultiThreading
//{

//    class myclass
//    {
//        internal void method1()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("method 1 is " + i);
//            }
//        }
//        internal void method2()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("method 2 is " + i);
//            }
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            myclass obj = new myclass();
//            ThreadStart tstart1 = new ThreadStart(obj.method1);
//            Thread thr1 = new Thread(tstart1);
//            thr1.Start();
//            ThreadStart tstart2 = new ThreadStart(obj.method2);
//            Thread thr2 = new Thread(tstart2);
//            thr2.Start();
//        }
//    }
//}
