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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_2.BuisnessLayer;

namespace Project_2
{
    public partial class frmSecondary : Form
    {
        List<InvItem> mySearch = new List<InvItem>();
        public frmSecondary(List<InvItem> invSearch)
        {
            InitializeComponent();
            this.mySearch = invSearch;
        }

        private void frmSecondary_Load(object sender, EventArgs e)
        {
            gvSearchResults.DataSource = this.mySearch;
        }

        private void close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
