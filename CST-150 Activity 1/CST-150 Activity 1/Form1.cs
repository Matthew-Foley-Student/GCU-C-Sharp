/*
 * Matthew Foley
 * CST-150
 * Activity 1
 * 2/11/25
 * citations here
 */
namespace CST_150_Activity_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //hide the weight on mars label
            lblMars.Visible = false;
            lblMarsWeight.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConvertButtonClickEvent(object sender, EventArgs e)
        {
            //Declare and Initialize
            decimal earthWeight = 0.0M;
            decimal finalValue = 0.0M;
            decimal graveAccEarth = 9.81M;
            decimal graveAccMars = 3.711M;

            // Read in the earth weight
            earthWeight = Convert.ToDecimal(txtEarthWeight.Text);

            //calculate the final value
            finalValue = (earthWeight / graveAccEarth) * graveAccMars;

            //Use string.format to format the string and show only 2 decimal places.
            //This is a string argument
            lblMarsWeight.Text = string.Format("{0:.##} lbs", finalValue);

            //Display the results
            lblMarsWeight.Text = finalValue.ToString();

            //Make sure to show the mars value and label
            lblMars.Visible = true;
            lblMarsWeight.Visible = true;

            //Display the results
            //Use string.format to format the string and show only 2 decimal places.
            //this is a string arguemnt
            lblMarsWeight.Text = string.Format("{0:.##}", finalValue);

        }
    }
}
