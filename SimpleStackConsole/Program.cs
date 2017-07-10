using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicDS;

namespace StackImplementation
{
    /// <summary>
    /// Program to simulate a Normal Stack
    /// </summary>
    class StackImplementationProgram
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the size of the stack");
                int size_of_stack = Convert.ToInt32(Console.ReadLine());
                Stack StackObject = new Stack(size_of_stack);
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter 0 to push an item and 1 to pop and 2 to display the stack");
                        int Query = Convert.ToInt32(Console.ReadLine());
                        if (Query == 1)
                        {
                            int ValueToBePushed = StackObject.Pop();
                            if (ValueToBePushed != 0)
                            {
                                Console.WriteLine("Popped {0}", ValueToBePushed);
                            }
                        }
                        else if (Query == 0)
                        {
                            Console.WriteLine("Enter a value");
                            int item = Convert.ToInt32(Console.ReadLine());
                            if (StackObject.Push(item))
                                Console.WriteLine("Inserted");
                            else Console.WriteLine("Stack is full");

                        }
                        else if (Query == 2)
                            StackObject.Display();
                        else Console.WriteLine("Invalid Input");
                    }
                    catch(Exception excep)
                    {
                        Console.WriteLine("Invalid Input");
                        continue;
                    }
                }
            }
            catch (Exception excep)
            {
                Console.WriteLine("Invalid Input");
                Main(args);
            }
        }


    }
}
