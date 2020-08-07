using System;

namespace PriorityQueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, element, elementPriority;
            PriorityQueueL prq = new PriorityQueueL();
            while (true)
            {
                Console.WriteLine("1.Insert a new element");
                Console.WriteLine("2.Delete an element ");
                Console.WriteLine("3.Display the queue");
                Console.WriteLine("4.Quit");
                Console.Write("enter your choice ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 4)
                    break;
                switch (choice)
                {
                    case 1:
                        Console.Write("enter an element ");
                        element = Convert.ToInt32(Console.ReadLine());
                        Console.Write("enter element priority");
                        elementPriority = Convert.ToInt32(Console.ReadLine());
                        prq.Insert(element, elementPriority);
                        break;
                    case 2:
                        Console.WriteLine("Deleted element is " + prq.Delete());
                        break;
                    case 3:
                        prq.Display();
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
