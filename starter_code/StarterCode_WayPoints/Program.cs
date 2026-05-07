using System;
using System.Collections.Generic;
using System.IO;

namespace StarterCode_WayPoints
{
    internal class Program
    {
        static string FILE_PATH = "..\\..\\..\\"; 
        static string fileName = "UK_waypoints.csv"; 
        
        static WaypointsAll allWaypoints = new WaypointsAll();
        static List<Route> activeRoutes = new List<Route>();
        static Route currentRoute = null;

        static void Main(string[] args)
        {
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FILE_PATH, fileName);
            if (!File.Exists(fullPath)) fullPath = fileName;
            allWaypoints.LoadFromFile(fullPath);

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n--- GPS Manager ---");
                Console.WriteLine("1. Show All Waypoints\n2. Search Waypoint\n3. Create Route\n4. Add to Route\n5. Remove from Route\n6. Display Route\n7. Exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": allWaypoints.DisplayAll(); break;
                    case "2": Search(); break;
                    case "3": Create(); break;
                    case "4": AddTo(); break;
                    case "5": RemoveFrom(); break;
                    case "6": if (currentRoute != null) currentRoute.DisplayRoute(); break;
                    case "7": running = false; break;
                }
            }
        }

        static void Search() { Console.Write("Search: "); string s = Console.ReadLine(); Waypoint wp = allWaypoints.FindWaypoint(s); if (wp != null) Console.WriteLine(wp); }
        static void Create() { Console.Write("Route Name: "); string n = Console.ReadLine(); currentRoute = new Route(n); activeRoutes.Add(currentRoute); }
        static void AddTo() { if (currentRoute == null) return; Console.Write("Waypoint: "); string s = Console.ReadLine(); Waypoint wp = allWaypoints.FindWaypoint(s); if (wp != null) currentRoute.AddWaypoint(wp); }
        static void RemoveFrom() { if (currentRoute == null) return; Console.Write("Name: "); string n = Console.ReadLine(); currentRoute.RemoveWaypoint(n); }
    }
}
