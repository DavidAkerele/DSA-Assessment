using System;

namespace StarterCode_WayPoints
{
    public class Waypoint
    {
        // Data members
        private string name;
        private string code;
        private string latitude;
        private string longitude;
        private int elevation;
        private string description;

        // Constructor
        public Waypoint(string name, string code, string latitude, string longitude, int elevation, string description)
        {
            this.name = name;
            this.code = code;
            this.latitude = latitude;
            this.longitude = longitude;
            this.elevation = elevation;
            this.description = description;
        }

        // Properties (Getters)
        public string Name => name;
        public string Code => code;
        public string Latitude => latitude;
        public string Longitude => longitude;
        public int Elevation => elevation;
        public string Description => description;

        // Display method
        public override string ToString()
        {
            return $"Waypoint: {name} ({code})\n" +
                   $"Position: [{latitude}, {longitude}]  Elevation: {elevation}m\n" +
                   $"Description: {description}";
        }
    }
}
