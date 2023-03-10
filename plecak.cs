using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nina_Marcin
{
    internal class plecak
    {
        class przedmiot
        {
            public int id { get; set; }
            public int waga { get; set; }
            public int value { get; set; }

            public void wyswietl()
            {
                Console.WriteLine(id, waga, value);
            }
        }
        static void Main(string[] args)
        {
            generator rng = new generator();
            int[] tab = { 1, 2, 3 };
            for(int i = 0; i < 10; i++)
            {
                item item = new item();
                Console.WriteLine(rng.rand(1, 10));
                
            }
            Console.Read();
            foreach(int i in tab)
                Console.WriteLine(i);
            Console.Read();

            List<int> list = new List<int>() {1,2,3};
            list.Add(5);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
