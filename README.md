# Implicit Geometry Visualization

## Overview
This project is a .NET 9.0 console application that visualizes implicit geometries such as circles, rings, and more complex shapes by numerically evaluating grid points. The project uses object-oriented programming principles to represent geometries, enabling operations like unions, intersections, and differences for advanced modeling.

---

## Features
- Models geometric shapes using implicit definitions.
- Renders shapes as ASCII art in the console using a grid-based approach.
- Supports fine-grain visualization with adjustable resolution.
- Implements an extendable hierarchy for shapes, allowing custom geometry definitions.

---

## Technologies Used
- **Framework**: .NET 9.0
- **Language**: C#
- **Platform**: Console Application

---

## Task Description
The main task is to:
1. Implement a class hierarchy for implicit geometry as shown in the provided structure.
2. Use the `Visualize` method to create a grid-based numerical representation of the geometry.
3. Model complex shapes (e.g., rings, combinations of basic shapes) using set operations like union, intersection, and difference.
4. Render these geometries in the console using adjustable resolution for both coarse and fine grids.

---

## Class Hierarchy
1. **ImplicitGeometry** (Abstract Class):
   - Base class for all geometric shapes.
   - Defines the `IsInside` method to determine if a point lies inside the shape.
   - Contains the `Visualize` method for grid-based visualization.

2. **Circle** (Derived Class):
   - Represents a circle defined by its radius and center point.
   - Implements the `IsInside` method to check whether a point lies within the circle.

3. **Ring** (Derived Class):
   - Combines two circles to form a ring using set difference.
   - Implements `IsInside` by checking that a point is inside the outer circle but outside the inner circle.

4. **Union**, **Intersection**, and **Difference** (Derived Classes):
   - Perform set operations to combine or subtract geometries.

---

## How to Run
1. **Requirements**:
   - .NET 9.0 SDK installed on your system.

2. **Clone the Repository**:
   Run the following commands in your terminal:
   git clone <repository-url> cd ImplicitGeometryVisualization

3. **Build the Project**:
Run:
    dotnet build

4. **Run the Application**:
Run:
    dotnet run

---

## Example Usage
```csharp
var circle = new Circle(5, new Point(10, 10));
circle.Visualize(20, 20, 0.5);

Width: 20
Height: 20
Resolution: 0.5

Output (Console Visualization of a Circle):
    ooo     
 ooooooo    
ooooooooo   
 ooooooo    
    ooo     
```

## Customization
1. **Modify grid dimensions (width and height) for different visualization sizes.**
2. **Adjust step (resolution) for finer or coarser grids.**
3. **Extend the ImplicitGeometry class to add new shapes.**:

## Contributors
 Samin Eghbali
 



