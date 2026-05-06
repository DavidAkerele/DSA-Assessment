using System;
using System.IO;
using System.Text;

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

        public void LoadFromFile(string fileName)
        {
            if (!File.Exists(fileName)) return;
            string[] lines = File.ReadAllLines(fileName);
            int fileLine = 0;
            foreach (string line in lines)
            {
                fileLine++;
                if (fileLine != 1 && !string.IsNullOrWhiteSpace(line))
                {
                    string[] feat = line.Split(',');
                    if (feat.Length < 11) continue;
                    if (count < MAX_WAYPOINTS)
                    {
                        waypoints[count] = new Waypoint(feat[0], feat[1], feat[3], feat[4], 0, feat[10]);
                        count++;
                    }
                }
            }
        }

        public Waypoint FindWaypoint(string searchStr)
        {
            for (int i = 0; i < count; i++)
            {
                if (waypoints[i].Name.Equals(searchStr, StringComparison.OrdinalIgnoreCase) || 
                    waypoints[i].Code.Equals(searchStr, StringComparison.OrdinalIgnoreCase))
                    return waypoints[i];
            }
            return null;
        }
    }
}
