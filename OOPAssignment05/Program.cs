namespace OOPAssignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //Q1 Object Copying
            /*a) What happens when you assign one object variable to another object variable?
                   ==>> We take a copy of the reference only.
            */
            /*b) Does assigning one object to another create a new object? Explain.
                   ==>> No. Assigning one object  to another copies the reference, not the object itself
                        Both variables refer to the same object in memory.
            */
            /*c) What is the difference between copying an object and copying its reference ?
                 Copying the object    ==>> Creates a new object with its own data
                                            Changes to one object do not affect the other.

                 Copying the reference ==>> does not create a new object
                                            Both references refer to the same object
                                            so changes on one reference affect on the ather one
             */
            #endregion
        }
    }
}
