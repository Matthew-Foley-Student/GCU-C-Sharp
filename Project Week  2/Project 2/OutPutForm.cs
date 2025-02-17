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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class OutputForm : Form
    {
        public OutputForm()
        {
            InitializeComponent();
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
