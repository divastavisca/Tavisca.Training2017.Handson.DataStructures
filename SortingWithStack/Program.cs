using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicDS;


namespace SortingWithStack
{
    /// <summary>
    /// Sorting an array of integers using a Stack
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Stack StackObject;
            int[] StackArray;
            Console.WriteLine("Enter the size of the array");
            int Element = Convert.ToInt32(Console.ReadLine()), SortIndex;
            StackArray = new int[Element];
            StackObject = new Stack(Element);
            Console.WriteLine("Enter {0} elements", Element);
            for (int Index = 0; Index < Element; Index++)
                StackArray[Index] = Convert.ToInt32(Console.ReadLine());
            for (int Iteration = 0; Iteration < Element ; Iteration++)
            {
                if (StackArray[0] > StackArray[1])
                {
                    StackObject.Push(StackArray[0]);
                    StackArray[0] = StackArray[1];
                }
                else
                {
                    StackObject.Push(StackArray[1]);
                    StackArray[1] = StackArray[0];
                }
                for (SortIndex = 2; SortIndex < Element - Iteration; SortIndex++)
                {
                    if(StackObject.ElementAtIndex(StackObject.TopOfStack())>StackArray[SortIndex])
                    {
                        StackArray[SortIndex - 1] = StackArray[SortIndex];
                    }
                    else
                    {
                        StackArray[SortIndex - 1] = StackObject.Pop();
                        StackObject.Push(StackArray[SortIndex]);
                    }
                }
                StackArray[SortIndex-1] = StackObject.Pop();
            }
            for (int Index = 0; Index < Element; Index++)
                Console.Write(StackArray[Index] + " ");
            Console.ReadKey();
        }
    }
}
