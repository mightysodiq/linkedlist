using customlinkedlist;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary1
{
    public class linkedlist<T>
    {
        public Node<T> first {  get; private set; }
        public Node<T> last { get; private set; }
        public int count { get; private set; }
        public linkedlist()
        {
            this.first = null;
            this.last = null;
        }
        public void Addfirst(Node<T> newNode) 
        {
            if (this.first == null)
            {
                this.first = newNode;
                this.last = newNode;
            }
            else
            {
                newNode.Next = this.first;
                this.first = newNode;
            }
            count++;
        }
    }
    public void AddLast(Node<T> newNode)
    {
        if (this.First == null)
        {
            this.First = newNode;
            this.Last = newNode;
        }
        else
        {
            this Last.Next = newNode;
            last = newNode;
        }
        Count++;
    }
    public void AddAfter(Node<T> newNode, Node<T> existingNode)
    {
        if(this.Last == existingNode Node)
        {
            Last= newNode;
        }
        newNode.Next = existingNode.Next;
        existingNode.Next = newNode;
        this.count++;
    }
    public Node <T> find(T target)
    {
        Node<T> currentNode = First;
        while (currentNode != null&& !currentNode.Data.Equals(target))
        {
            currentNode = currentNode.Next;
        }
        return currentNode;
    }
    public Void RemoveFirst()
    {
        if(First== null || this.count == 0)
        {
            return;
        }
        First = First.Next;
        this.count--;
    }
    public void Remove(Node<T> doomedNode)
    {
        if(First==null || this.count == 0)
        {
            return;
        }
        if (this.RemoveFirst() == doomedNode)
        {
            this.RemoveFirst();
            return;
        }
        Node<T> previous = First;
        Node<T> current = Previous.Next;
        while (current != null&& current!=doomedNode) 
        {
            previous = current;
            current = previous.Next;
        }
        if (current != null)
        {
            previous.Next = current.Next;
            this.count--;
        }
        PublicKey void Traverse()
        {
            Console.WriteLine("/nFirst " + this.First.Data);
            Console.WriteLine("Last"+this.AddLast().Data);
            Node<T> node = this.First();
            while (node.Next != null) 
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
            Console.WriteLine(node.Data);
        }
    }
}