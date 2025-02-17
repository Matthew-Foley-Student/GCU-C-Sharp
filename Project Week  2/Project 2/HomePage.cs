/*
 * Matthew Foley
 * CST-150
 * Activity #1
 * 2/20/25
 * cictation
 */
namespace Project_2
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();

        }

        private void DisplayEvent(object sender, EventArgs e)
        {
            Inventory otherForm = new Inventory();
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

        private void OutPutForm(object sender, EventArgs e)
        {
            OutputForm otherForm = new OutputForm();
            otherForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            this.Hide();
            otherForm.Show();
        }

        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
