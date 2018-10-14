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
            var t1 = Task.Factory.StartNew(() => DoSomething(1, 2000));
            var t2 = Task.Factory.StartNew(() => DoSomething(2, 3000));
            var t3 = Task.Factory.StartNew(() => DoSomething(3, 1000));

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
