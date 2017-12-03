using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypeCreationExamples
{
    class MyClass
    {
        public string MyInstanceField { get; set; }

        public string Concatenate(string valueToAppend)
        {
            return MyInstanceField + valueToAppend;
        }
    }

    class UseMyClass
    {
        public void foo()
        {
            MyClass instance = new MyClass();
            instance.MyInstanceField = "Some New Value";
        }
    }

    /***************************************************************************************************************/

    class Card { }

    class Deck
    {
        private int _maximumNumberOfCards;
        public Deck(int maximumNumberOfCards) // constructor with an argument, in this case argument is an integer 
        {
            _maximumNumberOfCards = maximumNumberOfCards;
            Cards = new List<Card>();
        }

        public ICollection<Card> Cards { get; private set; }

        public Card this[int index] // we can override index so user can do assignment similar to => myList[0] = 1;
        {
            get { return Cards.ElementAt(index); }
        }

        List<int> myList = new List<int>() { 1, 3, 5 }; // init with some values        //myList[0] = 1; // this is way to set some values in on list, this spesific exmpl set the element at index 0 which is first in list in C#
        public static int MyStaticField = 42; // Static field is a field that is not depend on an instance of Class, that is accessable even without an instance created
        //MyClass.MyStaticField = 43; // better way to access static fields are using Class names directly.

    }
    /*
        private set will prevent people set the Cards collection so only class member function can set.
     */


    /***************************************************************************************************************/
    /*
        In this spesific eaxmple we are going to observe constructor chaining    
     */
    class ConstructorChaining
    {
        private int _p;

        public ConstructorChaining() : this(3) // this called parameterised constructor that implemented below
        {

        }

        public ConstructorChaining(int p)
        {
            this._p = p;
        }
    }

}
