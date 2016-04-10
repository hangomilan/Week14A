using System;
using System.Collections;

namespace SequentialCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            while (queue.Count > 0) {
                object o = queue.Dequeue();
                Console.WriteLine("From queue: {0}", o);
            }

            Console.WriteLine();

            Stack stack = new Stack();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");

            while (stack.Count > 0) {
                object o = stack.Pop();
                Console.WriteLine("From stack: {0}", o);
            }
        }
    }
}
