/*
 *Matthew Foley
 *CST-150
 *Read Text Files
 *2/24/25
 *Citations Here
 */

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CST_150_Activity_3
{
    public partial class Form1 : Form
    {
        string txtFile = "";
        string[] lines;
        public Form1()
        {
            InitializeComponent();
            //Set the properties for the selectFileDialog control
            //Define the initial directory that is shown
            selectFileDialog.InitialDirectory = Application.StartupPath + @"Data";
            //Set the title of open file dialog
            selectFileDialog.Title = "Browse Txt Files";
            //DefaultExt is only used when "All Files" is selected
            //from the filter box and no extension is specified
            //by the user
            selectFileDialog.DefaultExt = "txt";
            selectFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            //When the form is initialized make sure the lblReults
            //and lbl SelectedFile are not visable
            lblResults.Visible = false;
            lblSelectedFile.Visible = false;
            //Make the comboBox not Visable
            cmbSelectRow.Visible = false;
            lblSelectRow.Visible = false;
        }

        /// <summary>
        /// Click Event Handler to Read the File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReadFileClickEvent(object sender, EventArgs e)
        {
            string dirLocation = "";
            // use this int to dynamicly populate the comBox
            int numberRows = 1;
            if (this.selectFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Read in the text file that was selected
                txtFile = this.selectFileDialog.FileName;
                //Get the path of the file plus the filename
                dirLocation = this.selectFileDialog.FileName;
                //show the selcted file and path in the label
                lblSelectedFile.Text = txtFile;
                //Make sure to make this label visible
                lblSelectedFile.Visible = true;
                //Read all lines into a one dimensional string array

                lines = File.ReadAllLines(txtFile);
                lblResults.Text = "";
                DisplayInv();
                cmbSelectRow.Items.Clear();

                foreach (string line in lines)
                {
                    //Dynimcally Populate the comBox
                    cmbSelectRow.Items.Add(numberRows);
                    //inc to next row
                    numberRows++;
                   
                    //make the label visible
                    //Since the comboBox is populated turn visiblity to true
                    cmbSelectRow.Visible = true;
                    lblSelectRow.Visible = true;
                }
                lblResults.Visible = true;

            }
        }
        //------------------------------------------------
        //First Method
        //----------------------------------------

        ///<summary>
        ///Convert input string to all lower case charicters
        ///then send the results to be displayed
        /// </summary>
        /// <param name="textToConvert"></param>
        private void ConvertLowerCase(string textToConvert)
        {
            //Convert all text to lowercase useing the argument
            ResultsToLabel(textToConvert.ToLower());
        }
        ///<summary>
        ///Print results to label
        /// </summary>
        /// <param name="Results"></param>

        private void ResultsToLabel(string results)
        {
            //Declare and initialize Constant
            const int PadSpace = 20;
            //Display each element using proper spacing
            lblResults.Text += results.PadRight(PadSpace);
        }

        /// <summary>
        /// when the comboBox drop down closes trigger this method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectRowToInc(object sender, EventArgs e)
        {
            // Declare and initializ
            int rowSelected = -1;
            int qtyValue = -1;
                //Gt th slcted indx of th comboBox
                //-1 mans no valu was slctd
                rowSelected = cmbSelectRow.SelectedIndex;

            //Only inc a qty if a row was selected
            if (rowSelected >= 0)
            {
                //get the qty if a row was selected
                qtyValue = GetQty(lines, rowSelected);

                //Now w can inc th qty and stor it back to the file
                IncDisplayQty(lines, rowSelected, qtyValue, txtFile);
            }
        }
        /// <summary>
        /// Get the Qty value from selctd row
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="selectedRow"></param>
        /// <returns></returns>
        private int GetQty(string[] lines, int selectedRow)
        {
            //Declare and initialize
            int qty = -1; //This way we know if there was an error
            //iterate through the array until the selected row is found
            //since we know the exact number of times to iterate through the array
            //which loop is the best one to use?
            for (int x=1; x < lines.Length; x++)
            {
                //Now only pull out the row we need
                if (x == selectedRow)
                {
                    string[] invRow = lines[x].Split(",");
                    //Now Pull out th qty
                    //Use exception handling to parse string to int
                    try
                    {
                        //Convrt string representation of number to its
                        //singed integer
                        qty = int.Parse(invRow[2].Trim());
                        return qty;
                    }catch (FormatException e)
                    {
                        //show an exception messege
                        lblResults.Text = e.Message;
                    }
                }
            }
            //if there ar any excpetions return -1
            return qty;
        }
        /// <summary>
        /// Inc qty value, build the string for files, save to file
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="invRowToUpdate"></param>
        /// <param name="qty"></param>
        /// <param name="txtFile"></param>
        private void IncDisplayQty(string[] lines, int invRowToUpdate, int qty, string txtFile)
        {
            //Declare and initilze
            string updateLine = "";
            //First inc qty
            qty++;

            //now we need to update the qty in the array
            //first we need to split up the row so w can update the array
            string[] invRow = lines[invRowToUpdate].Split(",");
            //then we can update the element in the string array
            invRow[2] = qty.ToString();
            //We need to build the string to store in the lines array
            updateLine = invRow[0].Trim() + ", " + invRow[1].Trim() + ", " + invRow[2].Trim();
            //now update the lines array
            lines[invRowToUpdate] = updateLine;
            //now update the text files
            File.WriteAllLines(txtFile, lines);

        }
        private void DisplayHeader()
        {
            const int PadSpace = 20;
            string header1 = "Type", header2 = "Color", header3 = "Quantity";
            string headerLine1 = "-----", headerLine2 = "-----", headerLine3 = "-----";
            //Add in header
            lblResults.Text = string.Format("{0}{1}{2}\n", header1.PadRight(PadSpace), header2.PadRight(PadSpace), header3.PadRight(PadSpace));
            lblResults.Text += string.Format("{0}{1}{2}\n", headerLine1.PadRight(PadSpace), headerLine2.PadRight(PadSpace), headerLine3.PadRight(PadSpace));

        }
        private void DisplayInv() {

            //Populate a label with the array
            //make sure the lavel is cleared out before we start
            lblResults.Text = "";
            //Display Headers
            DisplayHeader();
            foreach (String line in lines)
            {
                ///split each line into an array of elements
                string[] inventoryList = line.Split(", ");
                //Iterate through each element in the array
                //using a for loop instead of fareach loop
                for (int i = 0; i < inventoryList.Length; i++)
                {
                    //Display each element using proper spacing
                    ResultsToLabel(inventoryList[i]);
                }
                lblResults.Text += "\n";
            }
        }

    }
}
