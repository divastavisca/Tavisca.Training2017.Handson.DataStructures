using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicDS;

namespace StackFrom2Queues
{
    public class StackFrom2Queues
    {
        private Queue Queue1, Queue2;
        private int size;

        public bool push(int n)
        {
            return (Queue1.EnQueue(n));
        }

        public int pop()
        {
            int val,newval;
            if (Queue1.IsEmpty())
                return 0;
            if (!Queue1.IsLast())
            {
                while (!Queue1.IsLast())
                {
                    Queue1.DeQueue(out val);
                    Queue2.EnQueue(val);
                }
                Queue1.DeQueue(out newval);
                while (Queue2.DeQueue(out val))
                {
                    Queue1.EnQueue(val);
                }
                return newval;
            }
            else if (Queue1.IsLast())
            {
                Queue1.DeQueue(out val);
                return val;
            }
            else return 0;
            /*if (Queue1.DeQueue(out newval))
            {
                val = newval;
                Queue2.EnQueue(val);
                while (Queue1.DeQueue(out newval))
                {
                    val = newval;
                    if (Queue1.DeQueue(out newval))
                    {
                        Queue2.EnQueue(val);
                        val = newval;
                        Queue2.EnQueue(val);
                    }
                    else break;
                } 
                while (Queue2.DeQueue(out newval2))
                {
                    val1 = newval2;
                    Queue1.EnQueue(val);
                }
                return val;
            }
            else return 0;*/
        }

        public void displayQueue()
        {
            Queue1.DisplayQ();
        }

        public StackFrom2Queues(int n)
        {
            Queue1 = new Queue(n);
            Queue2 = new Queue(n);
            size = n;
        }
    }
}
