using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicDS;

/// <summary>
/// Provides support for for using Queues implemented as Stacks
/// </summary>
namespace QueueViaStack
{
    /// <summary>
    /// Implements a Queue using Stacks
    /// </summary>
    public class QueueWithStacks
    {
        private Stack stack_enqueue, stack_dequeue;
        private int size_of_stack;

        /// <summary>
        /// Insert an Element into the Queue
        /// </summary>
        /// <param name="Element"></param>
        /// <returns></returns>
        public bool EnQueue(int Element)
        {
            if (stack_enqueue.Push(Element))
            {
                Console.WriteLine("Inserted");
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Delete an element from the Queue
        /// </summary>
        public void DeQueue()
        {
            int ElementPoped = stack_enqueue.Pop();
            while(ElementPoped!=0)
            {
                stack_dequeue.Push(ElementPoped);
                ElementPoped=stack_enqueue.Pop();
            }
            stack_dequeue.Pop();
            ElementPoped = stack_dequeue.Pop();
            while(ElementPoped!=0)
            {
                stack_enqueue.Push(ElementPoped);
                ElementPoped = stack_dequeue.Pop();
            }
        }

        /// <summary>
        /// Display the contents of a Queue
        /// </summary>
        public void Display()
        {
            if(!stack_enqueue.IsEmpty())
            {
                stack_enqueue.Display();
            }
        }

        /// <summary>
        /// Create an instance of a Queue
        /// </summary>
        /// <param name="SizeOfQueue"></param>
        public QueueWithStacks(int SizeOfQueue)
        {
            stack_enqueue = new Stack(SizeOfQueue);
            stack_dequeue = new Stack(SizeOfQueue);
            size_of_stack = SizeOfQueue;
        }
    }
}
