/*
 * Matthew Foley
 * CST-150
 * Dog Name Activity
 * 3/10/25
 * Citation Here
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
using CST_150_DogClass.BuisnessLayer;

namespace CST_150_DogClass.PresentationLayer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();            
            //make sure the Error label is not visible
            lblErrorMessege.Visible = false;
        }

        /// <summary>
        /// Click  Event to add a new dog to the datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddNewDog_ClickEvent(object sender, EventArgs e)
        {
            //Declare and Initilize
            var bill = txtName.Text;
            var combobox = cmbSit.Text;
            //Flag that tracks if all enteries are valid
            bool isValidEnteries = true;
            double weight = 0.00D, neckRad = 0.00D, neckCircum = 0.00D;
            //Flag to verify parsing doubles is true or false
            bool isValid = false;

            lblErrorMessege.Visible = false;

            //Inistiate out Utility class so we can use it
            Utility utility = new Utility();

            //-------------------------------------------------------------------------
            //Verify all boxes have correct inputs
            //We will be using a Utility / Helper Class to verify inputs
            if (!utility.NotNull(txtName.Text) || !utility.NotNull(txtColor.Text) || (cmbSit.SelectedItem == null))
            {
                isValidEnteries = false;
            }
            //Now test the text box for valid double neck size
            (neckRad, isValid) = utility.ValidDouble(txtNeck.Text);
            if (!isValid)
            {
                isValidEnteries = false;
            }
            //Now test the weight
            //valid weights will have double values
            (weight, isValid) = utility.ValidDouble(txtWeight.Text);
            if (isValid)
            {
                isValidEnteries = true;
            }

            //datagridview with the entries
            //else display the error messege
            if (isValidEnteries)
            {
                //if we are here we know we have valid enteris
                //so lets populate the datagridview
                Dog dogObject = new Dog(txtName.Text, neckRad, txtColor.Text, weight, utility.ConvertToBool(cmbSit.Text));
                gvShowDogs.Rows.Add(dogObject.Name, dogObject.CalCircumference(), dogObject.Sit, dogObject.CalWeight(), dogObject.Color);
            }
            else
            {
                lblErrorMessege.Visible = true;
            }
        }

        /// <summary>
        /// When form loads excute this even handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMainLoadEventHandler(object sender, EventArgs e)
        {
            gvShowDogs.ColumnCount = 5;
            gvShowDogs.Columns[0].Name = "Name";
            gvShowDogs.Columns[1].Name = "Neck Cirum";
            gvShowDogs.Columns[2].Name = "Sitting";
            gvShowDogs.Columns[3].Name = "Weight";
            gvShowDogs.Columns[4].Name = "Color";

            //Format number in neck and weight for 2 decimal places
            gvShowDogs.Columns[1].DefaultCellStyle.Format = "#.00";
            gvShowDogs.Columns[3].DefaultCellStyle.Format = "#.00";
        }
    }
}
