using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Queue_Ex<T>
    {
        Node<T> head = null;
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
                head = node;
            else
            {
                Node<T> temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine(node.data + " is Added in Queue");
        }
        public Node<T> Dequeue()
        {
            if (head == null)
            {
                return null;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAfter Dequeue");
                Console.ResetColor();
                head = head.Next;
                return head;
            }
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nList Contains:");
            Console.ResetColor();
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.Next;
            }
            Console.WriteLine("\n");
        }
    }
}