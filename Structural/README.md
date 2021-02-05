Structural Design Patterns
==========================
In plain words
> Structural patterns are mostly concerned with object composition or in other words how the entities can use each other. Or yet another explanation would be, they help in answering "How to build a software component?"

Wikipedia says
> In software engineering, structural design patterns are design patterns that ease the design by identifying a simple way to realize relationships between entities.

 * [Adapter](#-adapter)
 * [Bridge](#-bridge)
 * [Composite](#-composite)
 * [Decorator](#-decorator)
 * [Facade](#-facade)
 * [Flyweight](#-flyweight)
 * [Proxy](#-proxy)

🔌 Adapter
-------
### Problem
An "off the shelf" component offers compelling functionality that you would like to reuse, but its "view of the world" is not compatible with the philosophy and architecture of the system currently being developed.

### Intent
* Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
* Wrap an existing class with a new interface.
* Impedance match an old component to a new system

### Discussion

Reuse has always been painful and elusive. One reason has been the tribulation of designing something new, while reusing something old. There is always something not quite right between the old and the new. It may be physical dimensions or misalignment. It may be timing or synchronization. It may be unfortunate assumptions or competing standards.

It is like the problem of inserting a new three-prong electrical plug in an old two-prong wall outlet – some kind of adapter or intermediary is necessary.

Adapter is about creating an intermediary abstraction that translates, or maps, the old component to the new system. Clients call methods on the Adapter object which redirects them into calls to the legacy component. This strategy can be implemented either with inheritance or with aggregation.

Adapter functions as a wrapper or modifier of an existing class. It provides a different or translated view of that class.

### Check list
1. Identify the players: the component(s) that want to be accommodated (i.e. the client), and the component that needs to adapt (i.e. the adaptee).
1. Identify the interface that the client requires.
1. Design a "wrapper" class that can "impedance match" the adaptee to the client.
1. The adapter/wrapper class "has a" instance of the adaptee class.
1. The adapter/wrapper class "maps" the client interface to the adaptee interface.
1. The client uses (is coupled to) the new interface

🚡 Bridge
------
### Problem
"Hardening of the software arteries" has occurred by using subclassing of an abstract base class to provide alternative implementations. This locks in compile-time binding between interface and implementation. The abstraction and implementation cannot be independently extended or composed.

### Intent
* Decouple an abstraction from its implementation so that the two can vary independently.
* Publish interface in an inheritance hierarchy, and bury implementation in its own inheritance hierarchy.
* Beyond encapsulation, to insulation

### Discussion

Decompose the component's interface and implementation into orthogonal class hierarchies. The interface class contains a pointer to the abstract implementation class. This pointer is initialized with an instance of a concrete implementation class, but all subsequent interaction from the interface class to the implementation class is limited to the abstraction maintained in the implementation base class. The client interacts with the interface class, and it in turn "delegates" all requests to the implementation class.

The interface object is the "handle" known and used by the client; while the implementation object, or "body", is safely encapsulated to ensure that it may continue to evolve, or be entirely replaced (or shared at run-time.

Use the Bridge pattern when:
* you want run-time binding of the implementation,
* you have a proliferation of classes resulting from a coupled interface and numerous implementations,
* you want to share an implementation among multiple objects,
* you need to map orthogonal class hierarchies.

Consequences include:
* decoupling the object's interface,
* improved extensibility (you can extend (i.e. subclass) the abstraction and implementation hierarchies independently),
* hiding details from clients.

Bridge is a synonym for the "handle/body" idiom. This is a design mechanism that encapsulates an implementation class inside of an interface class. The former is the body, and the latter is the handle. The handle is viewed by the user as the actual class, but the work is done in the body. "The handle/body class idiom may be used to decompose a complex abstraction into smaller, more manageable classes. The idiom may reflect the sharing of a single resource by multiple classes that control access to it (e.g. reference counting)."

### Check list
1. Decide if two orthogonal dimensions exist in the domain. These independent concepts could be: abstraction/platform, or domain/infrastructure, or front-end/back-end, or interface/implementation.
1. Design the separation of concerns: what does the client want, and what do the platforms provide.
1. Design a platform-oriented interface that is minimal, necessary, and sufficient. Its goal is to decouple the abstraction from the platform.
1. Define a derived class of that interface for each platform.
1. Create the abstraction base class that "has a" platform object and delegates the platform-oriented functionality to it.
1. Define specializations of the abstraction class if desired.

🌿 Composite
-----------------

### Problem
Application needs to manipulate a hierarchical collection of "primitive" and "composite" objects. Processing of a primitive object is handled one way, and processing of a composite object is handled differently. Having to query the "type" of each object before attempting to process it is not desirable.

### Intent
* Compose objects into tree structures to represent whole-part hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.
* Recursive composition
* "Directories contain entries, each of which could be a directory."
* 1-to-many "has a" up the "is a" hierarchy

### Discussion
Define an abstract base class (Component) that specifies the behavior that needs to be exercised uniformly across all primitive and composite objects. Subclass the Primitive and Composite classes off of the Component class. Each Composite object "couples" itself only to the abstract type Component as it manages its "children".

Use this pattern whenever you have "composites that contain components, each of which could be a composite".

Child management methods [e.g. addChild(), removeChild()] should normally be defined in the Composite class. Unfortunately, the desire to treat Primitives and Composites uniformly requires that these methods be moved to the abstract Component class. See the "Opinions" section below for a discussion of "safety" versus "transparency" issues.

### Check list
1. Ensure that your problem is about representing "whole-part" hierarchical relationships.
1. Consider the heuristic, "Containers that contain containees, each of which could be a container." For example, "Assemblies that contain components, each of which could be an assembly." Divide your domain concepts into container classes, and containee classes.
1. Create a "lowest common denominator" interface that makes your containers and containees interchangeable. It should specify the behavior that needs to be exercised uniformly across all containee and container objects.
1. All container and containee classes declare an "is a" relationship to the interface.
1. All container classes declare a one-to-many "has a" relationship to the interface.
1. Container classes leverage polymorphism to delegate to their containee objects.
1. Child management methods [e.g. addChild(), removeChild()] should normally be defined in the Composite class. Unfortunately, the desire to treat Leaf and Composite objects uniformly may require that these methods be promoted to the abstract Component class. See the Gang of Four for a discussion of these "safety" versus "transparency" trade-offs.


☕ Decorator
-------------

### Problem
You want to add behavior or state to individual objects at run-time. Inheritance is not feasible because it is static and applies to an entire class.

### Intent
* Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
* Client-specified embellishment of a core object by recursively wrapping it.
* Wrapping a gift, putting it in a box, and wrapping the box.

### Discussion

Suppose you are working on a user interface toolkit and you wish to support adding borders and scroll bars to windows. The Decorator pattern suggests giving the client the ability to specify whatever combination of "features" is desired.

The solution to this class of problems involves encapsulating the original object inside an abstract wrapper interface. Both the decorator objects and the core object inherit from this abstract interface. The interface uses recursive composition to allow an unlimited number of decorator "layers" to be added to each core object.

Note that this pattern allows responsibilities to be added to an object, not methods to an object's interface. The interface presented to the client must remain constant as successive layers are specified.

Also note that the core object's identity has now been "hidden" inside of a decorator object. Trying to access the core object directly is now a problem.

### Check list
1. Ensure the context is: a single core (or non-optional) component, several optional embellishments or wrappers, and an interface that is common to all.
1. Create a "Lowest Common Denominator" interface that makes all classes interchangeable.
1. Create a second level base class (Decorator) to support the optional wrapper classes.
1. The Core class and Decorator class inherit from the LCD interface.
1. The Decorator class declares a composition relationship to the LCD interface, and this data member is initialized in its constructor.
1. The Decorator class delegates to the LCD object.
1. Define a Decorator derived class for each optional embellishment.
1. Decorator derived classes implement their wrapper functionality - and - delegate to the Decorator base class.
1. The client configures the type and ordering of Core and Decorator objects.

📦 Facade
----------------

### Problem
A segment of the client community needs a simplified interface to the overall functionality of a complex subsystem.

### Intent
* Provide a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.
* Wrap a complicated subsystem with a simpler interface.

### Discussion

Facade discusses encapsulating a complex subsystem within a single interface object. This reduces the learning curve necessary to successfully leverage the subsystem. It also promotes decoupling the subsystem from its potentially many clients. On the other hand, if the Facade is the only access point for the subsystem, it will limit the features and flexibility that "power users" may need.

**The Facade object should be a fairly simple advocate or facilitator. It should not become an all-knowing oracle or "god" object.**

### Check list
1. Identify a simpler, unified interface for the subsystem or component.
1. Design a 'wrapper' class that encapsulates the subsystem.
1. The facade/wrapper captures the complexity and collaborations of the component, and delegates to the appropriate methods.
1. The client uses (is coupled to) the Facade only.
1. Consider whether additional Facades would add value.

🍃 Flyweight
---------

### Problem
Designing objects down to the lowest levels of system "granularity" provides optimal flexibility, but can be unacceptably expensive in terms of performance and memory usage.

### Intent
* Use sharing to support large numbers of fine-grained objects efficiently.
* The Motif GUI strategy of replacing heavy-weight widgets with light-weight gadgets.

### Discussion
The Flyweight pattern describes how to share objects to allow their use at fine granularity without prohibitive cost. Each "flyweight" object is divided into two pieces: the state-dependent (extrinsic) part, and the state-independent (intrinsic) part. Intrinsic state is stored (shared) in the Flyweight object. Extrinsic state is stored or computed by client objects, and passed to the Flyweight when its operations are invoked.

An illustration of this approach would be Motif widgets that have been re-engineered as light-weight gadgets. Whereas widgets are "intelligent" enough to stand on their own; gadgets exist in a dependent relationship with their parent layout manager widget. Each layout manager provides context-dependent event handling, real estate management, and resource services to its flyweight gadgets, and each gadget is only responsible for context-independent state and behavior.

### Check list
1. Ensure that object overhead is an issue needing attention, and, the client of the class is able and willing to absorb responsibility realignment.
1. Divide the target class's state into: shareable (intrinsic) state, and non-shareable (extrinsic) state.
1. Remove the non-shareable state from the class attributes, and add it the calling argument list of affected methods.
1. Create a Factory that can cache and reuse existing class instances.
1. The client must use the Factory instead of the new operator to request objects.
1. The client (or a third party) must look-up or compute the non-shareable state, and supply that state to class methods.

🎱 Proxy
-------------------
### Problem
You need to support resource-hungry objects, and you do not want to instantiate such objects unless and until they are actually requested by the client.

### Intent
* Provide a surrogate or placeholder for another object to control access to it.
* Use an extra level of indirection to support distributed, controlled, or intelligent access.
* Add a wrapper and delegation to protect the real component from undue complexity.

### Discussion

Design a surrogate, or proxy, object that: instantiates the real object the first time the client makes a request of the proxy, remembers the identity of this real object, and forwards the instigating request to this real object. Then all subsequent requests are simply forwarded directly to the encapsulated real object.

There are four common situations in which the Proxy pattern is applicable.
1. A virtual proxy is a placeholder for "expensive to create" objects. The real object is only created when a client first requests/accesses the object.
1. A remote proxy provides a local representative for an object that resides in a different address space. This is what the "stub" code in RPC and CORBA provides.
1. A protective proxy controls access to a sensitive master object. The "surrogate" object checks that the caller has the access permissions required prior to forwarding the request.
1. A smart proxy interposes additional actions when an object is accessed. Typical uses include:
    * Counting the number of references to the real object so that it can be freed automatically when there are no more references (aka smart pointer),
    * Loading a persistent object into memory when it's first referenced,
    * Checking that the real object is locked before it is accessed to ensure that no other object can change it.

### Check list
1. Identify the leverage or "aspect" that is best implemented as a wrapper or surrogate.
1. Define an interface that will make the proxy and the original component interchangeable.
1. Consider defining a Factory that can encapsulate the decision of whether a proxy or original object is desirable.
1. The wrapper class holds a pointer to the real class and implements the interface.
1. The pointer may be initialized at construction, or on first use.
1. Each wrapper method contributes its leverage, and delegates to the wrappee object.
