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
        }
    }
}
