using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLINQ
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
           
            var products = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                var product = new Product()
                {
                    Name = "Продукт" + i,
                    Energy = rnd.Next(10,12),
                    //Calorized = rnd.Next(2)
                };
                products.Add(product);
            }

            var result = from item in products
                         where item.Energy < 200 ||item.Energy>400
                         select item;

            var resultTwo = products.Where(item => item.Energy < 5 || item.Energy>20).OrderBy(item=>item.Energy);

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach (var item in products)
            {
                Console.WriteLine(item) ;
            }

            var selectCollection = products.Select(product => product.Energy).OrderBy(r=>r);
            
            
            foreach (var item in selectCollection)
            {
                Console.WriteLine(item);
            }

            var orderbyCollection = products.OrderBy(item => item.Energy).ThenBy(r=>r.Name);
            foreach (var item in orderbyCollection)
            {
                Console.WriteLine(item);
            }

            var groupbyCollection = products.GroupBy(product => product.Energy);
            
            foreach (var group in groupbyCollection)
            {
                Console.WriteLine($"Ключ: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item}");
                }
            }

            products.Reverse();

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }


            var all = products.All(item => item.Energy == 10);
            var any = products.Any(item => item.Energy == 10);
            Console.WriteLine(all);
            Console.WriteLine(any);
            var prod = new Product();

            var contains = products.Contains(prod);
            Console.WriteLine(contains);

            var array = new int[] { 1, 2, 3, 4, 5 };
            var array2 = new int[] { 3, 4, 5,6,7 };

            var union = array.Union(array2);
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var intersect = array.Intersect(array2);
            foreach (var item in intersect)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine();

            var except = array.Except(array2);
            foreach (var item in except)
            {
                Console.WriteLine(item);
            }

            var sum = array.Sum();
            var min = array.Min();
            var max = products.Max(r => r.Energy);

            var aggregate = array.Aggregate((a, b) => a * b);

            var sum2 = array.Take(3).Sum();


            var first = products.First(a => a.Energy == 10);
            var first2 = array.LastOrDefault();

            //var single = products.Single(a => a.Energy == 10);

            var element = products.ElementAt(5);

            Console.ReadLine();
        }
    }
}
