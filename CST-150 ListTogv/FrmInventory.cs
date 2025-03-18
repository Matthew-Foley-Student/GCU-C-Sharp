/*
 * Matthew Foley
 * CST-150
 * Activity 6 File Editing
 * 3/17/25
 * cictation
 */

using CST_150_ListTogv.Buisness_Layer;
using CST_150_ListTogv.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CST_150_ListTogv
{
    public partial class FrmInventory : Form
    {
        //Create the class level object
        //This is called an inventory refrence variable
        //This is our master inventory object that must
        //always contain the most up to date inventory
        List<InvItem> invItems = new List<InvItem>();

        //Properties of the grid
        private int SelectedGridIndex { get; set; }
        public FrmInventory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Populate the grid when this form is loaded
        /// Using this even handler to bind a datagrid
        /// control to the objects.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopulateGrid_EventHandler(object sender, System.EventArgs e)
        {
            //Instantiate the buisness class and get all the items from the inventory
            //from the text file
            Inventory readInv = new Inventory();
            invItems = readInv.ReadInventory(invItems);
            //after the list is up to date it must be populated
            //using the datasource to the datagrid
            gvInv.DataSource = null;
            gvInv.DataSource = invItems;

            //What if we do not like the names in the header of the GridView?
            //Lets iterate through a header for that
            //and change them to a more desired one's
            StreamWriter outputFile;
            outputFile = File.CreateText("Data\\topic6.txt");
            outputFile.WriteLine(gvInv.DataSource);
            outputFile.Close();
            foreach (DataGridViewColumn column in gvInv.Columns)
            {
                //switch statmets to change the text header
                //colimn.index starets and 0-endcount
                switch (column.Index)
                {
                    case 0:
                        column.HeaderText = "BunnyType";
                        break;
                    case 1:
                        column.HeaderText = "BunnyColor";
                        break;
                    case 2:
                        column.HeaderText = "Quantity";
                        break;
                    default:
                        //Show a message to indiacte something wasnt working
                        MessageBox.Show("Invalid Column was detected when data was accessed!");
                        break;
                }
            }
        }//Event Handler Ender

        private void Grid_View_ClickEvent(object sender, EventArgs e)
        {
            //Selected row
            SelectedGridIndex = gvInv.CurrentRow.Index;
            //Now we also know the index into the list to get all our information
        }

        /// <summary>
        /// Event Handler To Manage Button to increment quantity positivly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIncQty_ClickEvent(object sender, EventArgs e)
        {
            //Make sure the logic is not in the presentation layer so
            //inc quantuity in the inventory class
            //instantiate the inventory class so we can use it now
            Inventory incQty = new Inventory();
            invItems = incQty.IncQtyValue(invItems, SelectedGridIndex);
            //Since the list contains the master Inventory
            //refresh the data in the grid view
            //since we have already bound the list to the view
            gvInv.Refresh();

        }


        private void saveText()
        {

            string filepath = "Data\\topic6.txt";
            File.Delete("Data\\topic6.txt");
            for (int i=0; i < gvInv.Rows.Count -1; i++)
            {
                for (int j=0; j <gvInv.Columns.Count; j++)
                {
                    if (j < gvInv.Columns.Count -1)
                    {
                        File.AppendAllText(filepath, gvInv.Rows[i].Cells[j].Value.ToString() + ",");
                    }
                    else
                    {
                        File.AppendAllText(filepath, gvInv.Rows[i].Cells[j].Value.ToString()+ ",\n");
                    }
                }
            }
        }

        private void Save_Event(object sender, EventArgs e)
        {
            saveText();
            Close();
        }
    }
}
