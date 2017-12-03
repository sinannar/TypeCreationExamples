using System;

namespace TypeCreationExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    } 
}
/*
 
    In C#, you can have Value Types, Reference Types and Value types. Pointer types are rarely used.
     
    Enum is special kind of value type in C#

    There are two location in which a type can be stored in memory, the heap and the stack. The value of a reference type is stored on the heap and the adress to this value is stored on stack. 
    Althought a value type is normally stored on the stack, there are exceptions, but the this is general idea. For the exceptions, a class that contains a value type as one of its fields, a lambda expression that closes
    over a value type, or a value type that is boxed can be shown. Benefit of storing data on stack is that its faster, smaller and does not need the attention of garbage collector.

    All objects in C# inherit from System.Object. Value Types however, inherit from System.ValueType which inherits from System.Object and override default functions such as GetHashCode,
    Equals,, ToString etc to give them more meaningful implementation for a value type. In C# you can not directly inherit from Sysyem.ValueType, instead, you can use the struct keyword to create a new value type.

    Functions are used in C# for representing methods in general but in deep, Functions are not to modify a system so for read part of the system we can use functions. There is a lot of details comes from especially F#.
    In C# it is better and clear to call behaviour of classes is method
    Func<T> and Action are added to .Net and Func has always return type since it is read perpose.



*/