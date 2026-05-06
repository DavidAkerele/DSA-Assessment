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
                    
                    int elev = ConvertElevation(feat[5]);
                    string desc = BuildDesc(feat);

                    if (count < MAX_WAYPOINTS)
                    {
                        waypoints[count] = new Waypoint(feat[0], feat[1], feat[3], feat[4], elev, desc);
                        count++;
                    }
                }
            }
        }

        private int ConvertElevation(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return 0;
            char[] units = { 'f', 't', 'M', 'm', ' ' };
            string numPart = str.TrimEnd(units);
            if (!double.TryParse(numPart, out double val)) return 0;
            if (str.ToLower().EndsWith("m")) return (int)val;
            return (int)(val * 0.3048); // Fixed: Correct factor for ft to m
        }

        private string BuildDesc(string[] feat)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 10; i < feat.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(feat[i])) sb.Append(feat[i] + (i < feat.Length - 1 ? "," : ""));
            }
            return sb.ToString().TrimEnd(',');
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
        
        public void DisplayAll(int limit = 20)
        {
            for (int i = 0; i < Math.Min(limit, count); i++)
                Console.WriteLine($"{i + 1}. {waypoints[i].Name} ({waypoints[i].Code})");
        }
    }
}
