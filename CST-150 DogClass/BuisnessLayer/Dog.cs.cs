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
    internal class Dog
    {
        //Define the properties
        public string Name { get; set; }
        public double NeckRad { get; set; }
        public string Color {  get; set; } 
        public double Weight {  get; set; }
        public bool Sit {  get; set; }

        public Dog()
        {
            Name = "";
            NeckRad = 0.00D;
            Color = "";
            Weight = 0.00D;
            Sit = false;
        }

        public Dog(string name, double neckRad, string color, double weight, bool sit)
        {
            Name = name;
            NeckRad = neckRad;
            Color = color;
            Weight = weight;
            Sit = sit;
        }


        /// <summary>
        /// Method that takes the property NeckRad and return
        /// the circumfrence in centemeters
        /// </summary>
        /// <returns></returns>
        public double CalCircumference()
        {
            //Declare and Initialize
            const double cmConversion = 2.54D;
            double circumference = 0.00D;

            //Since NeckRad is at the class level we can use this
            //property inside this method
            //conversion from radius to circumcerence (2 Pi r)
            circumference = 2 * Math.PI * NeckRad;
            // then convert to centemeters from inches
            return (circumference * cmConversion);
        }

        public double CalWeight()
        {
            //Declare and Initilize
            const double kgConversion = 0.453592;
            //convert the properties from pounds to kilograms
            return (Weight * kgConversion);
        }
    }
}
