using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackFrom2Queues;

namespace StackFrom2Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the stack");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                StackFrom2Queues mystack = new StackFrom2Queues(n);


                while (true)
                {
                    Console.WriteLine("Enter 0 to push an item and 1 to pop and 2 to display the stack");
                    try
                    {
                        int querry = Convert.ToInt32(Console.ReadLine());
                        if (querry == 1)
                        {
                            int val = mystack.pop();
                            if (val != 0)
                            {
                                Console.WriteLine("Popped {0}", val);
                            }
                        }
                        else if (querry == 0)
                        {
                            Console.WriteLine("Enter a value");
                            int item = Convert.ToInt32(Console.ReadLine());
                            if (mystack.push(item))
                                Console.WriteLine("Inserted");
                            else Console.WriteLine("Stack is full");

                        }
                        else if (querry == 2)
                            mystack.displayQueue();
                        else Console.WriteLine("Invalid Input");
                    }
                    catch (Exception e)
                    {
                        continue;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input");
                Main(args);
            }

        }
    }
}
