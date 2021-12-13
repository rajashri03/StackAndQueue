using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    /// <summary>
    /// Created class (Node)With one parameter(T)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        /// <summary>
        /// Declaring variable
        /// </summary>
        public T data;
        public Node<T> Next;
        public Node(T value)//Parameterized Constructor
        {
            this.data = value;
        }
    }
}
