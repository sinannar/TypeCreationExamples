using System;
using System.Collections.Generic;
using System.Text;

namespace TypeCreationExamples
{
    public struct Point
    {
        public int x, y;

        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

    }
}

/*

    Structs and classes can have methods, fields, properties, constructors and other functionalities. you can not, however, decalare your own empty constructor for Struct.
    Also structs can not be used in an inheritance hieararchy

*/