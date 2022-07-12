﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class AlgorithmBase<T> where T: IComparable
    {
        public int SwopCount { get; protected set; } = 0;
        public int ComparisonCount { get; protected set; } = 0;

        public List<T> Items { get; set; } = new List<T>();

        protected void Swop(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;

                SwopCount++;
            }
        }
        /*
        public void FillRandom(int count)
        {
            var rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                Items.Add(rnd.Next(0, 100));
            }
        }*/

        public virtual void Sort() {
            SwopCount = 0;
            Items.Sort();
        }
    }
}
