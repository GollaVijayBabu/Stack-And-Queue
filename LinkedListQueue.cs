using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_And_Queue
{
    class LinkedListQueue<T>
    {
        public Node<T> head;

        public void EnQueue(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
            {
                Node<T> temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is enqueue to the queue.", this.head.Data);
        }

        public void DeQueue()
        {
            if (this.head == null)
                Console.WriteLine("Queue is empty");
            else
            {
                Console.WriteLine("{0} is removed from Queue", this.head.Data);
                this.head = this.head.next;
            }
        }

        public void display()
        {
            if (head == null)
                Console.WriteLine("Queue is empty");
            else
            {
                Node<T> temp = head;
                while (temp != null && temp.Data != null)
                {
                    Console.WriteLine(temp.Data + "\t");
                    temp = temp.next;
                }
            }
        }
    }
}



