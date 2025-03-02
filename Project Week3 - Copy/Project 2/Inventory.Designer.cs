namespace Project_2
{
    partial class Inventory
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
            lblResults = new Label();
            btnDisplay = new Button();
            selectFileDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnHomepage
            // 
            btnHomepage.BackColor = SystemColors.ButtonShadow;
            btnHomepage.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHomepage.Location = new Point(709, 356);
            btnHomepage.Name = "btnHomepage";
            btnHomepage.Size = new Size(176, 92);
            btnHomepage.TabIndex = 0;
            btnHomepage.Text = "Back To Homepage";
            btnHomepage.UseVisualStyleBackColor = false;
            btnHomepage.Click += CloseWindow;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResults.Location = new Point(2, 9);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(61, 13);
            lblResults.TabIndex = 1;
            lblResults.Text = "label1";
            lblResults.Click += lblResults_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Font = new Font("Lucida Console", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisplay.Location = new Point(12, 356);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(175, 82);
            btnDisplay.TabIndex = 2;
            btnDisplay.Text = "Tempt Inventory Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // selectFileDialog
            // 
            selectFileDialog.FileName = " SelectFileDialog";
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 463);
            Controls.Add(btnDisplay);
            Controls.Add(lblResults);
            Controls.Add(btnHomepage);
            Name = "Inventory";
            Text = "Inventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHomepage;
        private Label lblResults;
        private Button btnDisplay;
        private OpenFileDialog selectFileDialog;
    }
}