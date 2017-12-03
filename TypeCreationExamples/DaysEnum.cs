using System;
using System.Collections.Generic;
using System.Text;

namespace TypeCreationExamples
{
    enum Days : byte { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri }
}

namespace TypeCreationSecondWayExamples
{
    [Flags]
    enum Days
    {
        None = 0x0,
        Sun = 0x1,
        Mon = 0x2,
        Tue = 0x4,
        Wed = 0x8,
        Thu = 0x10,
        Fri = 0x20,
        Sat = 0x40,
    } 
}
