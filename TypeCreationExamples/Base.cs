using System;
using System.Collections.Generic;
using System.Text;

namespace TypeCreationExamples
{
    class Base
    {
        public virtual int MyMethod()//virtual keyword makes it overridable in subclasses
        {
            return 42;
        }
    }

    class Derived : Base
    {
        public override int MyMethod()//override let this method to overridable in derived class from base class, not a new method. dev should know that he is overriding this method
        {
            return base.MyMethod() * 2;
        }
    }

    /*
        you can use sealed keyword for classes that prevent the class to inheritade
     */
    public sealed class Base2 { }
    //public class Derived2 : Base2 { }// compiler will prevent you and give an error    


    /*
    
        class Base
        {
            public virtual int MyMethod()
            {
                return 42;
            }
        }
        class Derived : Base
        {
            public sealed override int MyMethod()
            {
                return base.MyMethod() * 2;
            }
        }
        class Derived2 : Derived
        {
            // This line would give a compile error
            // public override int MyMethod() { return 1;}
        }

    */
}
