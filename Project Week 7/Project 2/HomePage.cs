/*
 * Matthew Foley
 * CST-150
 * Project 
 * 3/17/25
 * cictation
 */
using Project_2.BuisnessLayer;

namespace Project_2
{
    public partial class HomePage : Form
    {
        List<InvItem> invSearch = new List<InvItem>();
        public HomePage()
        {
            InitializeComponent();
        }

        private void DisplayEvent(object sender, EventArgs e)
        {
            DisplayInv otherForm = new DisplayInv();
            otherForm.FormClosed += new FormClosedEventHandler(InventoryForm_FormClosed);
            this.Hide();
            otherForm.Show();
        }
        void InventoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void InputForm(object sender, EventArgs e)
        {
            InputForm otherForm = new InputForm();
            otherForm.FormClosed += new FormClosedEventHandler(InputForm_FormClosed);
            this.Hide();
            otherForm.Show();
        }

        void InputForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }



        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

    }
}
