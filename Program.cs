using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _259290
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the seed: ");
            int seed = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the capacity: ");
            int capacity = int.Parse(Console.ReadLine());


            Knapsack knapsack = new Knapsack(n, seed);

            Console.WriteLine("Avaliable items: ");
            Console.WriteLine(knapsack);

            Console.WriteLine("Items in knapsack: ");
            knapsack.countCapacity(capacity);

            Console.ReadLine();
        }
    }
}
