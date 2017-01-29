# Command Pattern

### Definition
The Command Pattern encapsulates a request as an object, thereby letting you parameterize other objects with different requests, queue or log requests, and support undoable operations.

### Description
Sometimes it is necessary to issue requests to objects without knowing anything about the operation being requested or the receiver of the request. 

![Command Pattern Diagram](https://github.com/thebernardlim/DesignPatterns/blob/master/Command/command.jpg)

**Image Source :** Design Patterns: Elements of Reusable Object-Oriented Software book   
**Amazon Link :** https://www.amazon.com/Design-Patterns-Elements-Reusable-Object-Oriented/dp/0201633612

### Example Usage
In the example listed:   
- Program : Client   
- Waiter : Invoker   
- Command : Command   
- Kitchen : Receiver   

Key points are:   
- Waiter here does not know the specifics of the kitchen, i.e. how food is prepared . Who / where within the kitchen etc.  
- The invoker should be aware only about the abstract command class. 
