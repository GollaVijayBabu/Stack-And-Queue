using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_And_Queue 
{
    public class LinkedListStack<T>
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


