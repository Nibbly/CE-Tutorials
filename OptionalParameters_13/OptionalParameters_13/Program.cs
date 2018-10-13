using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters_13
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintData("John", age: 77);

            Console.ReadKey();
        }

        // Alle nicht optionalen Parameter müssen in der Methodensignatur zuerst angegeben werden

        static void PrintData(string firstName, string lastName = null, int age = 0)
        {
            Console.WriteLine("{0} {1} is {2} years old.", firstName, lastName, age);
        }

        //Methoden müssen für jeden benötigten Fall überladen werden -> Lösung optionale Paramter

        //static void PrintData(string firstName, string lastName, int age)
        //{
        //    Console.WriteLine("{0} {1} is {2} years old.", firstName, lastName, age);
        //}

        //static void PrintData(string firstName, string lastName)
        //{
        //    PrintData(firstName, lastName, 0);
        //}

        //static void PrintData(string firstName)
        //{
        //    PrintData(firstName, null, 0);
        //}
    }
}
