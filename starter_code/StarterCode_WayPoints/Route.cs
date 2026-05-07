namespace StarterCode_WayPoints
{
    public class Route
    {
        private string routeName;
        private MyLinkedList waypoints;

        public Route(string name)
        {
            this.routeName = name;
            this.waypoints = new MyLinkedList();
        }

        public string RouteName => routeName;
        public MyLinkedList Waypoints => waypoints;

        public void AddWaypoint(Waypoint wp) { waypoints.Add(wp); }
        public bool RemoveWaypoint(string name) { return waypoints.Remove(name); }
        public void DisplayRoute()
        {
            System.Console.WriteLine($"Route: {routeName}");
            waypoints.Display();
        }
    }
}
