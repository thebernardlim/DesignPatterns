# Decorator Pattern

### Definition
The Decorator Pattern attaches additional responsibilities to an object dynamically. 
Decorators provide a flexible alternative to subclassing for extending functionality.

### Description
Follows the Open-Closed principle : Classes should be open for extension, but closed for modification.   
The Decorator Pattern provides an alternative to subclassing for extending behavior.   
The Decorator Pattern involves a set of decorator classes that are used to wrap concrete components.   
Inheritance is one form of extension, but not necessarily the best way to achieve flexibility in our designs. (As shown in the 'Before' folder)  
Composition and delegation can often be used to add new behaviors at runtime.

### Example Usage
In the sample project, under the 'Before' folder, lies a list of possible scenarios for a ticket category and add-ons.   
Here a subclass is created for each scenario. If there are a lot of possibilities, it will lead to a code mess.   
With the decorator, we ensure loose coupling, hence flexibility and cleaner code.