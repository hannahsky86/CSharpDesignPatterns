
ChatGPT 4o 

Create a class hierarchy to represent different types of shapes. Each shape should have methods to calculate its area and perimeter. Your implementation should follow the principles of Object-Oriented Programming (OOP), such as inheritance, polymorphism, and encapsulation.

Requirements:
Create an abstract base class called Shape with:

An abstract method CalculateArea() that returns a double.
An abstract method CalculatePerimeter() that returns a double.
A virtual method GetDescription() that returns a string description of the shape.
Create the following derived classes:

Circle:
Property: Radius (double)

Rectangle:
Properties: Length (double), Width (double)

Triangle:
Properties: SideA (double), SideB (double), SideC (double)
Implement the methods in the derived classes to calculate the area and perimeter of each shape.

Create a ShapeManager class that:
Accepts a list of Shape objects.
Provides a method DisplayShapeDetails() that iterates through the list and prints the details (type, area, perimeter, and description) of each shape.