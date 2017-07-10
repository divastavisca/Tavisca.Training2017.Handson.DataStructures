using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue
    {
        private int[] queue;
        
        private int front, rear,s;
        
        public bool EnQueue(int n)
        {
            if(rear==-1)
            {
                front = rear = 0;
                queue[rear] = n;
                return true;
            }
            else if(rear==s-1)
            {
                if (front > 0)
                {
                    queue[0] = n;
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
                       queue[++rear]=n;
                        return true;
                    }
                    else return false;
                }
                else if(front==rear)
                {
                    if(rear<s-1)
                    {
                        queue[++rear] = n;
                        return true;
                    }
                    else
                    {
                        rear = 0;
                        queue[rear] = n;
                        return true;
                    }
                }
                else
                {
                    if (rear == s-1)
                    {
                        queue[0] = n;
                        rear = 0;
                        return true;
                    }
                    else { queue[++rear] = n; return true; }
                }
            }
        }

        public void DeQueue()
        {
            if(front==rear)
            {
                if (front > -1)
                {
                    front = rear = -1;
                }
                else Console.WriteLine("Queue is empty");
            }
            else
            {
                if(front+1<=rear)
                {
                    front++;
                }
                else if(front>rear)
                {
                    if (front == s-1)
                        front = 0;
                    else front++;
                }
            }
        }

        public void display()
        {
            if(front==rear)
            {
                if (front == -1)
                    Console.WriteLine("Empty");
                else Console.WriteLine(queue[front]);
            }
            else if(front>rear)
            {
                for (int i= front;i < s;i++)
                {
                    Console.WriteLine(queue[i]+" ");
                }
                for (int i=0;i<=rear;i++)
                {
                    Console.WriteLine(queue[i] + " ");
                }
            }
            else
            {
                for (int i = front; i <=rear; i++)
                {
                    Console.WriteLine(queue[i] + " ");
                }
            }
        }
        public Queue(int n)
        {
            front = rear = -1;
            queue = new int[n];
            s = n;
        }
        
    }
}
