using System;
namespace SLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            SingleLinkedList list = new SingleLinkedList();
            Node n = new Node();
            n.Data = "root";
            list.add(n);
            for (int i = 0; i < 10; i++)
            {
                Node node = new Node();
                node.Data = Convert.ToString(i);
                list.add(node);
            }

            Console.Write("length of singly linked list=" + list.getLengthOfList());

            n = list.getRoot();
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = list.getNext();
            }
            Console.ReadKey();
        }
    }
}
