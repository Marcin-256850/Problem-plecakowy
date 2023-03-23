using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _259290;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StartingKnapsackLenght()  /*Sprawdzenie, czy jeśli co najmniej jeden przedmiot spełnia ograniczenia, to zwrócono co najmniej jeden element.*/
        {
            Knapsack knapsack = new Knapsack(10, 10);
            Assert.AreEqual(10, knapsack.items.Count);
        }

        [TestMethod]
        public void EmptySnapback()     /*Sprawdzenie, czy jeśli ani jeden przedmiot nie spełnia ograniczeń, to zwrócono puste rozwiązanie.*/
        {
            Knapsack knapsack = new Knapsack(1, 1);
            int cap = knapsack.countCapacity(0,1);
            Assert.AreEqual(0, cap);
            Assert.IsTrue(0 == knapsack.items2.Count);
        }

        [TestMethod]
        public void FillingTheKnapsack() /*Sprawdzenie, czy jeśli co najmniej jeden przedmiot spełnia ograniczenia, to zwrócono co najmniej jeden element.*/
        {
            Knapsack knapsack = new Knapsack(1, 1);
            knapsack.countCapacity(100,1);
            Assert.IsTrue(1 == knapsack.items2.Count);
        }

        [TestMethod]    /*Sprawdzenie poprawności liczenia pojemności*/
        public void countCapacityCheck()
        {
            Knapsack knapsack = new Knapsack(1, 1);
            int cap = knapsack.countCapacity(100,1);
            int cap_tmp = knapsack.items[0].weight * knapsack.items[0].value;
            Assert.AreEqual(cap, cap_tmp);

        }


        [TestMethod]

        public void ItemsOrder() /*Sprawdzenie, czy kolejność przedmiotów ma wpływa na znalezione rozwiązanie. (ma)*/
        {

            int[] v = { 1, 1, 2 }, w = { 1, 2, 2 };
            Knapsack knapsack = new Knapsack(3, v, w);
            for (int i = 0; i < 3; i++)
            {
                Item item = new Item(v[i], w[i], i);
                knapsack.items.Add(item);

            }
            int cap1 = knapsack.countCapacity(5, 3);
            Item item_tmp1 = knapsack.items2[1];
            Knapsack knapsack1 = new Knapsack(3, v, w);
            Item item0 = new Item(v[0], w[0], 0);
            knapsack1.items[0] = item0;

            Item item2 = new Item(v[2], w[2], 2);
            knapsack1.items[1] = item2;

            Item item1 = new Item(v[1], w[1], 1);
            knapsack1.items[2] = item1;


            int cap2 = knapsack1.countCapacity(5, 3);
            Item item_tmp2 = knapsack1.items2[1];

            Assert.AreNotEqual(cap1, cap2);
            Assert.AreNotEqual(item_tmp1.num, item_tmp2.num);


        }

        [TestMethod]
        public void Solution() /*Sprawdzenie konkretnego rozwiązania*/
        {

            int[] v = { 1, 1, 2 }, w = { 1, 2, 2 };
            Knapsack knapsack = new Knapsack(3, v, w);
            for (int i = 0; i < 3; i++)
            {
                Item item = new Item(v[i], w[i], i);
                knapsack.items.Add(item);
            }
            int cap1 = knapsack.countCapacity(5,3);
            Console.WriteLine(cap1);

            Assert.AreEqual(knapsack.items[0].value, 1);
            Assert.AreEqual(knapsack.items[0].weight, 1);
            Assert.AreEqual(knapsack.items[0].num, 0);

            Assert.AreEqual(knapsack.items[1].value, 1);
            Assert.AreEqual(knapsack.items[1].weight, 2);
            Assert.AreEqual(knapsack.items[1].num, 1);

            Assert.AreEqual(knapsack.items[2].value, 2);
            Assert.AreEqual(knapsack.items[2].weight, 2);
            Assert.AreEqual(knapsack.items[2].num, 2);

            Assert.IsTrue(knapsack.items2[0].value == 1);
            Assert.IsTrue(knapsack.items2[0].weight == 1);
            Assert.IsTrue(knapsack.items2[0].num == 0);

            Assert.IsTrue(knapsack.items2[1].value == 1);
            Assert.IsTrue(knapsack.items2[1].weight == 2);
            Assert.IsTrue(knapsack.items2[1].num == 1);

            Assert.AreEqual(3, cap1);

        }



    }

}
