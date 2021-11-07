using System;

namespace Stack_And_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 14 Problems \n");
            Console.WriteLine("Please select following options \n");
            Console.WriteLine(" 1.UC_1 \n 2.UC_2 \n 3.UC_3 \n 4.UC_4 \n");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    LinkedListStack<int> listStack = new LinkedListStack<int>();
                    listStack.Push(70);
                    listStack.Push(30);
                    listStack.Push(56);
                    listStack.display();
                    break;

                case 2:
                    LinkedListStack<int> ListStack = new LinkedListStack<int>();
                    ListStack.Push(70);
                    ListStack.Push(30);
                    ListStack.Push(56);
                    ListStack.display();
                    ListStack.Peak();
                    ListStack.Pop();
                    ListStack.display();
                    ListStack.Peak();
                    ListStack.Pop();
                    ListStack.display();
                    ListStack.Peak();
                    ListStack.Pop();
                    ListStack.display();
                    break;

                case 3:
                    LinkedListQueue<int> listQueue = new LinkedListQueue<int>();
                    listQueue.EnQueue(56);
                    listQueue.EnQueue(30);
                    listQueue.EnQueue(70);
                    listQueue.display();
                    break;

                case 4:
                    LinkedListQueue<int> listDQueue = new LinkedListQueue<int>();
                    listDQueue.EnQueue(56);
                    listDQueue.EnQueue(30);
                    listDQueue.EnQueue(70);
                    listDQueue.DeQueue();
                    listDQueue.display();
                    listDQueue.DeQueue();
                    listDQueue.display();
                    listDQueue.DeQueue();
                    listDQueue.display();
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }
        }
    }
}
