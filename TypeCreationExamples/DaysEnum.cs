using System;
using System.Collections.Generic;
using System.Text;

namespace TypeCreationExamples
{
    enum Days : byte { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri }
}

namespace TypeCreationSecondWayExamples
{
    /*
         Flag Attribute let us set multiple combination of values as an example
    */
    [Flags]
    enum Days
    {
        None = 0x0,
        Sunday = 0x1,
        Monday = 0x2,
        Tuesday = 0x4,
        Wednesday = 0x8,
        Thursday = 0x10,
        Friday = 0x20,
        Saturday = 0x40,
    }
    class FlagAttributeExample
    {
        Days readingDays = Days.Monday | Days.Saturday;
    }
}
