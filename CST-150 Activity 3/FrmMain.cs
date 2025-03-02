/*
 *Matthew Foley
 *CST-150
 *Read Text Files
 *2/24/25
 *Citations Here
 */

namespace CST_150_Activity_3
{
    public partial class Form1 : Form
    {
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
        }

        /// <summary>
        /// Click Event Handler to Read the File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReadFileClickEvent(object sender, EventArgs e)
        {
            string txtFile = "";
            string dirLocation = "";
            const int PadSpace = 20;
            string header1 = "Type", header2 = "Color", header3 = "Quantity";
            string headerLine1 = "-----", headerLine2 = "-----", headerLine3 = "-----";
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

                string[] lines = File.ReadAllLines(txtFile);

                //Populate a label with the array
                //make sure the lavel is cleared out before we start
                lblResults.Text = "";
                //Add in header
                lblResults.Text = string.Format("{0}{1}{2}\n", header1.PadRight(PadSpace), header2.PadRight(PadSpace), header3.PadRight(PadSpace));
                lblResults.Text += string.Format("{0}{1}{2}\n", headerLine1.PadRight(PadSpace), headerLine2.PadRight(PadSpace), headerLine3.PadRight(PadSpace));
                foreach(string line in lines)
                {
                    ///split each line into an array of elements
                    string[] inventoryList = line.Split(", ");
                    //Iterate through each element in the array
                    //using a for loop instead of fareach loop
                    for(int i = 0; i < inventoryList.Length; i++)
                    {
                        //Display each element using proper spacing
                        lblResults.Text += inventoryList[i].PadRight(PadSpace);
                    }
                    lblResults.Text += "\n";
                    //make the label visible
                   
                } 
                lblResults.Visible = true;
            }
        }
    }
}
