/*
 * Matthew Foley
 * CST-150
 * Dog Name Activity
 * 3/10/25
 * Citation Here
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_DogClass.BuisnessLayer
{
    internal class Utility
    {
        /// <summary>
        /// Utility that returns false if parameter string is null or empty
        /// </summary>
        /// <param name="textToTest"></param>
        /// <returns></returns>
        public bool NotNull(string textToTest)
        {
            //Check if the string is empty, null or contains only whitespace
            if (String.IsNullOrWhiteSpace(textToTest))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Test to determine if a valid double was entered.
        /// If true the string is parsed to double and true will be returned
        /// if false, -1 is returned and false for bool.
        /// This return type is called a tuple
        /// </summary>
        /// <param name="valueToTest"></param>
        /// <returns></returns>
        public (double doubleValue, bool isConverted) ValidDouble(string valueToTest)
        {
            //Declare and Initialze
            double convertValue = 0.00D;
            //Test to see if they string can be parsed to a double
            if(Double.TryParse(valueToTest, out convertValue))
            {
                return (convertValue, true);
            }
            return (-1D, false);
        }

        /// <summary>
        /// Convert Yes to bool true and No to bool false
        /// </summary>
        /// <param name="YesOrNo"></param>
        /// <returns></returns>
        public bool ConvertToBool(string YesOrNo)
        {
            if (YesOrNo == "Yes")
            {
                return true;
            }
            return false;
        }
    }
}
