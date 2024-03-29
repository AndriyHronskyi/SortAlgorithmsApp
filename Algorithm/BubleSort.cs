﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class BubleSort<T> : AlgorithmBase<T> where T: IComparable
    {
        public BubleSort(IEnumerable<T> items) : base(items) { }

        public BubleSort() { }

        protected override void MakeSort()
        {
            var count = Items.Count;

            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count - 1 - j; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];

                    if (Compare(a,b) == 1)
                    {
                        Swop(i, i + 1);
                    }
                }
            }
            
        }
    }
}
