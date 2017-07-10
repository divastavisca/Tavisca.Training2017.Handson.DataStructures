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
    /// Support for basic stack functions
    /// </summary>
    public class Stack
    {
        private int[] stack_array;
        private int top_of_stack;
        private int stack_size;

        /// <summary>
        /// Pushes an element onto the stack
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool Push(int Element)
        {
            if (top_of_stack < stack_size - 1)
            {
                stack_array[++top_of_stack] = Element;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Pops the top stack element
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (top_of_stack > -1)
                return (stack_array[top_of_stack--]);
            else return 0;
        }

        /// <summary>
        /// Dispays the Stack content
        /// </summary>
        public void Display()
        {
            if (top_of_stack > -1)
            {
                for (int Index = 0; Index <= top_of_stack; Index++)
                    Console.WriteLine(stack_array[Index] + " ");
            }
            else Console.WriteLine("Stack is empty");
        }

        /// <summary>
        /// Tells whether the stack is empty or not
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return (top_of_stack == stack_size - 1);
        }

        /// <summary>
        /// Returns the element at the specific Index
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public int ElementAtIndex(int Index)
        {
            return(stack_array[Index]);
        }

        /// <summary>
        /// Returns the index of the top of the stack
        /// </summary>
        /// <returns></returns>
        public int TopOfStack()
        {
            return (top_of_stack);
        }

        /// <summary>
        /// Create a new stack instance
        /// </summary>
        /// <param name="n"></param>
        public Stack(int SizeOfStack)
        {
            stack_array = new int[SizeOfStack];
            top_of_stack = -1;
            stack_size = SizeOfStack;
        }

        
        
    }
}
