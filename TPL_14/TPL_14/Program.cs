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
            var source = new CancellationTokenSource();
            try
            {
                var t1 = Task.Factory.StartNew(() => DoSomething(1, 2000, source.Token)).ContinueWith((prevTask) => DoSomethingElse(2, 3000, source.Token));
                source.Cancel();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
            }


            Console.WriteLine("Press key to continue");
            Console.ReadKey();
        }

        static void DoSomething(int id, int sleeptime, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation is requested {0}", id);
                token.ThrowIfCancellationRequested();
            }

            Console.WriteLine("Task {0} has started!", id);
            Thread.Sleep(sleeptime);
            Console.WriteLine("Task {0} has completed!", id);
        }

        static void DoSomethingElse(int id, int sleeptime, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation is requested {0}", id);
                token.ThrowIfCancellationRequested();
            }
            Console.WriteLine("Task {0} has started more work!", id);
            Thread.Sleep(sleeptime);
            Console.WriteLine("Task {0} has completed more work!", id);
        }

    }
}
