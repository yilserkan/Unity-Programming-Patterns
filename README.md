# Unity-Programming-Patterns

Before i get into design patterns there a couple of fundamental topics which are being used in various design patterns.  

## Interface
An Interface is kind of a contract. It has set of methods, properties and other members that a target class must implement.

### Advantages of an Interface
- 

# Patterns

1. [Command Pattern](#1-Command-Pattern)
2. [Observer Pattern](#2-Observer-Pattern)

## 1. Command Pattern
The command pattern is a pattern which encapsulates all the information needed to perform an event or action. 

### When to use
 - If you want to implement undo, redo or replay operations.
 - If you want to have all actions stored.

### Advantages
- You can implement redo or replay features as you have all information needed already stored.
- It is easy to implement new commands without changing the existing code.
- The class which invkes the command is decoupled from the class which knows the operation.

### Disadvantages
- You have to allocate memory for every command.
- There may be a lot of classes since every will have his own class.

### How to implement
1.  Create a abstract class named Command and add all relative information.
2.  Create a new class which inherits from the command class and overrides the functions.
3.  Create another class which will have a list of commands.
4.  Add to this list the command which you want to execute.
5.  Execute the command.

## 2. Observer Pattern
 The observer pattern consists of subjects and observers. The **subject** is a gameobject which has a reference to all his observers. It is responsible to notify all of his observer on any state change. The **observers** are listeners which are waiting for any notifications from the subject to perform specific tasks.
 
 ### When to use
 - The observer pattern is used when there are multiple objects which need to be notified when an object has a change of state.
 
 ### Advantages
 - It has louse coupling between objects which are interacting with each other
 - Observer can be added or removed any time
 
 ### Disadvantages
 - If not correctly implemented it can add complexity and lead to performance drop.
 
 ### How to implement
 - Create an abstract subject class which has a list of observers and add methods to register observers, unregister observers and notify observers.
 - Create an abstract observer class which an an abstract method which will be called when it is notified.
 - Create a class wich will inherit from the abstract subject class.This class will call the notify function after it has been triggered.
 - Create classes which wil implement the observer method and override the abstract method of the observer class which is basically the logic of what is going to be executed after it has been notified.
 
 
 ### Better way
 There is a much simpler way to make use of the observer pattern within Unity which is by using events. Events are  
