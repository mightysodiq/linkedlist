using customlinkedlist;
using System;
namespace myLinkedlist
{
    class program
    {
        static void Main(string[] args)
        {
            LinkedList<string> ||= new LinkedList<string>();
            Node<string>a=newNode<string>("aa");
            ||.AddFirst(a);
            Node<string> b = newNode<string>("bbb");
            ||.Add First(b);
            Node<string> c= newNode<string>("ccc");
            ||.AddFirst(c);
            Node<string>d=newNode<string>("ddd");
            ||.AddFirst(d);
            ||.Traverse();
            Console.WriteLine("Addaftera");
            ||.AddAfter(newNode<string>("xxx"), a);
            ||.Traverse();
            Node<string>target-||.find("ddd");
            if(target==null)
            {
                Console.WriteLine("found" + target.Data);
            }
            else
            {
                Console.WriteLine("foobar");
            }
        }
    }
}