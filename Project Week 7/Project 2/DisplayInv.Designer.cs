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
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblError = new Label();
            button2 = new Button();
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
            gvShowInventory.Location = new Point(12, 104);
            gvShowInventory.Name = "gvShowInventory";
            gvShowInventory.Size = new Size(1295, 510);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(383, 37);
            label1.Name = "label1";
            label1.Size = new Size(72, 24);
            label1.TabIndex = 6;
            label1.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(455, 34);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(230, 32);
            txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(691, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(174, 61);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Advanced Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += Search;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(477, 73);
            lblError.Name = "lblError";
            lblError.Size = new Size(126, 15);
            lblError.TabIndex = 9;
            lblError.Text = "PLease Put In An Input";
            // 
            // button2
            // 
            button2.Location = new Point(1191, 58);
            button2.Name = "button2";
            button2.Size = new Size(116, 44);
            button2.TabIndex = 10;
            button2.Text = "Delete Item";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Deleter;
            // 
            // DisplayInv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 761);
            Controls.Add(button2);
            Controls.Add(lblError);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnIncrease);
            Controls.Add(gvShowInventory);
            Controls.Add(btnHomepage);
            Name = "DisplayInv";
            Text = "Inventory";
            Load += PopulateGrid_EventHandler;
            ((System.ComponentModel.ISupportInitialize)gvShowInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHomepage;
        private OpenFileDialog selectFileDialog;
        private DataGridView gvShowInventory;
        private Button btnIncrease;
        private Button button1;
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblError;
        private Button button2;
    }
}