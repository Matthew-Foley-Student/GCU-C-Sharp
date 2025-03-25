/*
 * Matthew Foley
 * CST-150
 * Activity #1
 * 2/20/25
 * cictation
 */
namespace Project_2
{
    partial class InputForm
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
            btn1 = new Button();
            txtName = new TextBox();
            cmbSeason = new ComboBox();
            cmbConsume = new ComboBox();
            txtPrice = new TextBox();
            txtQuantaty = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblError = new Label();
            BtnSave = new Button();
            gvShowInventory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gvShowInventory).BeginInit();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(267, 357);
            btn1.Name = "btn1";
            btn1.Size = new Size(159, 55);
            btn1.TabIndex = 0;
            btn1.Text = "Check If Valid Item";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(288, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(173, 23);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // cmbSeason
            // 
            cmbSeason.FormattingEnabled = true;
            cmbSeason.Items.AddRange(new object[] { "All-Seasons", "Summer", "Winter", "Spring", "Fall" });
            cmbSeason.Location = new Point(288, 196);
            cmbSeason.Name = "cmbSeason";
            cmbSeason.Size = new Size(121, 23);
            cmbSeason.TabIndex = 2;
            // 
            // cmbConsume
            // 
            cmbConsume.FormattingEnabled = true;
            cmbConsume.Items.AddRange(new object[] { "Yes", "No" });
            cmbConsume.Location = new Point(284, 263);
            cmbConsume.Name = "cmbConsume";
            cmbConsume.Size = new Size(121, 23);
            cmbConsume.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(288, 96);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(173, 23);
            txtPrice.TabIndex = 4;
            // 
            // txtQuantaty
            // 
            txtQuantaty.Location = new Point(288, 140);
            txtQuantaty.Name = "txtQuantaty";
            txtQuantaty.Size = new Size(173, 23);
            txtQuantaty.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 44);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 6;
            label1.Text = "Name Of The Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 99);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 7;
            label2.Text = "Price Of The Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 143);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 8;
            label3.Text = "Total Amount In Storage";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 266);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 9;
            label4.Text = "Is It Consumable?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 199);
            label5.Name = "label5";
            label5.Size = new Size(135, 15);
            label5.TabIndex = 10;
            label5.Text = "When Can It Be Bought?";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.DodgerBlue;
            lblError.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(142, 305);
            lblError.Name = "lblError";
            lblError.Size = new Size(359, 32);
            lblError.TabIndex = 11;
            lblError.Text = "One Of The Inputs Is Incorrect";
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(284, 344);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(125, 80);
            BtnSave.TabIndex = 12;
            BtnSave.Text = "Save Item To Inventory";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += Btn_Save;
            // 
            // gvShowInventory
            // 
            gvShowInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvShowInventory.Location = new Point(564, 110);
            gvShowInventory.Name = "gvShowInventory";
            gvShowInventory.Size = new Size(159, 188);
            gvShowInventory.TabIndex = 13;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gvShowInventory);
            Controls.Add(BtnSave);
            Controls.Add(lblError);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQuantaty);
            Controls.Add(txtPrice);
            Controls.Add(cmbConsume);
            Controls.Add(cmbSeason);
            Controls.Add(txtName);
            Controls.Add(btn1);
            Name = "InputForm";
            Text = "Input Form";
            ((System.ComponentModel.ISupportInitialize)gvShowInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private TextBox txtName;
        private ComboBox cmbSeason;
        private ComboBox cmbConsume;
        private TextBox txtPrice;
        private TextBox txtQuantaty;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblError;
        private Button BtnSave;
        private DataGridView gvShowInventory;
    }
}