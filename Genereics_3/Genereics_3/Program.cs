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
            var res = new Result<int, string> { Success = false, Data = 100, Data2 = "Bob" };
            var res2 = new Result<string, bool> { Success = true, Data = "John", Data2 = true };

            Print(res);
            Print(res2);

            Console.ReadKey();
        }

        public static void Print<T, U>(Result<T, U> res)
        {
            Console.WriteLine("Success: {0}\tData: {1}\tData2: {2}", res.Success, res.Data, res.Data2);
        }
    }

    public class Result<T, U>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public U Data2 { get; set; }
    }
}
