// See https://aka.ms/new-console-template for more information
using StackAndQueue;
bool flag = true;
while (flag)
{
    Console.WriteLine("Select:\n1)Stack Using Linked List\n2)Queue using linked list\n");
    int op = Convert.ToInt16(Console.ReadLine());
    switch (op)
    {
        case 1:
            Stack_Ex<int> stackdata = new Stack_Ex<int>();
            stackdata.Push(70);
            stackdata.Push(30);
            stackdata.Push(56);
            stackdata.Display();
            stackdata.Peek();
            stackdata.Pop();
            stackdata.Display();
            stackdata.Peek();
            stackdata.Display();
            break;
        case 2:
            Queue_Ex<int> queudata = new Queue_Ex<int>();
            queudata.Enqueue(70);
            queudata.Enqueue(30);
            queudata.Enqueue(56);
            queudata.Display();
            queudata.Dequeue();
            queudata.Display();
            queudata.Dequeue();
            queudata.Display();
            queudata.Dequeue();
            queudata.Display();
            break;
        default:
            flag = !flag;
            break;
    }
}
