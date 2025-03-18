/*
 * Matthew Foley
 * CST-150
 * Project 
 * 3/17/25
 * cictation
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_2.BuisnessLayer;

namespace Project_2
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
            lblError.Visible = false;
            BtnSave.Visible = false;
            gvShowInventory.ColumnCount = 5;
        }


        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bill = txtName.Text;
            var comboBox = cmbSeason.Text;
            double Price = 0.00D, Quantity = 0.00D;
            lblError.Visible = false;
            bool isValidEnteries = true;
            bool isValid = false;
            Utilities utility = new Utilities();
            if (!utility.NotNull(txtName.Text) || !utility.NotNull(txtPrice.Text) || !utility.NotNull(txtQuantaty.Text))
            {
                isValidEnteries = false;
            }
            (Price, isValid) = utility.ValidDouble(txtPrice.Text);
            if (!isValid)
            {
                isValidEnteries = false;
            }
            (Quantity, isValid) = utility.ValidDouble(txtQuantaty.Text);
            if (!isValid)
            {
                isValidEnteries = false;
            }
            if (isValidEnteries)
            {
                InvItem TempItem = new InvItem(txtName.Text, Price, Quantity, cmbConsume.Text, cmbSeason.Text);
                gvShowInventory.Rows.Add(txtName.Text, Price, Quantity, cmbSeason.Text, cmbConsume.Text);
                BtnSave.Visible = true;
                btn1.Visible = false;
            }
            else
            {
                lblError.Visible = true;
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Save(object sender, EventArgs e)
        {
            string filepath = "Data\\Inventory.txt";
            for (int i = 0; i < gvShowInventory.Rows.Count - 1; i++)
            {
                for (int j = 0; j < gvShowInventory.Columns.Count; j++)
                {
                    if (j < gvShowInventory.Columns.Count - 1)
                    {
                        File.AppendAllText(filepath, gvShowInventory.Rows[i].Cells[j].Value.ToString() + ",");
                    }
                    else
                    {
                        File.AppendAllText(filepath, gvShowInventory.Rows[i].Cells[j].Value.ToString() + ",\n");
                    }
                }
            }
            Close();
        }
    }
}
