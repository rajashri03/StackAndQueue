using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Stack_Ex<T>
    {
        /// <summary>
        ///  create global top reference variable
        /// </summary>

        private Node<T> top;
        public Stack_Ex()//Constructor
        {
            this.top = null;
        }
        /// <summary>
        /// created Method to add an element in the stack
        /// insert at the beginning
        /// </summary>
        /// <param name="data"></param>
        public void Push(T stackvalue)
        {
            Node<T> temp = new Node<T>(stackvalue);//Created new node as temp and allocates memory
            if (temp == null)
            {
                Console.WriteLine("Stack Overflow");
            }
            // initialize data into temp data field
            temp.data = stackvalue;

            // put top reference into temp Next
            temp.Next = top;

            // update top reference
            top = temp;
        }
        public void Display()
        {
            // check for stack Empty/NotEmpty
            Node<T> temp = this.top;
            if (temp == null)
            {
                Console.Write("\nStack is Empty");
                //return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List Contains: ");
                Console.ResetColor();
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.Next;
                }
            }
        }
        /// <summary>
        /// Method for to check stack is empty or not
        /// Bool-To return true and false value
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return top == null;
        }
        /// <summary>
        /// Method to insert element in stack
        /// </summary>
        public void Peek()
        {
            // check for empty stack
            if (!IsEmpty())
            {
                Console.WriteLine("\nTop element is <--{0}", top.data);
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }
        /// <summary>
        /// Method to remove element from stack
        /// </summary>
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine(top.data+"-> Popped From Stack ");
                // update the top pointer to
                // point to the next node
                top = (top).Next;
            }

        }

    }
}
