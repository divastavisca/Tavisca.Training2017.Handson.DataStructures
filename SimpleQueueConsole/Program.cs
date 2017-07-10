using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicDS;

namespace ConsoleApp1
{
    /// <summary>
    /// Program to simulate a Normal Queue
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of queue");
            int SizeOfQueue = Convert.ToInt32(Console.ReadLine());
            Queue QueueObject = new Queue(SizeOfQueue);
            while (true)
            {
                Console.WriteLine("Enter 0 to insert an item and 1 to delete and 2 to display the stack");
                try
                {
                    int Query = Convert.ToInt32(Console.ReadLine());
                    if (Query == 1)
                    {
                        QueueObject.DeQueue();
                    }
                    else if (Query == 0)
                    {
                        Console.WriteLine("Enter a value");
                        int Element = Convert.ToInt32(Console.ReadLine());
                        if (QueueObject.EnQueue(Element))
                            Console.WriteLine("Inserted");
                        else Console.WriteLine("Queue is full");

                    }
                    else if (Query == 2)
                        QueueObject.Display();
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
