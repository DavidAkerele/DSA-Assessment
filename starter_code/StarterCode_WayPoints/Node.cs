namespace StarterCode_WayPoints
{
    public class Node
    {
        private Waypoint data;
        private Node next;

        public Node(Waypoint data)
        {
            this.data = data;
            this.next = null;
        }

        public Waypoint Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
