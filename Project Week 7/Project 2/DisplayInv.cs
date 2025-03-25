/*
 * Matthew Foley
 * CST-150
 * Project 
 * 3/25/25
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
using System.Xml.Linq;
using Project_2.BuisnessLayer;
using static System.Windows.Forms.LinkLabel;

namespace Project_2
{
    public partial class DisplayInv : Form
    {
        List<InvItem> invItems = new List<InvItem>();
        List<InvItem> invSearch = new List<InvItem>();
        private int SelectedgridIndex { get; set; }
        public DisplayInv()
        {
            InitializeComponent();
            lblError.Visible = false;
        }

        private void PopulateGrid_EventHandler(object sender, System.EventArgs e)
        {
            Inventory readInv = new Inventory();
            invItems = readInv.ReadInventory(invItems);
            gvShowInventory.DataSource = null;
            gvShowInventory.DataSource = invItems;
            StreamWriter outputFile;
            outputFile = File.CreateText("Data\\Inventory.txt");
            outputFile.WriteLine(gvShowInventory.DataSource);
            outputFile.Close();
            foreach (DataGridViewColumn column in gvShowInventory.Columns)
            {
                //switch statmets to change the text header
                //colimn.index starets and 0-endcount
                switch (column.Index)
                {
                    case 0:
                        column.HeaderText = "Name";
                        break;
                    case 1:
                        column.HeaderText = "Price";
                        break;
                    case 2:
                        column.HeaderText = "Quantity";
                        break;
                    case 3:
                        column.HeaderText = "Season";
                        break;
                    case 4:
                        column.HeaderText = "Consumable";
                        break;
                    default:
                        //Show a message to indiacte something wasnt working
                        MessageBox.Show("Invalid Column was detected when data was accessed!");
                        break;
                }
            }
        }

        private void gvShowInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedgridIndex = gvShowInventory.CurrentRow.Index;
        }

        private void btn_IncreaseQty(object sender, EventArgs e)
        {
            Inventory incQty = new Inventory();
            invItems = incQty.IncQtyValue(invItems, SelectedgridIndex);
            gvShowInventory.Refresh();
        }

        private void btn_decreese(object sender, EventArgs e)
        {
            Inventory decrQty = new Inventory();
            invItems = decrQty.DecreQtyValue(invItems, SelectedgridIndex);
            gvShowInventory.Refresh();
        }

        private void Save_Return(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void Save()
        {
            string filepath = "Data\\Inventory.txt";
            File.Delete("Data\\Inventory.txt");
            for (int i = 0; i < gvShowInventory.Rows.Count; i++)
            {
                for (int j = 0; j < gvShowInventory.Columns.Count; j++)
                {
                    if (j < 4)
                    {
                        File.AppendAllText(filepath, gvShowInventory.Rows[i].Cells[j].Value.ToString() + ",");
                    }
                    else
                    {
                        File.AppendAllText(filepath, gvShowInventory.Rows[i].Cells[j].Value.ToString() + ",\n");
                    }
                }
            }
        }

        private void gvShowInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedgridIndex = gvShowInventory.CurrentRow.Index;
        }

        private void Search(object sender, EventArgs e)
        {
            Save();
            if (txtSearch.Text == "")
            {
                lblError.Visible = true;
            }
            string searchFor = txtSearch.Text;
            lblError.Visible = false;
            Inventory buisinessLayer = new Inventory();
            invSearch = buisinessLayer.SearchItem(invItems, invSearch, searchFor);
            frmSecondary frmSecondary = new frmSecondary(invSearch);
            //Now to show the new form and take note the show dialog to have a form
            frmSecondary.ShowDialog();
        }

        private void Deleter(object sender, EventArgs e)
        {
            invItems.RemoveAt(SelectedgridIndex);
            gvShowInventory.DataSource = null;
            gvShowInventory.DataSource = invItems;
        }
    }//End Of the Programm
}
