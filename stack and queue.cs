using System;

namespace LinkedListStackQueue
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
 

using System;
 
namespace LinkedListStackQueue
{
    class LinkedListStack<T>
    {
        public Node<T> top;

        public void Push(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (this.top == null)
                newNode.next = null;
            else
                newNode.next = top;

            this.top = newNode;
            Console.WriteLine("{0} is push to the stack.", value);
        }

        public void display()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }

            Node<T> temp = this.top;

            while (temp != null)
            {
                Console.WriteLine(temp.Data + " ");
                temp = temp.next;
            }
        }

        public void Peak()
        {

            if (this.top != null)
                Console.WriteLine("{0} is top element.", this.top.Data);
            else
                Console.WriteLine("Stack is empty");
        }

        public void Pop()
        {
            if (this.top == null)
                Console.WriteLine("Stack is empty");
            else
            {
                Console.WriteLine("{0} removed form stack", this.top.Data);
                this.top = this.top.next;
            }
        }
    }
}

