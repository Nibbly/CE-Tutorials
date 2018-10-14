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
            var nums = new List<int> { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };

            // Parallel.ForEach / .For beendet erst seine Operationen bevor es weiter geht
            Parallel.ForEach(nums, (i) => { Console.WriteLine("i: {0}\ti^2: {1}", i, i * i);});

            Parallel.For(0, 100, (i) => Console.WriteLine(i));

            Console.WriteLine("Press key to continue");
            Console.ReadKey();
        }

        static void DoSomething(int id, int sleeptime)
        {
            Console.WriteLine("Task {0} has started!", id);
            Thread.Sleep(sleeptime);
            Console.WriteLine("Task {0} has completed!", id);
        }

        static void DoSomethingElse(int id, int sleeptime)
        {
            Console.WriteLine("Task {0} has started more work!", id);
            Thread.Sleep(sleeptime);
            Console.WriteLine("Task {0} has completed more work!", id);
        }

    }
}
