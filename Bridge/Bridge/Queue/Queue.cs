using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Queue
{
    internal class Queue
    {
        private FIFOQueue.FIFOQueue implementador;

        public Queue(FIFOQueue.FIFOQueue implementador)
        {
            this.implementador = implementador;
        }

        public void Enqueue(int item)
        {
            implementador.Enqueue(item);
        }

        public void Dequeue()
        {
            implementador.Dequeue();
        }

        public Boolean IsEmpty()
        {
            return implementador.IsEmpty();
        }

        public int Size()
        {
            return implementador.Size();
        }
    }
}
