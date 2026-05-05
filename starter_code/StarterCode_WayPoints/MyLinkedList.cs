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
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            count++;
        }
    }
}
