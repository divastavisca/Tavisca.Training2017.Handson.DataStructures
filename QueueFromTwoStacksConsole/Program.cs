using QueueViaStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueFromTwoStacksConsole
{
    /// <summary>
    /// Program to simulate a Queue using two stacks
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the queue");
            int SizeOfQueue=Convert.ToInt32(Console.ReadLine());
            QueueWithStacks Queue = new QueueWithStacks(SizeOfQueue);
            while (true)
            {
                Console.WriteLine("Enter 0 to insert an item and 1 to delete and 2 to display the stack");
                try
                {
                    int Query = Convert.ToInt32(Console.ReadLine());
                    if (Query == 1)
                    {
                        Queue.DeQueue();
                    }
                    else if (Query == 0)
                    {
                        Console.WriteLine("Enter a value");
                        int Element = Convert.ToInt32(Console.ReadLine());
                        if (Queue.EnQueue(Element))
                            Console.WriteLine("Inserted");
                        else Console.WriteLine("Queue is full");

                    }
                    else if (Query == 2)
                        Queue.Display();
                    else Console.WriteLine("Invalid Input");
                }
                catch (Exception Excep)
                {
                    continue;
                }
            }

        }
    }
}
