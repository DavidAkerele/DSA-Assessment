using System;
using System.IO;

namespace StarterCode_WayPoints
{
    public class WaypointsAll
    {
        private Waypoint[] waypoints;
        private int count;
        private const int MAX_WAYPOINTS = 3000;

        public WaypointsAll()
        {
            waypoints = new Waypoint[MAX_WAYPOINTS];
            count = 0;
        }

        public int Count => count;
    }
}
