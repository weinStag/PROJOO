using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FIFOQueue.FIFOQueue arrayListQueue = new ArrayListQueue.ArrayListQueue();
            FIFOQueue.FIFOQueue vectorQueue = new VectorQueue.VectorQueue();
            Queue.Queue queue = new Queue.Queue(arrayListQueue);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine("ArrayListQueue:");

            while (!queue.IsEmpty())
            {
                Console.WriteLine("Size = " + queue.Size());
                queue.Dequeue();
            }

            queue = new Queue.Queue(vectorQueue);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine("VectorQueue:");

            while (!queue.IsEmpty())
            {
                Console.WriteLine("Size = " + queue.Size());
                queue.Dequeue();
            }

            Console.ReadKey();
        }
    }
}
