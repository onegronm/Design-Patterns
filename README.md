# Design Patterns

## Creational
- Simple Factory
- ### Factory Method
  - *Defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.*
  - Enable the extensible creation of variabilities such as commands, iterators, and visitors.
  - #### Benefits
    - Decouples the implementation of the product from its use.
    - Clients are more flexible since they don't need to specify the class name of the concrete class and the details of its creation.
    - Adding new variants does not affect existing client code.
  - #### Uses and drawbacks
    - When the class cannot anticipate the objects it must create.
    - When the class wants its subclasses to specify the objects it creates.
    - When there's a need to decouple object creation from its subsequent use. 
    - Construction of objects may require additional classes.
- Abstract Factory
- ### Builder
  - *Encapsulate the construction of a product and allow it to be constructed in steps. Separates construction of a complex object from its representation.*
  - #### Benefits
    - Isolates the code from construction and representation.
    - Fine control over construction process. Allows objects to be constructed in a multistep and varying process (as opposed to one-step factories).
    - Hides internal representation of the product from the client.
    - Product implementations can be swapped in and out because the client only sees an abstract interface.
  - #### Uses and drawbacks
    - When you need to follow a sequence of potentially complex steps to create an object.
    - Allow different implementations and internal interfaces of an object.
    - Goes nicely with interpreter pattern (compound).
    - May involve a lot of classes and class interdependencies.
    - Constructing objects requires more domain knowledge of the client than when using a Factory.

## Structural
- Decorator
- ### Composite
  - *Build structures of objects in the form of trees to represent part-whole hierarchies that contain both compositions of objects and individual objects as nodes. Using a composite structure, we can apply the same operations over both composites and individual objects, ignoring the differences between composites and individual objects.*
  - #### Benefits
    - Treat individual objects and multiple, recursively-composed objects uniformly regardless of complexity and behavior.
    - No distinction between individual and composed elements. 
    - New component subclasses work wherever existing ones do.
    - Classes only include fields and methods they need.
  - #### Uses and drawbacks 
    - Let clients treat individual objects and compositions as objects uniformly.
    - Perceived complexity. May need what seems a large number of classes and objects.
    - Bloated interfaces for composites and leaves. Leaf inherits methods it doesn't need.
- ### Bridge
  - *Decouple an abstraction from its implementation so that the two can vary independently. This means to create a bridge interface to separate out responsibilities into different abstract classes.*
  - Encapsulate variability behind a stable API that creates separate class hierarchies for an abstraction and its implementations. Client calls to the abstraction are forwarded to the corresponding implementor subclass.
  - #### Benefits
    - Decouples an implementation so that it is not bound permanently to an interface.
    - Abstraction and implementation can be extended independently.
    - Changes to concrete abstraction classes don't affect the client.
  - #### Uses and drawbacks 
    - Useful any time you need to vary an interface and an implementation in different ways.
    - Useful in graphics and windowing systems that need to run over multiple platforms.
    - When there's a need to change implementor hierarchies at design-time or runtime without breaking client code. 
    - Increases complexity.
	
## Behavioral
- Strategy
- Observer
- ### Command
  - *Encapsulate the request for a service as an object, thereby letting you parameterize other objects with different requests, queue or logs requests, and support undoable operations.*
  - Define objectified actions that enables users to perform command requests consistently and extensibly.
  - Provides a common API for user-request commands.
  - #### Benefits
    - Decouples an object making a request from the one that knows how to perform it.
    - Abstracts the executor of a service making the program more modular and flexible.
    - Can bundle state and behavior in one object or forward behavior to other objects.
    - Can extend behavior via subclassing.
    - Can pass a command object as a parameter.
    - Composition yields macro commands. Macro commands are a simple extension of Command that allow multiple commands to be invoked.
    - Supports arbitrary level undo-redo.
  - #### Uses and drawbacks
    - Implement logging, undo(), and transactional systems.
    - Drawing editors, Microsoft Office tools, GNU Emacs.
    - Might result in lots of trivial command subclasses.
    - Excessive memory may be needed to support undo/redo operations.
    - Avoiding error accumulation during undo/redo in numerical analysis applications.


