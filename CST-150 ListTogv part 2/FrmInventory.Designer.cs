namespace CST_150_ListTogv
{
    partial class FrmInventory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gvInv = new DataGridView();
            btnIncQty = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            txtSearchFor = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)gvInv).BeginInit();
            SuspendLayout();
            // 
            // gvInv
            // 
            gvInv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvInv.Location = new Point(12, 79);
            gvInv.Name = "gvInv";
            gvInv.Size = new Size(776, 347);
            gvInv.TabIndex = 0;
            gvInv.Click += Grid_View_ClickEvent;
            // 
            // btnIncQty
            // 
            btnIncQty.Location = new Point(71, 12);
            btnIncQty.Name = "btnIncQty";
            btnIncQty.Size = new Size(168, 59);
            btnIncQty.TabIndex = 1;
            btnIncQty.Text = "Increase Quantity";
            btnIncQty.UseVisualStyleBackColor = true;
            btnIncQty.Click += BtnIncQty_ClickEvent;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(486, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 67);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save And Close";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += Save_Event;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(320, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += Delete_Event;
            // 
            // txtSearchFor
            // 
            txtSearchFor.Location = new Point(293, 52);
            txtSearchFor.Name = "txtSearchFor";
            txtSearchFor.Size = new Size(128, 23);
            txtSearchFor.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 55);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 5;
            label1.Text = "Search";
            // 
            // button1
            // 
            button1.Location = new Point(427, 47);
            button1.Name = "button1";
            button1.Size = new Size(38, 30);
            button1.TabIndex = 6;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Search_Event;
            // 
            // FrmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtSearchFor);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnIncQty);
            Controls.Add(gvInv);
            Name = "FrmInventory";
            Text = "Inventory";
            Load += PopulateGrid_EventHandler;
            ((System.ComponentModel.ISupportInitialize)gvInv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvInv;
        private Button btnIncQty;
        private Button btnSave;
        private Button btnDelete;
        private TextBox txtSearchFor;
        private Label label1;
        private Button button1;
    }
}
