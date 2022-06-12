# Unity-Programming-Patterns

Before i get into design patterns there a couple of fundamental topics which are being used in various design patterns.  

## Interface
An Interface is kind of a contract. It has set of methods, properties and other members that a target class must implement.

### Advantages of an Interface
- 

# Patterns
## 1. Command Pattern
The command pattern is a command pattern which encapsulates all the information needed to perform an event or action. 

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
 
