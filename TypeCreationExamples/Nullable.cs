using System;
using System.Collections.Generic;
using System.Text;

namespace TypeCreationExamples
{
    /*
        
        Instead of creating a Nullable type for each possiuble value type, there is now only one implementation that uses a generic type parameter to make it more flexible.
        This way, generics can be used to promote code reuse



     */
    class Nullable<T> where T : struct
    {
        private bool hasValue;
        private T value;

        public Nullable(T value)
        {
            this.hasValue = true;
            this.value = value;
        }

        public bool HasValue { get { return this.hasValue; } }

        public T Value
        {
            get
            {
                if (this.HasValue)
                    throw new ArgumentException();
                return this.value;
            }
        }

        public T GetValueOrDefault()
        {
            return this.value;
        }
    }

    /*
        
        where T : struct => Thy type argument must be a value type , ony nullable is not allowed

        where T : class => The type argument must be a reference type: for example, a class, interface, delegate or array
        
        where T : new() => The type must have a public default constructor
        
        where T : <base class name> =>  The type argument must be or derive from the specified base class
        
        where T : <interface name> => The type argument must be or implement the specified interface. Multiple interface constrainst can be specified. The constraining interface can also be generic
        
        where T : U => Type argument supplied for T must be or derive from the argument Supplied for U

     */

    class MyClass<T> where T : class, new()
    {
        public MyClass()
        {
            MyProperty = new T();
        }

        public void MyGenericMethod<A>()
        {
            A defaulValue = default(A);            
        }

        T MyProperty { get; set; }
    }
}
