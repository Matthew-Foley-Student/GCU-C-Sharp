/*
 * Matthew Foley
 * CST-150
 * Activity #1
 * 2/20/25
 * cictation
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Project_2
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            selectFileDialog.InitialDirectory = Application.StartupPath + @"Data";
            selectFileDialog.Title = "Browse txt Files";
            selectFileDialog.DefaultExt = "txt";
            selectFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            lblResults.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }

        private void lblResults_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string txtFile = "";
            string dirLocation = "";
            const int PadSpace = 20;
            txtFile = this.selectFileDialog.FileName;
            if (this.selectFileDialog.ShowDialog() == DialogResult.OK)
            {

                txtFile = this.selectFileDialog.FileName;
                dirLocation = this.selectFileDialog.FileName;
                string[] lines = File.ReadAllLines(txtFile);

                DisplayHeader();
                DisplayInventory();
            }
        }//Button Comand Ending

        private void DisplayHeader()
        {
            const int PadSpace = 20;
            string header1 = "Item", header2 = "Price", header3 = "Quantity", header4 = "Season", header5 = "Consumable";
            string headerLine1 = "-----", headerLine2 = "-----", headerLine3 = "-----", headerLine4 = "-----", headerline5 = "-----";
            lblResults.Text = string.Format("{0}{1}{2}{3}{4}\n", header1.PadRight(PadSpace), header2.PadRight(PadSpace), header3.PadRight(PadSpace), header4.PadRight(PadSpace), header5.PadRight(PadSpace));
            lblResults.Text += string.Format("{0}{1}{2}{3}{4}\n", headerLine1.PadRight(PadSpace), headerLine2.PadRight(PadSpace), headerLine3.PadRight(PadSpace), headerLine4.PadRight(PadSpace), headerline5.PadRight(PadSpace));

        }
        private void DisplayInventory()
        {
            const int PadSpace = 20;
                        string txtFile = "";
                        txtFile = this.selectFileDialog.FileName;
            string[] lines = File.ReadAllLines(txtFile);
            txtFile = this.selectFileDialog.FileName;

            lblResults.Text = "";
            foreach (string line in lines)
            {
                ///split each line into an array of elements
                string[] inventoryList = line.Split(", ");
                //Iterate through each element in the array
                //using a for loop instead of fareach loop
                for (int i = 0; i < inventoryList.Length; i++)
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
