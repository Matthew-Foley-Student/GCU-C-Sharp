/*
 * Matthew Foley
 * CST-150
 * Activity 6 File Editing
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
using CST_150_ListTogv.Models;

namespace CST_150_ListTogv
{
    public partial class frmSecondary : Form
    {
        //Class list
        List<InvItem> mySearch = new List<InvItem>();

        /// <summary>
        /// Parameters and Constructors
        /// </summary>
        /// <param name="invSearch"></param>
        public frmSecondary(List<InvItem> invSearch)
        {
            InitializeComponent();
            this.mySearch = invSearch;
        }

        private void frmSecondary_Load(object sender, EventArgs e)
        {
            gvSearchResults.DataSource = this.mySearch;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
