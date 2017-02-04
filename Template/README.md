# Template Pattern

### Definition
The Template Method Pattern defines the skeleton of an algorithm in a method, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm’s structure.

### Description
- Use when group of subclasses execute similar list of methods
- Template method will contain these 'similar' methods which sublasses will call.
- Client -> Group of Concrete class (which all implement an Abstract class)

### Example Usage
- 'Player' class is the abstract class that contains method called the Template Method
- 'Defender' & 'Midfielder' class are classes that execute a similar group of methods. Hence they implement the 'Player' abstract class
- Template Method here is the 'PlayRole' method
- Some methods are left to be overridden. For eg : Defend, Pass, Shoot
