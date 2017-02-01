# Adapter Pattern

### Definition
The Adapter Pattern converts the interface of a class into another interface the clients expect. Adapter lets classes work together that couldn’t otherwise because of incompatible interfaces.

### Description
Process of calls : Client -> Adapter -> Adaptee   
Client and adaptee are decoupled.   
Adapter composed of the adaptee.  

### Example Usage
Explanation of the example given:
- 'Program' class here knows only about 'Character' interface.   
- First it calls 'Player' class which implements 'Character' interface.   
- 'Manager' is a totally separate class with different methods that 'Program' class does not know of.   
- In order to call 'Manager', 'Program' calls 'ManagerAdapter' which implements 'Character'.   
- 'ManagerAdapter' class exercises composition, as it is composed of the 'Manager' class.
- 'ManagerAdapter' will take role of an adapter and translate requests from 'Program' to 'Manager' class.   


