using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Provides Support of basic Data Structures
/// </summary>
namespace BasicDS
{
    /// <summary>
    /// Support for basic queue functions implemented in a circular view
    /// </summary>
    public class Queue
    {
        private int[] queue_array;

        private int front, rear, size_of_queue;

        /// <summary>
        /// Inserts an element to the queue instance
        /// </summary>
        /// <param name="Element"></param>
        /// <returns></returns>
        public bool EnQueue(int Element)
        {
            if (rear == -1)
            {
                front = rear = 0;
                queue_array[rear] = Element;
                return true;
            }
            else if (rear == size_of_queue - 1)
            {
                if (front > 0)
                {
                    queue_array[0] = Element;
                    rear = 0;
                    return true;
                }
                else return false;
            }
            else
            {
                if (front > rear)
                {
                    if ((rear + 1) != front)
                    {
                        queue_array[++rear] = Element;
                        return true;
                    }
                    else return false;
                }
                else if (front == rear)
                {
                    if (rear < size_of_queue - 1)
                    {
                        queue_array[++rear] = Element;
                        return true;
                    }
                    else
                    {
                        rear = 0;
                        queue_array[rear] = Element;
                        return true;
                    }
                }
                else
                {
                    if (rear == size_of_queue - 1)
                    {
                        queue_array[0] = Element;
                        rear = 0;
                        return true;
                    }
                    else
                    {
                        queue_array[++rear] = Element;
                        return true;
                    }
                }
            }
        }

        /// <summary>
        /// Deletes an element from the queue instance
        /// </summary>
        public void DeQueue()
        {
            if (front == rear)
            {
                if (front > -1)
                {
                    front = rear = -1;
                }
                else Console.WriteLine("Queue is empty");
            }
            else
            {
                if (front + 1 <= rear)
                {
                    front++;
                }
                else if (front > rear)
                {
                    if (front == size_of_queue - 1)
                        front = 0;
                    else front++;
                }
            }
        }

        /// <summary>
        /// Displays the Queue
        /// </summary>
        public void Display()
        {
            if (front == rear)
            {
                if (front == -1)
                    Console.WriteLine("Empty");
                else Console.WriteLine(queue_array[front]);
            }
            else if (front > rear)
            {
                for (int i = front; i < size_of_queue; i++)
                {
                    Console.WriteLine(queue_array[i] + " ");
                }
                for (int i = 0; i <= rear; i++)
                {
                    Console.WriteLine(queue_array[i] + " ");
                }
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(queue_array[i] + " ");
                }
            }
        }

        public void DisplayQ()
        {
            if (rear == -1)
                Console.WriteLine("Empty");
            else
                for (int i = rear; i >= front; i--)
                    Console.Write(queue_array[i] + " ");
        }

        /// <summary>
        /// Deletes an element from the queue and returns its value in the Removed out parameter
        /// </summary>
        /// <param name="Removed"></param>
        /// <returns></returns>
        public bool DeQueue(out int Removed)
        {
            if (front == rear)
            {
                if (front > -1)
                {
                    Removed = queue_array[front];
                    front = rear = -1;
                    return true;
                }
                else
                {
                    Removed = int.MaxValue;
                    return false;
                }
            }
            else
            {
                if (front + 1 <= rear)
                {
                    Removed = queue_array[front];
                    front++;
                    return true;
                }
                else if (front > rear)
                {
                    if (front == size_of_queue - 1)
                    {
                        Removed = queue_array[front];
                        front = 0;
                        return true;
                    }
                    else
                    {
                        Removed = queue_array[front++];
                        return true;
                    }
                }
            }
            Removed = int.MaxValue;
            return false;
        }

        /// <summary>
        /// Returns true if their is a single element left in the queue
        /// </summary>
        /// <returns></returns>
        public bool IsLast()
        {
            return (front == rear && rear > -1);
        }

        /// <summary>
        /// Returns true if the queue is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if ((front == -1))
            {
                Console.WriteLine("Empty");
                return true;
            }
            else return false;

        }

        /// <summary>
        /// Constructs an instance of the queue
        /// </summary>
        /// <param name="SizeOfQueue"></param>
        public Queue(int SizeOfQueue)
        {
            front = rear = -1;
            queue_array = new int[SizeOfQueue];
            size_of_queue = SizeOfQueue;
        }

    }
}
