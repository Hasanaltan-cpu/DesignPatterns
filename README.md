# DesignPatterns
In this project, i will demonstrate DesignPatterns.How many way we have and why we need Dependency Injection.
In software engineering, a design pattern is a general repeatable solution to a commonly occurring problem in software design. A design pattern isn't a finished design that can be transformed directly into code. It is a description or template for how to solve a problem that can be used in many different situations.


# Uses of Design Patterns

Design patterns can speed up the development process by providing tested, proven development paradigms. Effective software design requires considering issues that may not become visible until later in the implementation. Reusing design patterns helps to prevent subtle issues that can cause major problems and improves code readability for coders and architects familiar with the patterns.

Often, people only understand how to apply certain software design techniques to certain problems. These techniques are difficult to apply to a broader range of problems. Design patterns provide general solutions, documented in a format that doesn't require specifics tied to a particular problem.

In addition, patterns allow developers to communicate using well-known, well understood names for software interactions. Common design patterns can be improved over time, making them more robust than ad-hoc designs.

## Creational design patterns
These design patterns are all about class instantiation. This pattern can be further divided into class-creation patterns and object-creational patterns. While class-creation patterns use inheritance effectively in the instantiation process, object-creation patterns use delegation effectively to get the job done.

1-Abstract Factory

Creates an instance of several families of classes


![Image](https://gblobscdn.gitbook.com/assets%2F-MOvkEq9XcvZ_Ts2jyIl%2F-MP42KF8pbP8fIkpl3XV%2F-MP42rw2jcmIcJDuSL2X%2FAbstract_Factory-preview.png?alt=media&token=752b3152-419e-4bfc-b021-12acc78d5cbb)

[2-Builder](https://github.com/Hasanaltan-cpu/DesignPatterns/tree/master/BuilderPattern)

Separates object construction from its representation

[3-Factory Method](https://github.com/Hasanaltan-cpu/DesignPatterns/tree/master/FactoryMethodPattern)

Creates an instance of several derived classes

[4-Object Pool](https://github.com/Hasanaltan-cpu/DesignPatterns/tree/master/ObjectPoolPattern)

Avoid expensive acquisition and release of resources by recycling objects that are no longer in use

[5-Prototype](https://github.com/Hasanaltan-cpu/DesignPatterns/tree/master/PrototypeDesignPattern)

A fully initialized instance to be copied or cloned

[6-Singleton](https://github.com/Hasanaltan-cpu/DesignPatterns/tree/master/SingletonPattern)

A class of which only a single instance can exist


## Structural design patterns
These design patterns are all about Class and Object composition. Structural class-creation patterns use inheritance to compose interfaces. Structural object-patterns define ways to compose objects to obtain new functionality.

![Image](https://gblobscdn.gitbook.com/assets%2F-MOvkEq9XcvZ_Ts2jyIl%2F-MP42KF8pbP8fIkpl3XV%2F-MP42rw8Xy3den1HbRnt%2Fsctrcal1.png?alt=media&token=b56a25ec-d0cf-4435-8b3c-86981269c354)

[1-Adapter](https://github.com/Hasanaltan-cpu/DesignPatterns/tree/master/AdapterDesignPattern)

Match interfaces of different classes

2-Bridge

Separates an object’s interface from its implementation

3-Composite

A tree structure of simple and composite objects

[4-Decorator](https://github.com/Hasanaltan-cpu/DesignPatterns/tree/master/DecoratorPattern)

Add responsibilities to objects dynamically

5-Facade

A single class that represents an entire subsystem

6-Flyweight

A fine-grained instance used for efficient sharing

7-Private Class Data

Restricts accessor/mutator access

8-Proxy

An object representing another object

## Behavioral design patterns

These design patterns are all about Class's objects communication. Behavioral patterns are those patterns that are most specifically concerned with communication between objects.

![img](https://gblobscdn.gitbook.com/assets%2F-MOvkEq9XcvZ_Ts2jyIl%2F-MP42KF8pbP8fIkpl3XV%2F-MP42rw7p_weCYpZV96j%2Fbehaviour1.png?alt=media&token=5720034f-4e69-406b-a484-72833720d9df)



[1-Chain of responsibility](https://github.com/Hasanaltan-cpu/DesignPatterns/tree/master/ChainOfResponsibilityPattern)

A way of passing a request between a chain of objects

2-Command

Encapsulate a command request as an object

3-Interpreter

A way to include language elements in a program

4-Iterator

Sequentially access the elements of a collection

5-Mediator
Defines simplified communication between classes

6-Memento

Capture and restore an object's internal state

7-Null Object

Designed to act as a default value of an object

[8-Observer](https://github.com/Hasanaltan-cpu/DesignPatterns/tree/master/ObserverPattern)

A way of notifying change to a number of classes

9-State

Alter an object's behavior when its state changes

[10-Strategy] (https://github.com/Hasanaltan-cpu/DesignPatterns-2/tree/master/WebApp.StrategyDP)

Encapsulates an algorithm inside a class

11-Template method

Defer the exact steps of an algorithm to a subclass

12-Visitor
Defines a new operation to a class without change

![img](https://gblobscdn.gitbook.com/assets%2F-MOvkEq9XcvZ_Ts2jyIl%2F-MP42KF8pbP8fIkpl3XV%2F-MP42rw9Tr-DpXnKVTw2%2Fbehaviour2.png?alt=media&token=6bba112d-e382-4142-b90f-769cf83c3490)

## Loosely Coupled
It means classes which is contained with the others should be loosely coupled.Furthermore,if developer wants to change anything in his codes,he can easly change thanks to loosely coupled if they were storngly coupled,he should write every properties of that class again,totally spending time ineffiecently.
Dependency Injection
That's why Dependency injection is used for application which may need some changing one day.Dependency injection can apply with 2 ways;

[Constructor Injection(Constructor Based Dependecy Injection)](https://github.com/Hasanaltan-cpu/DesignPatterns/tree/master/DesignPatterns/Entities/Concrete)

Setter Injection(Setter Based Dependency Injection)


Visit me! https://hsnaltan13.gitbook.io/design-patterns/
ref:(thanks To)sourcemaking.com/
