using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2905th
{
    class Program
    {
        private static void ThreadWork()
        {
            Console.WriteLine("I am a thread....");
            //Console.WriteLine(Thread.CurrentThread.ThreadState);
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {i}");
            }          
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!@");

            //t.IsBackground = false;  (default)
            //Thread t = new Thread(ThreadWork);

            //t.IsBackground = true;

            //Console.WriteLine(t.ThreadState);

            //t.Start();
            Thread.Sleep(500);

            //Console.WriteLine($"t state {t.ThreadState}");

            //for (int i = 0; i < 10; i++)
            //{
            //    Thread t = new Thread(ThreadWork);
            //    t.Start();
            //    Thread.Sleep(5);
            //    //t.Abort();

            //}

            //Thread.Yield();

            Thread t = new Thread(ThreadWork);
            t.Start();

            Console.WriteLine("I want to wait for t....");

            t.Join();
            Console.WriteLine("This happends only after t finished!");

            Console.WriteLine("Main is over ... going home!");

            //Thread.Sleep(5000);

            //Console.WriteLine($"t state {t.ThreadState}");

        }
    }
}
