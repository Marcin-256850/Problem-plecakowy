using System;
using System.Collections.Generic;


namespace _259290
{


    public class Knapsack
    {
        public List<Item> items;
        public List<Item> items2;

        public Knapsack(int n, int[] v, int[] w)
        {
            items = new List<Item>();

            for (int i = 0; i < n; i++)
            {
                Item item = new Item(v[i], w[i], i);
                items.Add(item);
            }
        }

        public Knapsack(int num, int seed)
        {
            items = new List<Item>();
            Random rand = new Random(seed);


            for (int i = 0; i < num; i++)
            {
                int v = rand.Next(1, 9);
                int w = rand.Next(1, 9);
                Item item = new Item(v, w, i);
                items.Add(item);


            }

        }

        public int countCapacity(int capacity, int ilosc)
        {
            items2 = new List<Item>();
            int cap_tmp = 0;
            int cap1 = 0;
            for (int i = 0; i < ilosc; i++)
            {
                cap_tmp = cap1 + items[i].value * items[i].weight;
                if (cap_tmp <= capacity)
                {
                    cap1 = cap_tmp;
                    items2.Add(items[i]);
                }
                else
                {
                    cap_tmp = cap1;
                }
            }

            return cap1;
        }


        public void printItems()
        {

            for (int i = 0; i < items2.Count; i++)
            {

                Console.WriteLine("num: " + items2[i].num + " val: " + items2[i].value + " wei: " + items2[i].weight + "\n");

            }
        }


        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < items.Count; i++)
            {

                str += "num: " + i + " val: " + items[i].value + " wei: " + items[i].weight + "\n";

            }
            return str;
        }


    }
}
