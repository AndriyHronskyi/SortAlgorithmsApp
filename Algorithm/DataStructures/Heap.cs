﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class Heap<T> : AlgorithmBase<T> where T: IComparable
    {
        public int Count => Items.Count;

        //public Heap() { }

        public Heap(IEnumerable<T> items)
        {
            Items.AddRange(items);
            for (int i = Count; i >= 0; i--)
            {
                Sort(i);
            }
        }

        public void Add(T item)
        {
            Items.Add(item);

            var currentIndex = Count - 1;
            var parentIndex = GetParentIndex(currentIndex);

            while (currentIndex > 0 && Compare(Items[parentIndex], Items[currentIndex]) == -1)
            {
                Swop(currentIndex, parentIndex);

                currentIndex = parentIndex;
                parentIndex = GetParentIndex(currentIndex);
            }
        }

        public T GetMax()
        {
            var result = Items[0];

            Items[0] = Items[Count - 1];
            Items.RemoveAt(Count - 1);
            //Swop(sortedCount, Count - 1);
            Sort(0);
            

            return result /*Items[sortedCount]*/;
        }

        private void Sort(int curentIndex, int maxLength = -1)
        {
            int maxIndex = curentIndex;
            int leftIndex;
            int rightIndex;

            maxLength = maxLength == -1 ? Count : maxLength;

            while (curentIndex < maxLength)
            {
                leftIndex = 2 * curentIndex + 1;
                rightIndex = 2 * curentIndex + 2;

                if (leftIndex < maxLength && Compare(Items[leftIndex], Items[maxIndex]) == 1)
                {
                    maxIndex = leftIndex;
                }

                if (rightIndex < maxLength && Compare(Items[rightIndex], Items[maxIndex]) == 1)
                {
                    maxIndex = rightIndex;
                }

                if (maxIndex == curentIndex)
                {
                    break;
                }

                Swop(curentIndex, maxIndex);
                curentIndex = maxIndex;
            }
        }

        private int GetParentIndex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        protected override void MakeSort()
        {
            //var result = new List<T>();
            //while (Count > 0)
            //{
            //    result.Add(GetMax());
            //}
            //Items.AddRange(result);
            for (int i = Count - 1; i >= 0; i--)
            {
                Swop(0, i);
                Sort(0, i);
            }
        }
    }
}
