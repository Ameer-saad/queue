using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    class queue
    {
        int front, rear, size;
        int[] queuearray;
        public queue(int l)
        {
            size = l;
            queuearray = new int[size];
            front = -1;
            rear = -1;
        }
        public bool Isempty()
        {
            return (rear == -1);
        }
        public bool Isfull()
        {
            return (rear == size - 1);
        }
        public void Enqueue(int x)
        {
            queuearray[++rear] = x;
            if (front == -1) front++;
        }
        public int dequeue()
        {
            int x = queuearray[front];
            if (front == rear)
            {
                front = -1; rear = -1;
            }
            else front++;
            return x;
        }
        public void print()
        {
            Console.Write("the elements are : ");
            for (int i = front; i <= rear; i++)
                Console.Write(" " + "[" + queuearray[i] + "]");
            Console.WriteLine();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter the elements");
            queue que1 = new queue(7);
            queue oddque = new queue(7);

            for (int i = 0; i < 7; i++)
            {
                int x = int.Parse(Console.ReadLine());
                que1.Enqueue(x);
            }
            que1.print();
            for (int i = 0; i < 7; i++)
            {
                int x = que1.dequeue();
                if (x % 2 == 1)
                    oddque.Enqueue(x);
            }
            Console.Write("transfering odd number of ");
            oddque.print();
            Console.ReadLine();

        }
    }

}
