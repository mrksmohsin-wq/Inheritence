#Inhertence
Inheritance in C# is a fundamental principle of object-oriented programming (OOP) that allows a new class to inherit properties, fields, and methods from an existing class, promoting code reuse and establishing a hierarchical relationship.
##Base Class (Parent Class/Superclass):
The class whose features are inherited.
###Derived Class (Child Class/Subclass):
The new class that inherits the features of the base class.  
####Types of Inhertence
C# directly supports certain types of inheritance with classes and uses interfaces to achieve others. 
Single Inheritance: A derived class inherits from only one base class. This is the only form of class inheritance directly supported by C#.
Multilevel Inheritance: A class is derived from a class which is itself derived from another class (e.g., Class C derives from B, which derives from A).
Hierarchical Inheritance: Multiple derived classes inherit from a single base class (e.g., both Dog and Cat derive from Animal).
Multiple Inheritance: C# does not support multiple inheritance of classes. However, this can be achieved by implementing multiple interfaces. 
#####Rea life Examples
1-Bank Account Inheritance
2-Person → Student & Teacher
3-Vehicle → Car & Bike
