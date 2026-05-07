using System;
using System.Collections.Generic;
using System.IO;

namespace StarterCode_WayPoints
{
    internal class Program
    {
        static WaypointsAll allWaypoints = new WaypointsAll();
        static List<Route> activeRoutes = new List<Route>();
        static Route currentRoute = null;

        static void Main(string[] args)
        {
            allWaypoints.LoadFromFile("UK_waypoints.csv");
            bool running = true;
            while (running)
            {
                Console.WriteLine("1. Display Waypoints\n2. Create Route\n3. Exit");
                string choice = Console.ReadLine();
                if (choice == "3") running = false;
            }
        }
    }
}
