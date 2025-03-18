/*
 * Matthew Foley
 * CST-150
 * Project 
 * 3/17/25
 * cictation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2.BuisnessLayer
{
    internal class Utilities
    {
        public bool NotNull(string textToTest)
        {
            //Check if the string is empty, null or contains only whitespace
            if (String.IsNullOrWhiteSpace(textToTest))
            {
                return false;
            }
            return true;
        }

        public (double doubleValue, bool isConverted) ValidDouble(string valueToTest)
        {
            //Declare and Initialze
            double convertValue = 0.00D;
            //Test to see if they string can be parsed to a double
            if (Double.TryParse(valueToTest, out convertValue))
            {
                return (convertValue, true);
            }
            return (-1D, false);
        }

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
