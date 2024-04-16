using System;
using System.Collections.Generic;

namespace List.List
{
    internal class List
    {
        // mais proximo do java utils List
        private IList<int> implementador;

        public List(IList<int> implementador)
        {
            this.implementador = implementador;
        }

        public void Add(int item)
        {
            // Queue Item
            implementador.Add(item);
        }

        public void Remove(int idx)
        {
            // Dequeue Item by Index
            Console.WriteLine("Item Removed: " + implementador[idx]);
            implementador.RemoveAt(idx);
        }

        public bool IsEmpty()
        {
            return implementador.Count == 0;
        }

        public int Size()
        {
            return implementador.Count;
        }
    }
}
