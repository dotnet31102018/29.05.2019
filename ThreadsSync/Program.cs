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
            Console.WriteLine($"Starting thread id {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(300);
            }          
        }

        private static void ThreadWorkWithParameter(object o)
        {
            int n = (int)o;
            Console.WriteLine($"Starting thread id {Thread.CurrentThread.ManagedThreadId}");
            for (int i = n; i <= n + 4; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(300);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Thread Main!");

            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < 5; i++)
            {
                threads.Add(new Thread(new ThreadStart(ThreadWork)));
            }

            for (int i = 0; i < threads.Count; i++)
            {
                threads[i].Start();
                threads[i].Join();
            }

            List<Thread> threadsWithParameter = new List<Thread>();
            for (int i = 0; i < 5; i++)
            {
                var t = new Thread(new ParameterizedThreadStart(ThreadWorkWithParameter));
                t.IsBackground = false;
                threadsWithParameter.Add(t);
            }

            for (int i = 0; i < threadsWithParameter.Count; i++)
            {
                threadsWithParameter[i].Start(i * 5 + 1);
                threadsWithParameter[i].Join();
            }
        }
    }
}
