namespace G_NET106_OOP_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            #region Q1
            //Overloading, Overriding, and Binding
            // a)  What is the difference between Method Overloading and Method Overriding?

            // method overloading: is using the same function with it's name but changing in it's type
            // or parameters type or parameter arrangment or number of parameters
            // and it is a static polymorphism

            //method overriding : using a function inherited from the parent class in the derived class
            // by making the parent function virtual and using a override keyword in the new function
            // in the derived class then changing in fucntions's body in the derived class 
            // and method overriding is a dynamic polymorphism  

            //b)  What is the difference between Static Binding and Dynamic Binding?
            // static binding : is resolved in compile time a the compiler decide which function should be called
            // and it's depending on the reference parent type not the object type

            //dynamic binding : same as static but it's deciding which function should be called based on object type 
            //not the reference parent and the static is faster in excution (virtual , overriding )



            #endregion
            #endregion
            #region Q2
            //Sealed Classes and Methods
            //a)  What is the purpose of the sealed keyword when applied to a class?
            // this sealed class can't be inherited from other classes we use it to protect 
            // the implementation of the class

            // b)  What is the difference between a sealed class and a sealed method?
            //the sealed class as we mentioned in the previous Q and it's functions implicitly can't be overridden
            // the sealed method if it inherited from other class and u marked the method as sealed 
            // u can't override it   

            //c)  Can a sealed method be overridden? Why?
                // selaed methods can't be overriden because using sealed keyword explicitly prevents overriding 
                //on the method 


            #endregion
        }
    }
}
