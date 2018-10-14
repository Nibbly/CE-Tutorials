using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Task(() => DoSomething(1, 2000));
            t1.Start();
            var t2 = new Task(() => DoSomething(2, 1000));
            t2.Start();
            var t3 = new Task(() => DoSomething(3, 4000));
            t3.Start();


            Console.WriteLine("Press key to continue");
            Console.ReadKey();
        }

        static void DoSomething(int id, int sleeptime)
        {
            Console.WriteLine("Task {0} has started!", id);
            Thread.Sleep(sleeptime);
            Console.WriteLine("Task {0} has completed!", id);
        }
    }
}
