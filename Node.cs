using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_And_Queue
{
    public class Node<T>
    {
        public T Data;
        public Node<T> next;
        public Node(T data)
        {
            this.Data = data;
        }
    }
}
