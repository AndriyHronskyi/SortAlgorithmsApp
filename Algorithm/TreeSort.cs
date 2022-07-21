using Algorithm.DataStructures;
using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class TreeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public TreeSort(IEnumerable<T> items) : base(items) { }

        public TreeSort() { }
        protected override void MakeSort()
        {
            var tree = new Tree<T>(Items);
            var sorted = tree.Inorder();
            Items = sorted;
        }
    }
}
