# GPS Waypoint & Route Manager
**Algorithms and Data Structures Assessment**

## Project Overview
This application is designed to manage a large collection of GPS waypoints and organize them into followable routes. It demonstrates the practical application of core data structures:
*   **Arrays**: Used for high-speed access and storage of the master waypoint dataset (~2,500 locations).
*   **Custom Linked Lists**: A manual implementation of a singly linked list used to create dynamic, editable routes.

## Features
- **Bulk Data Loading**: Automatically parses `UK_waypoints.csv` on startup.
- **Waypoint Management**: Search for specific waypoints by name or unique code.
- **Route Creation**: Create multiple named routes (e.g., "North Peak Hike").
- **Dynamic Editing**: Add, remove, and insert waypoints into routes using a custom Linked List.
- **Unit Conversion**: Automatically converts elevation data from feet to meters.

## Technical Implementation
- **Waypoint Class**: Stores name, code, coordinates, elevation (m), and descriptions.
- **WaypointsAll Class**: Manages a static array of waypoints with $O(1)$ lookup.
- **MyLinkedList Class**: A custom-built, node-based list implementation for managing the sequential nature of routes.
- **Menu-Driven Interface**: Console-based UI for intuitive navigation.

## Getting Started
### Prerequisites
- .NET 8.0 SDK or compatible version.

### Running the Application
1. Clone the repository to your local machine.
2. Navigate to the solution directory:
   ```bash
   cd starter_code/StarterCode_WayPoints
   ```
3. Run the application:
   ```bash
   dotnet run
   ```

## Student Information
- **Name:** Akerele David Damilola
- **ID:** 25908322
- **Course:** Algorithms and Data Structures

## License
This project is for academic assessment purposes only.
