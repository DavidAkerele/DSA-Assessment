using System;

namespace StarterCode_WayPoints
{
    public class MyLinkedList
    {
        private Node head;
        private int count;

        public MyLinkedList()
        {
            head = null;
            count = 0;
        }

        public int Count => count;

        public void Add(Waypoint wp)
        {
            Node newNode = new Node(wp);
            if (head == null) { head = newNode; }
            else
            {
                Node current = head;
                while (current.Next != null) { current = current.Next; }
                current.Next = newNode;
            }
            count++;
        }

        public bool Insert(int index, Waypoint wp)
        {
            if (index < 0 || index > count) return false;
            Node newNode = new Node(wp);
            if (index == 0) { newNode.Next = head; head = newNode; }
            else
            {
                Node current = head;
                for (int i = 0; i < index - 1; i++) { current = current.Next; }
                newNode.Next = current.Next;
                current.Next = newNode;
            }
            count++;
            return true;
        }

        public bool Remove(string name)
        {
            if (head == null) return false;
            if (head.Data.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                head = head.Next; count--; return true;
            }
            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    current.Next = current.Next.Next; count--; return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Display()
        {
            Node current = head;
            int i = 1;
            while (current != null)
            {
                Console.WriteLine($"{i}. {current.Data.Name} ({current.Data.Code})");
                current = current.Next;
                i++;
            }
        }
    }
}
