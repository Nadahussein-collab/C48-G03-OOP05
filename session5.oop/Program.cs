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
        }
    }
}
