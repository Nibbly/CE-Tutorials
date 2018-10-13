using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genereics_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = new Result<int> { Success = false, Data = 100 };
            var res2 = new Result<string>{ Success = true, Data = "John" };

            Print(res);
            Print(res2);

            Console.ReadKey();
        }

        public static void Print<T>(Result<T> res)
        {
            Console.WriteLine("Success: {0}\tData: {1}", res.Success, res.Data);
        }
    }

    public class Result<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
    }
}
