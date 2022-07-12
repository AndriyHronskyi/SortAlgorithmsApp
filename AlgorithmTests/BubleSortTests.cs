﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Tests
{
    [TestClass()]
    public class BubleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            // arrange
            var buble = new BubleSort<int>();

            var rnd = new Random();
            var items = new List<int>();

            for (int i = 0; i < 8000; i++)
            {
                items.Add(rnd.Next(0,100));
            }

            buble.Items.AddRange(items);
            items.Sort();

            // act
            buble.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], buble.Items[i]);
            }

        }
    }
}