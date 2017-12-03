using System;
using System.Collections.Generic;
using System.Text;

namespace TypeCreationExamples
{
    public class Customer { }
    public class Address { }
    public class Distance { }

    class ParameterExample
    {
        /*
            This method use customer to achieve address and it is coupled to customer instead of adress. So it is askind more data than it needs 
    `   */
        public Distance CalculateDistanceTo(Customer customer)
        {
            Distance result = new Distance();
            //SOME CALCULATIONS that use customer.address
            return result;
        }

        /*
            This method use directly address which it needs to calcualte distance so it is clearer and simpler design that improves maintainabilty.
    `   */
        public Distance CalculateDistanceTo(Address address)
        {
            Distance result = new Distance();
            //SOME CALCULATIONS that use address
            return result;
        }

        /***************************************************************************************************************/

        void MyMethod(int firstArgument, string secondArgument = "default Value", bool thirdArgument = false)
        {

        }

        /*
            In this method, we are calling MyMethod, pass the first argument in order,then for second we are saying default arg is ok, to pass third argument we are using named arg
            Named arg is quite good feature of C#
         */
        void CallingMyMethod()
        {
            MyMethod(1,thirdArgument:true);
        }
    }
}
