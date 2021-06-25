using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTab ");
            MyMapNode<int, string> node = new MyMapNode<int, string>(6);
            node.Add(0, "to");
            node.Add(1, "be");
            node.Add(2, "or");
            node.Add(3, "not");
            node.Add(4, "to");
            node.Add(5, "be");
            string node0 = node.Get(0);
            Console.WriteLine("Frequency of to : " + node0);
            string node1 = node.Get(1);
            Console.WriteLine("Frequency of be : " + node1);
            string node2 = node.Get(2);
            Console.WriteLine("Frequency of or : " + node2);
            string node3 = node.Get(3);
            Console.WriteLine("Frequency of not : " + node3);
        }
    }
}
