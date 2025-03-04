/*
 *Matthew Foley
 *CST-150
 *Read Text Files
 *2/24/25
 *Citations Here
 */

namespace CST_150_Methods
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button click even handler to excute the methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExecuteMethods(object sender, EventArgs e)
        {
            //this will be considered our main method and our
            //goal is to keep this method clean (no logic only methods called) 
            //Declare and Initialize
            int num1 = 2, num2 = 3, num3 = 4;
            int randomSum = 0;
            int x = 0, y = 0;
            double double1 = 1.1D, double2 = 2.2D, double3 = 3.3D;
            double double4 = 4.4D, double5 = 5.5D;
            string firstString = "This test has the number 82";
            string secondString = "this sky was BLue today";
            double[] doubles = { 4.4D, 23.56D, 24.45D, 16.1D, 125.25D, 45.3D };

            //First Method
            SumInts(num1, num2);
            //Second Method
            DisplayResults("Method 2: Avg of 5 doubles is: " + AvgValue(double1, double2, double3, double4, double5), false);
            //Third Method
            randomSum = RandomInt();
            DisplayResults(string.Format("Method 3: Sum of Random ints: {0} ", randomSum.ToString()), false);
            //Fourth Method
            bool isDivisibleByTwo = DivByTwo(num1, num2, num3);
            DisplayResults("Method 4: Is sum of 3 Ints div by 2: " + isDivisibleByTwo, false);
            //Fifth Method
            FewestChars(firstString, secondString);
            //Sixth Method
            double maxdouble = LargestDouble(doubles);
            DisplayResults(string.Format("Method 6: Largest double: {0}", maxdouble.ToString()), false);
            //Seventh Method
            while( x < 10){
                y = RandomNumTen();
            DisplayResults(string.Format("Method 7: 10 Numbers Randomly: {0}", y.ToString()), false);
                x++;
            }
            //Eighth Method
            if (SameNum() == true)
            {
                DisplayResults("Method 8: two equal integers: the two Numbers are the same ", false);
            }
            else
            {
                DisplayResults("Method 8: two equal integers: the two Numbers are diffrent ", false);
            }
            //Nineth Method
            double product = ProductOfNumbers();
            DisplayResults(string.Format("Method 9: Product of two numbers: {0}", product.ToString()), false);
        }//End of the Button Command


        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        private void SumInts(int num1, int num2)
        {
            int sum = num1 + num2;
            DisplayResults("Method 1: the sum of " + num1 + " + " + num2 + " = " + sum, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="descText"></param>
        /// <param name="clearLabel"></param>
        private void DisplayResults(string descText, bool clearLabel)
        {
            if (clearLabel)
            {
                lblResults.Text = "";
            }
            // Display the results in the label
            lblResults.Text += string.Format("{0}\n", descText);
        }

        /// <summary>
        ///  Averidges 5 numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <param name="num4"></param>
        /// <param name="num5"></param>
        /// <returns></returns>
        private double AvgValue(double num1, double num2, double num3, double num4, double num5)
        {
            //Declare and Intialze
            const double avgDenominator = 5.0D;
            return ((num1 + num2 + num3 + num4 + num5) / avgDenominator);
        }

        /// <summary>
        /// Return Random Number
        /// </summary>
        /// <returns></returns>
        private int RandomInt()
        {
            //Declare and Initilze
            int num1 = 0, num2 = 0, sum = 0;
            //Get random numbers
            //C# provides a Random class to generate Random Numbers
            //Instatntiate rnadom nuumber generators create an object called rand
            //Syntax --> ClassName object/variable name = new ClassName();
            Random rand = new Random();
            //Within the Random class there are several methods that have access modifiers set to Public that we can use
            //Once of those methods is next (int min, int max) that returns random number >=1 and <101
            num1 = rand.Next(1, 101);
            num2 = rand.Next(1, 101);
            //Generate the sum and return it
            //Break this out to multiple lines so it is easier to understand
            sum = num1 + num2;
            return sum;
        }

        /// <summary>
        /// Return boolean true or false if the sum of the ints are divisible by 2
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns></returns>
        private bool DivByTwo(int num1, int num2, int num3)
        {
            //Find the sum
            int sum = num1 + num2 + num3;
            //is the sum divisible by 2
            if (sum % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Write a method that takes two strings and display the
        /// string that has the fewer letters with discriptive text
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        private void FewestChars(string string1, string string2)
        {
            //Delcare and Initialize
            int countChar1 = 0, countChar2 = 0, pointer = 0;

            //Iterate through the strings using AbandonedMutexException do while loop
            //exit loop when both strings have been fully iterated through
            do
            {
                try {
                    if (char.IsLetter(string1[pointer]))
                    {
                        //Now we know this index countains a letter and not a number
                        countChar1++;
                    }
                }catch(Exception e){ 
                //If were here then we know string 1 had no letters and so we 
                //want to do nothing
                }
                //string2 -> Try and test if the char being pointed to is a letter
                try
                {
                    //Test for letters
                    if(char.IsLetter(string2[pointer])){
                        //Now we know that it is a letter
                        countChar2++;
                    }
                }catch(Exception e)
                {
                    //If were here then we know there was no letter
                    //so we do nothing
                }
                //we now move to the next charicter
                pointer++;
            } while ((pointer < string1.Length) || (pointer < string2.Length));
            //Now that everything is counted we need to display the results
            if (countChar1 < countChar2)
            {
                DisplayResults("Method 5: string 1 has fewer letters than string 2", false);
            }else if( countChar2 < countChar1)
            {
                DisplayResults("Method 5: string 2 has fewer letters than string 1", false);
            }else
            {
                DisplayResults("Method 5: both Strings are equal in number of letters", false);
            }
        }

        /// <summary>
        /// Write a method that takes an array of doubles and returns the largest in the array
        /// </summary>
        /// <param name="arrDoubles"></param>
        /// <returns></returns>
        private double LargestDouble(double[] arrDoubles)
        {
            //Declare and Initialize
            int arrpointer = 0;
            double valueAtIndex = 0D;
            double biggestDouble = 0D;
            //iterate through array using while loop
            while (arrpointer < arrDoubles.Length)
            {
                //Read double from array
                valueAtIndex = arrDoubles[arrpointer];
                //Now lets teast the double aggainst biggest value
                //if its larger than the biggest value
                // we should replace it
                if(valueAtIndex > biggestDouble)
                {
                    biggestDouble = valueAtIndex;
                }
                arrpointer++;
            }
            //All done so return the biggest double
            return biggestDouble;
        }
    
        /// <summary>
        /// Creating a Random Number
        /// </summary>
        /// <returns></returns>
        private int RandomNumTen()
        {
            int num = 0;
            Random rand = new Random();
            num = rand.Next(1, 1000);
            return num;

        }

        /// <summary>
        /// Return true if nums are the same
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        private bool SameNum()
        {
            int ranNum1 = 0, ranNum2 = 0;
            Random rand = new Random();
            ranNum1 = rand.Next(1, 5);
            ranNum2 = rand.Next(1, 5);
            if (ranNum1 == ranNum2) {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Multiply 2 numbers Together
        /// </summary>
        /// <returns></returns>
        private double ProductOfNumbers()
        {
            int ranNum1 = 0, ranNum2 = 0, product = 0;
            Random rand = new Random();
            ranNum1 = rand.Next(1, 25);
            ranNum2 = rand.Next(1, 25);
            product = ranNum1 * ranNum2;
            return product;
        }
    }//This is the end of the programm
}
