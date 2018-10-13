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
            var res = new Result<int, string> { Success = false, Data = 100, List = new List<string> { "Hello", "Sir" } };
            var res2 = new Result<string, int> { Success = true, Data = "John", List = new int[] { 2, 3, 4, 5 } };

            var printer = new Printer();
            printer.Print(res);
            printer.Print(res2);

            Console.ReadKey();
        }
    }

    public class Result<T, U>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public IEnumerable<U> List { get; set; }
    }

    public class Printer
    {
        public void Print<T, U>(Result<T, U> res)
        {
            Console.Write("Success: {0}", res.Success);
            Console.Write("\tData: {0}", res.Data);
            Console.Write("\t Liste: ");

            foreach (var item in res.List)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\tList-Type: {0}", typeof(U));

            Console.WriteLine();
        }
    }
}
