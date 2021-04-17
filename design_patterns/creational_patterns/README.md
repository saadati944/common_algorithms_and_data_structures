# Creational design patterns

[read more in wikipedia](https://en.wikipedia.org/wiki/Creational_pattern)

In software engineering, creational design patterns are design patterns that deal with object creation mechanisms, trying to create objects in a manner suitable to the situation. The basic form of object creation could result in design problems or in added complexity to the design. Creational design patterns solve this problem by somehow controlling this object creation.

Creational design patterns are composed of two dominant ideas. One is encapsulating knowledge about which concrete classes the system uses. Another is hiding how instances of these concrete classes are created and combined.

Creational design patterns are further categorized into object-creational patterns and Class-creational patterns, where Object-creational patterns deal with Object creation and Class-creational patterns deal with Class-instantiation. In greater details, Object-creational patterns defer part of its object creation to another object, while Class-creational patterns defer its object creation to subclasses.

Five well-known design patterns that are parts of creational patterns are :

1. **Abstract factory pattern**, which provides an interface for creating related or dependent objects without specifying the objects' concrete classes.
1. **Builder pattern**, which separates the construction of a complex object from its representation so that the same construction process can create different representations.
1. **Factory method** pattern, which allows a class to defer instantiation to subclasses.
1. **Prototype pattern**, which specifies the kind of object to create using a prototypical instance, and creates new objects by cloning this prototype.
1. **Singleton pattern**, which ensures that a class only has one instance, and provides a global point of access to it.