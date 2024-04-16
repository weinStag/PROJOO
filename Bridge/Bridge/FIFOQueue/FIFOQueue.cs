using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.FIFOQueue
{
    internal interface FIFOQueue
    {
        void Enqueue(int item);
        void Dequeue();
        Boolean IsEmpty();
        int Size();
    }
}
