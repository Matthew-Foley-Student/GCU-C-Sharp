/*
 * Matthew Foley
 * CST-150
 * 2/17/25
 * Citations Here
 */
namespace WinFormsApp1
{
    public partial class FrmSeconds : Form
    {
        public FrmSeconds()
        {
            InitializeComponent();
            //make sure the label is not visable
            lblResults.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Event Handler to Evaluate Seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageSecondsEventHandler(object sender, EventArgs e)
        {
            //Declare and Initialize
            int seconds = 0;
            //Working with Constants in C#
            const int SecondsInMinutes = 60;
            const int SecondsInHours = 3600;
            const int SecondsInDays = 86400;
            //Define flags
            lblResults.Visible = false;
            //Default the color to black
            lblResults.ForeColor = Color.Black;

            //Test to determine if inteder was entered correctly by user
            //if try to parse string to int is succedul continue else show message
            if(int.TryParse(txtUserEntery.Text, out seconds))
            {
                //this block of code is where all og out buisness logic will be placed
                //In future classes we will put this code (buisnes logic) in the buisnes layer
                //Practice with nested if statments
                if (seconds >= SecondsInMinutes)
                {
                    //if we are here we know the user has entered a value that we can at minimum
                    //display how many minutes are in the seconds entered
                    lblResults.Text = string.Format("There are {0:#,#} minutes in {1:#,#} seconds. \n", seconds / SecondsInMinutes, seconds);
                    lblResults.Visible = true;

                    //-------------------------------------------------------
                    //Now that we know there were minutes - test for hours
                    //using nested if statements
                    //Nested statements stops code from being excuted if there is 
                    //no need
                    //----------------------------------------------------------
                    if (seconds >= SecondsInHours)
                    {
                        //Display how many hours are in the second ented
                        lblResults.Text += string.Format("There are {0:#,#} hours in {1:#,#} second \n", seconds / SecondsInHours, seconds);
                        
                        //-----------------------------------------------
                        //Now that we know there were hour - we tet for days
                        //using more nested if statements
                        //--------------------------------------------
                        if(seconds >= SecondsInDays)
                        {
                            //display how many days are in the econds entered
                            lblResults.Text += string.Format("There are {0:#,#} days in {1:#,#} seconds \n", seconds / SecondsInDays, seconds);
                        }
                    }
                }
                else
                {
                    //if we are here we know the user did not enter a value that meets the minimum 
                    //requirments of at least 60
                    //Ask the user to enter a vlaid number
                    lblResults.Text = "The number can not be comuted, please enter a number larger than 59";
                    lblResults.ForeColor = Color.Red;
                    lblResults.Visible = true;
                }
            }
            else
            {
                //this is the code block that is to be excuted if the user did not put an int in
                lblResults.Text = "please enter an integer to continue...";
                lblResults.ForeColor = Color.Red;
                lblResults.Visible = true;
            }
        }
    }
}
