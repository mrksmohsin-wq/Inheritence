# 👨‍👧‍👧Inheritance
*Inheritance* in C# is a fundamental principle of object-oriented programming (OOP) that allows a new class to inherit properties, fields, and methods from an existing class, promoting code reuse and establishing a hierarchical relationship.
- ### Base Class (Parent Class/Superclass):
The class whose features are inherited.
- ### Derived Class (Child Class/Subclass):
The new class that inherits the features of the base class.  
## Why use Inheritance?
- ✅ Reuse existing code
- ✅ Reduce duplication
- ✅ Improve readability
- ✅ Support polymorphism
## Types of Inhertence
C# directly supports certain types of inheritance with classes and uses interfaces to achieve others. 
#### 1-Single Inheritance:
A derived class inherits from only one base class. This is the only form of class inheritance directly supported by C#.
#### 2-Multilevel Inheritance:
A class is derived from a class which is itself derived from another class (e.g., Class C derives from B, which derives from A).
#### 3-Hierarchical Inheritance:
Multiple derived classes inherit from a single base class (e.g., both Dog and Cat derive from Animal).
#### 4-Multiple Inheritance:
C# does not support multiple inheritance of classes. However, this can be achieved by implementing multiple interfaces. 
### Real life Examples
- 1-Animal → Dog ![image alt](https://github.com/mrksmohsin-wq/Inheritence/blob/f49412db9426dacd6391af14b54a470c7f4abc2a/Example_1%20SS.png)
- 2-Person → Student  ![image alt](https://github.com/mrksmohsin-wq/Inheritence/blob/41d5a8dbf765c2382db722923161dc9747b0790a/Example_2%20SS.png)
- 3-Vehicle → Car  ![image alt](https://github.com/mrksmohsin-wq/Inheritence/blob/f809a3fe0fd4e470bfc225f288b86cb2c1f85728/Example_3%20SS.png)
