namespace Project_2
{
    partial class DisplayInv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHomepage = new Button();
            selectFileDialog = new OpenFileDialog();
            gvShowInventory = new DataGridView();
            btnIncrease = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)gvShowInventory).BeginInit();
            SuspendLayout();
            // 
            // btnHomepage
            // 
            btnHomepage.BackColor = SystemColors.ButtonShadow;
            btnHomepage.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHomepage.Location = new Point(575, 636);
            btnHomepage.Name = "btnHomepage";
            btnHomepage.Size = new Size(216, 113);
            btnHomepage.TabIndex = 0;
            btnHomepage.Text = "Save And Return To HomePage";
            btnHomepage.UseVisualStyleBackColor = false;
            btnHomepage.Click += Save_Return;
            // 
            // selectFileDialog
            // 
            selectFileDialog.FileName = " SelectFileDialog";
            // 
            // gvShowInventory
            // 
            gvShowInventory.AllowUserToOrderColumns = true;
            gvShowInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvShowInventory.Location = new Point(12, 12);
            gvShowInventory.Name = "gvShowInventory";
            gvShowInventory.Size = new Size(1295, 602);
            gvShowInventory.TabIndex = 3;
            gvShowInventory.CellClick += gvShowInventory_CellClick;
            gvShowInventory.CellContentClick += gvShowInventory_CellContentClick;
            // 
            // btnIncrease
            // 
            btnIncrease.BackColor = Color.GreenYellow;
            btnIncrease.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncrease.Location = new Point(12, 636);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(216, 113);
            btnIncrease.TabIndex = 4;
            btnIncrease.Text = "Increase Quantity";
            btnIncrease.UseVisualStyleBackColor = false;
            btnIncrease.Click += btn_IncreaseQty;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1091, 636);
            button1.Name = "button1";
            button1.Size = new Size(216, 113);
            button1.TabIndex = 5;
            button1.Text = "Decrees Quantity";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_decreese;
            // 
            // DisplayInv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 761);
            Controls.Add(button1);
            Controls.Add(btnIncrease);
            Controls.Add(gvShowInventory);
            Controls.Add(btnHomepage);
            Name = "DisplayInv";
            Text = "Inventory";
            Load += PopulateGrid_EventHandler;
            ((System.ComponentModel.ISupportInitialize)gvShowInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHomepage;
        private OpenFileDialog selectFileDialog;
        private DataGridView gvShowInventory;
        private Button btnIncrease;
        private Button button1;
    }
}