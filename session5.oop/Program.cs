namespace session5.oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /* A)What happens when you assign one object variable to another object variable?
             * Assigning one object variable to another copies the memory address (reference) 
             * stored in the stack, not the actual object data located on the heap. Both variables now point to the same object in memory.
             * 
             * B)Does assigning one object to another create a new object? Explain
             * No, it does not create a new object. It simply creates a second reference to the existing object.
             * Any modifications made through one variable will instantly reflect in the other
             * 
             * C)What is the difference between copying an object and copying its reference?
             * Copying a Reference: Duplicates only the pointer. Both variables share the exact same instance in memory.
             * Copying an Object: Creates a brand-new instance on the heap with duplicated data (via Shallow or Deep copy), allowing each variable to be modified independently.
             */
            #endregion
            #region Q2
            /*A)What is a Shallow Copy?
             * A shallow copy creates a new object instance, but copies only the bitwise values
             * of the original object's fields. Value-type fields get duplicate values, while reference-type fields get duplicate reference addresses.
             * 
             * B)What is a Deep Copy?
             * A deep copy creates a completely independent clone of an object. It duplicates both the top-level object and recursively creates new 
             * copies of any nested objects or reference-type fields it contains.
             * 
             * C)What happens to reference-type members when a Shallow Copy is created?
             * The copy shares the exact same referenced instances as the original. Modifying a nested reference-type field in the copied object will
             * directly mutate the original object's data.
             * 
             * D)What happens to reference-type members when a Deep Copy is created?
             * New instances are allocated on the heap for each reference-type field, copying their underlying data. The copy and the original hold 
             * entirely distinct references, making them fully independent.
             * 
             * E)Give one situation where Deep Copy would be safer than Shallow Copy
             * When dealing with mutable shared data—such as a Customer object holding an
             * Address object or a ShoppingBasket containing a list of Items.
             * If you clone the basket to create a quote without a deep copy, 
             * modifying items in the quote would unintentionally corrupt the active shopping basket.
             */
            #endregion
            #region Q3
            /*A)What is a static field, and how is it different from an instance field?
             * A static field belongs to the class itself and is shared across all instances; only one copy exists in memory. An instance field belongs to a specific object created from the class,
             * meaning each instance maintains its own separate copy of that field's value.
             * 
             * B)What is a static method? Can a static method directly access instance members?
             * A static method is a function bound to the class rather than an individual object,
             * callable without creating an instance. It cannot directly access instance members (fields or methods) because it runs without a this reference; 
             * it can only access other static members unless given an explicit object reference.
             * 
             * C)What is a static constructor, and when is it executed?
             * A static constructor initializes static data or performs actions 
             * needed only once for a class. It executes automatically before the first instance is created or any static members are accessed.
             * It cannot be called directly and takes no access modifiers or parameters.
             * 
             * D)What is a static class? Can you create an object from a static class?
             * A static class is a class sealed by design that can contain only static members and cannot be inherited.
             * No, you cannot instantiate or create an object from a static class using the new keyword.
             */
            #endregion
            #region Q4
            /*A)Extension Method 
             *An extension method allows you to add new methods to an existing type
             *(class, struct, or interface) without modifying its original source code, creating a derived type, or recompiling it.
             * 
             *B)Required Keyword 
             * The this keyword must precede the first parameter, 
             * which specifies the type the method operates on.
             * 
             * C)Declaration Location
             * It must be declared inside a non-nested, non-generic static class.
             * 
             * D)Accessing Private Members
             * No. Extension methods are just static methods under the hood,
             * so they can only access public and internal members of the type they extend.
             * They cannot access private or protected members.
             */

            #endregion
            #region Q5
            /*A)Partial Class
             *A partial class allows the definition of a single class, struct, or interface to be split across multiple .cs files. When the application is compiled,
             *the C# compiler combines all partial definitions into one unified class.
             * 
             *B)Reasons for Splitting a Class
             *Source Control & Teamwork: Multiple developers can work on different parts of the same class simultaneously without merge conflicts.
             *Separation of Concerns: Keeps auto-generated code (like UI designers or database scaffolders) separate from custom handwritten business logic.
             *Maintainability: Prevents single source files from becoming overly large and difficult to navigate. 
             * 
             *C)Partial Method 
             *A partial method is a method declared in one partial class file (signature only)
             *with its implementation optionally defined in another partial class file. 
             *It enables code generators to provide hook points that developers can optionally implement.
             * 
             *D)Unimplemented Partial Method 
             * If a partial method has no implementation, the compiler completely removes its signature, 
             * call sites, and any evaluation of parameters at compile time. It leaves zero runtime overhead or performance penalty.
             */
            #endregion
            #region Practical
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Smart Delivery Management System");
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine();
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Creating Shipments...");
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine();
            //DeliveryAddress address = new DeliveryAddress("Cairo", "El-Tahrir St", 15);
            //StandardShipment standard = new StandardShipment("SH001", "Books Package", 3.0m, 40m, address);
            //Console.WriteLine("Standard Shipment Created");
            //ExpressShipment express = new ExpressShipment("SH002", "Urgent Documents", 2.0m, 60m, address, 20m);
            //Console.WriteLine("Express Shipment Created");
            //InternationalShipment international = new InternationalShipment("SH003", "Electronics", 8.0m, 100m, address, "UAE", 50m);
            //Console.WriteLine("International Shipment Created");
            //Console.WriteLine();
            //Console.WriteLine("Total Shipments Created : " + Shipment.GetTotalShipmentsCreated());
            //Console.WriteLine();
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Object Copying");
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine();
            //Shipment assignedShipment = standard; 
            //Console.WriteLine($"Original Shipment : {standard.TrackingCode}");
            //Console.WriteLine($"Assigned Shipment : {assignedShipment.TrackingCode}");
            //Console.WriteLine();
            //Console.WriteLine($"Same Object : {ReferenceEquals(standard, assignedShipment)}");
            //Console.WriteLine();
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Shallow Copy");
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine();
            //StandardShipment shallowOriginal = new StandardShipment("SH004", "Shallow Test", 2.0m, 30m, new DeliveryAddress("Cairo", "Street A", 10));
            //StandardShipment shallowCopied = (StandardShipment)shallowOriginal.ShallowCopy();
            //Console.WriteLine($"Original Shipment Address : {shallowOriginal.Destination.City}");
            //Console.WriteLine($"Copied Shipment Address   : {shallowCopied.Destination.City}");
            //Console.WriteLine();
            //Console.WriteLine("Changing copied shipment address...");
            //Console.WriteLine();
            //shallowCopied.Destination.City = "Giza";
            //Console.WriteLine($"Original Shipment Address : {shallowOriginal.Destination.City}");
            //Console.WriteLine($"Copied Shipment Address   : {shallowCopied.Destination.City}");
            //Console.WriteLine();
            //Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(shallowOriginal.Destination, shallowCopied.Destination)}");
            //Console.WriteLine();
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Deep Copy");
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine();
            //StandardShipment deepOriginal = new StandardShipment("SH005", "Deep Test", 2.0m, 30m, new DeliveryAddress("Cairo", "Street B", 20));
            //StandardShipment deepCopied = (StandardShipment)deepOriginal.DeepCopy();
            //Console.WriteLine($"Original Shipment Address : {deepOriginal.Destination.City}");
            //Console.WriteLine($"Copied Shipment Address   : {deepCopied.Destination.City}");
            //Console.WriteLine();
            //Console.WriteLine("Changing copied shipment address...");
            //Console.WriteLine();
            //deepCopied.Destination.City = "Giza";
            //Console.WriteLine($"Original Shipment Address : {deepOriginal.Destination.City}");
            //Console.WriteLine($"Copied Shipment Address   : {deepCopied.Destination.City}");
            //Console.WriteLine();
            //Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(deepOriginal.Destination, deepCopied.Destination)}");
            //Console.WriteLine();
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Extension Methods");
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine();
            //express.UpdateTrackingStatus("Out For Delivery");
            //international.UpdateTrackingStatus("Delivered");
            //Console.WriteLine(standard.GetSummary());
            //Console.WriteLine(express.GetSummary());
            //Console.WriteLine(international.GetSummary());
            //Console.WriteLine();
            //Console.WriteLine($"SH001 Is Delivered : {standard.IsDelivered()}");
            //Console.WriteLine($"SH003 Is Delivered : {international.IsDelivered()}");
            //Console.WriteLine();
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Tracking Status");
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine();
            //standard.UpdateTrackingStatus("Out For Delivery");
            //Console.WriteLine();
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Static Utilities");
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine();
            //DeliveryUtilities.PrintSystemTitle();
            //Console.WriteLine();
            //Console.WriteLine("Total Shipments Created : " + Shipment.GetTotalShipmentsCreated());
            //Console.WriteLine();
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Partial Method");
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine();
            //standard.UpdateTrackingStatus("Delivered");
            //Console.WriteLine();
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Assignment Completed");
            //DeliveryUtilities.PrintSeparator();
            #endregion
        }
    }
}
