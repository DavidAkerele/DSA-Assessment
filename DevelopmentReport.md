# Development Report - GPS Waypoints & Routes

**Student Name:** Akerele David Damilola  
**Student ID:** 25908322  
**Subject:** Algorithms and Data Structures

---

## 1. Introduction
The objective of this project is to develop a C# application that can read a large set of GPS waypoints from a CSV file and allow the user to create, edit, and display various routes. The core requirement is the efficient management of a large dataset using an **Array** for static storage and a **Linked List** for dynamic route construction.

## 2. Design

### 2.1 Class Diagram
The system is built using an object-oriented approach with the following classes:

- **Waypoint**: Stores individual waypoint data.
- **Node**: A container for the Linked List.
- **MyLinkedList**: A manual implementation of a Singly Linked List.
- **WaypointsAll**: Manages an array of all available waypoints.
- **Route**: Manages a specific sequence of waypoints for a route.

### 2.2 Data Structure Choices
- **Array (`Waypoint[]`)**: Used for the master list of 2,500+ waypoints. Provides $O(1)$ access and memory efficiency for static data.
- **Custom Linked List**: Used for routes to allow $O(1)$ insertions and deletions (once the node is found), which is ideal for dynamic route editing.

## 3. Implementation Details

### 3.1 Waypoint Parsing
The `WaypointsAll` class handles reading the CSV. It handles inconsistent elevation units (Feet/Meters) and builds descriptions that may contain embedded commas.

### 3.2 Custom Linked List
Implemented manually without built-in libraries. It features:
- **Add**: Appends to the end.
- **Remove**: Removes by name.
- **Insert**: Sequence-based insertion.

### 3.3 User Interface
A menu-driven console interface for:
- Browsing/Searching waypoints.
- Managing multiple named routes.

## 4. Verification and Testing

### 4.1 Test Cases
- **File Loading**: Verified ~2578 waypoints loaded correctly.
- **Search**: Verified search by Name and Code (e.g., "ABB").
- **Linked List Ops**: Verified Adding, Removing, and Inserting waypoints into routes.
- **Multiple Routes**: Verified switching between different active routes.

### 4.2 Fixes
Fixed the elevation conversion bug in the starter code (replaced Pi with 0.3048).

## 5. Conclusion
The application provides a robust and efficient solution for GPS waypoint and route management, demonstrating proper application of Arrays and Linked Lists.

## 6. Version Control and Workflow
A systematic development approach was followed using Git for version control. The project progression is reflected in the commit history:
- **Initial Commit**: Project setup and raw data integration.
- **Data Modeling**: Implementation of the `Waypoint` class.
- **Structure Development**: Creation of the custom Linked List (`Node`, `MyLinkedList`).
- **Storage Implementation**: `WaypointsAll` for array-based management and CSV parsing.
- **UI & Logic Integration**: Final assembly of the `Route` class and the menu-driven interface.
- **Documentation & Review**: Final report and verification testing.
