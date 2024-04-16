﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.VectorQueue
{
    internal class VectorQueue : Bridge.FIFOQueue.FIFOQueue
    {
        private List<int> queue = new List<int>();

        public void Enqueue(int item)
        {
            queue.Add(item);
        }

        public void Dequeue()
        {
            queue.RemoveAt(0);
        }

        public Boolean IsEmpty()
        {
            return queue.Count == 0;
        }

        public int Size()
        {
            return queue.Count;
        }
    }
}
