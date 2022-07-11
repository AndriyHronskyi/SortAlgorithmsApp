using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class AlgorithmBase<T>
    {
        public List<T> Items { get; set; } = new List<T>();

        public void Swop(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {

            }
        }
    }
}
