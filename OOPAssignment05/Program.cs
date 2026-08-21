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
            #region Question02
            //Q2 Shallow Copy vs Deep Copy
            /*a) What is a Shallow Copy?
                  ==>> We copy value types and with reference types we only copy the reference not the objects.
            */
            /*b) What is a Deep Copy?
                  ==>> we copy value types and with reference types we teke a new copy of the object itself
                       So there is no relationship between the old and the new.           
            */
            /*c) What happens to reference-type members when a Shallow Copy is created?
                  ==>> We take a copy of the reference only.
            */
            /*d) What happens to reference-type members when a Deep Copy is created?
             *    ==>> we teke a new copy of the object itself not the reference.
            */
            /*e) Give one situation where Deep Copy would be safer than Shallow Copy.
                    If I have anything (Car version) and I want to make some modifications
                    but I don't want the modifications to affect the original version.
            */
            #endregion
            #region Question03
            //Q3 Static Members
            /*a) What is a static field, and how is it different from an instance field ?
                  Static field ==>> The value is shared/belongs to the same class,not to each individual object.
                  Instance field=>> Each object has its own instance of it.
            */
            /*b) What is a static method? Can a static method directly access instance members?
                  ==>> A static method belongs to the class itself and cannot directly access instance members.
            */
            /*c) What is a static constructor, and when is it executed ?
                  ==>> It is a constructor used to initialize static members, such as static fields.
                       It is executed at the first instance of the class.
            */
            /*d) What is a static class? Can you create an object from a static class?
                  ==>> It's a class whose members must be static.
                       You can't make an object out of it.
            */
            #endregion
        }
    }
}
