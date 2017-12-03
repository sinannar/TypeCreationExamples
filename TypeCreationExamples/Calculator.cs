using System;
using System.Collections.Generic;
using System.Text;

namespace TypeCreationExamples
{
    class Calculator
    {
        public Calculator() // used ctor and double tab to create default constructor
        {

        }

        public int Add(int x,int y)
        {
            return x + y;
        }
    }
}

/*
 
    In Object Oriented, it is better to practice writing less and reusable code. Trying to avoid Procedural style is important since it is Object Oriented. Breaking large, complex method into their individual parts and naming those methods wisely is one of the step you can take to avoid procedural methods.
    Make sure your method name is focused on one thing. If your method name grows, it is better to splt it into multiple methods that each has its own spesific goal
    User relies on Intellisense so name of method, names of parameters are important.
 
 */