using System;

namespace GenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() { Name = "Rainer", ID = 1 };
            var product = new Product() { Name = "Ball", ID = 1 };

            var pr = PrintTypeData(person);
            var pror = PrintTypeData(product);

            Console.WriteLine(pr);
            Console.WriteLine(pror);

            Console.ReadKey();
        }

        static T PrintTypeData<T>(T type) where T : IEntity
        {
            var result = String.Format("Name: {0} ID: {1} Class-Type: {2}", type.Name, type.ID, type.GetType().Name);
            return type;
        }

        public interface IEntity
        {
            int ID { get; set; }
            string Name { get; set; }
        }

        public class Person : IEntity
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        public class Product : IEntity
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}
