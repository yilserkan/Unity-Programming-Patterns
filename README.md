# Unity-Programming-Patterns

Before i get into design patterns there a couple of fundamental topics which are being used in various design patterns.  

## Interface
An Interface is kind of a contract. It has set of methods, properties and other members that a target class must implement.

### Advantages of an Interface
- Loose coupling

### Disadvantages of an Interface
- If you extend the interface you need to modify all classes which implement it.

## Unit Testing
Unit testing is a testing method where the individual units of the code are being tested to validate if they are performing their actions correctly.

### Advantages of Unit Testing
- If you refactor the code the unit tests will make sure that everything still works
- The tests can be executed individuallly

### Disadvantages of Unit Testing
- It can't catch all errors.
- It takes time to create the unit tests.

# Patterns

1. [Command Pattern](#1-Command-Pattern)
2. [Observer Pattern](#2-Observer-Pattern)
3. [Scriptable Object](#3-Scriptable-Object)
4. [Singleton Pattern](#4-Singleton-Pattern)
5. [Object Pooling](#5-Object-Pooling)
6. [Humble Object](#6-Humble-Object)

## 1. Command Pattern
The command pattern is a pattern which encapsulates all the information needed to perform an event or action. 

### When to use
 - If you want to implement undo, redo or replay operations.
 - If you want to have all actions stored.

### Advantages
- You can implement redo or replay features as you have all information needed already stored.
- It is easy to implement new commands without changing the existing code.
- The class which invokes the command is decoupled from the class which knows the operation.

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
 - Create an abstract observer class which has an abstract method which will be called when it is notified.
 - Create a class wich will inherit from the abstract subject class.This class will call the notify function after it has been triggered.
 - Create classes which wil implement the observer method and override the abstract method of the observer class which is basically the logic of what is going to be executed after it has been notified.
 
 
 ### Better way
 There is a much simpler way to make use of the observer pattern within Unity which is by using events. There is a ready-made delegate event which is called Action. You can creat this event as static in a class and invoke it after it has been triggered. If there are any classes which are listening to this event they will be executed.
 
## 3. Scriptable Object
 Scriptable objects are data containers.
 
 ### Advantages of Scriptable Objects
- They live in the project level so any changes you make in play mode is going to be saved.
- Scene independent. Therefore it is a great way to use as a save system.
- They can save memory and performance.
- Reduces coupling 

### How to implement
You need to create a class which derives from Scriptable Object. In this class you can define the information which you want to store in it. This class wil act as a template from which you can create assets. 

## 4. Singleton Pattern
An object which makes use of the singleton pattern can be accessed from everywhere and they can only be instansiated once.

### Advantatages of the Singleton Pattern
- Easy to implement
- Can be accessed from everywhere

### Disadvanatges of the Singleton Pattern
- Encourages coupling
- Can make testing more difficult
- Can get out of hand

### How to implement
1. Create a private static instance variable.
2. Define a public getter method for that instance. This method will set the instance variable if it is null and return the private instance. If it is already set it will return the private instance variable.
3. If you want to make it persistent across scenes you need to call DontDestroyOnLoad on the awake method.

## 5. Object Pooling
The object pooling design pattern is a container which holds objects. These objects can be used by activating the disabled objects when needed and deactivating the activated ones after they have completed their task. This comes in handy when you need to instansiate a lot of objects 

### When to use
This pattern is used whena class needs to be initialized often.

### Advantages
- Performance and memory boost.

### Disadvantages
-If the max size is not defiend properly it can leed to unnecessary memory usage.

### How to implement
1. Craete an ObjectPool with the desired class.
2. Define the OnCreate, OnTakeFromPool, OnReturnedToPool functions.
3. **Get** objects from the pool when needed and **Release** them when they are not needed anymore.

## 6. Humble Object
Is a pattern where you seperate the logic from the framework code. The framework classes are becoming Humble by seperating all of the logical functions to another class so that is left with only the bare minimum required logic which doesn't need to be tested.

### When to use
- When an object is too difficult to test

### Advantages
- Easy testable structure

### How to implement
- Extract the logical functions of the framework to another clas s to another class.
- Create an interface of the framework.
- Create a mock version of the framework(If you don't use NSubstitute).
- Create a test class which tests the functionality with the mock version.
