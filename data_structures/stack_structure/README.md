# Stack data structure

![stack_ds1](https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Tallrik_-_Ystad-2018.jpg/220px-Tallrik_-_Ystad-2018.jpg)
![stack_ds2](https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/Lifo_stack.png/350px-Lifo_stack.png)

[read more in wikipedia](https://en.wikipedia.org/wiki/Stack_(abstract_data_type))

In computer science, a stack is an abstract data type that serves as a collection of elements, with two main principal operations:

- Push, which adds an element to the collection, and
- Pop, which removes the most recently added element that was not yet removed.

The order in which elements come off a stack gives rise to its alternative name, LIFO (last in, first out). Additionally, a peek operation may give access to the top without modifying the stack. The name "stack" for this type of structure comes from the analogy to a set of physical items stacked on top of each other. This structure makes it easy to take an item off the top of the stack, while getting to an item deeper in the stack may require taking off multiple other items first.

Considered as a linear data structure, or more abstractly a sequential collection, the push and pop operations occur only at one end of the structure, referred to as the top of the stack. This data structure makes it possible to implement a stack as a singly linked list and a pointer to the top element. A stack may be implemented to have a bounded capacity. If the stack is full and does not contain enough space to accept an entity to be pushed, the stack is then considered to be in an overflow state. The pop operation removes an item from the top of the stack.