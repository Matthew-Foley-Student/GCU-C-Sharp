namespace Project_2
{
    partial class HomePage
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
            btnDisplay = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = SystemColors.Info;
            btnDisplay.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisplay.ImageAlign = ContentAlignment.MiddleRight;
            btnDisplay.Location = new Point(572, 316);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(226, 110);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "Display Inventory";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += DisplayEvent;
            // 
            // button1
            // 
            button1.BackColor = Color.LawnGreen;
            button1.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 316);
            button1.Name = "button1";
            button1.Size = new Size(208, 110);
            button1.TabIndex = 1;
            button1.Text = "New Item Into Inventory";
            button1.UseVisualStyleBackColor = false;
            button1.Click += InputForm;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 451);
            Controls.Add(button1);
            Controls.Add(btnDisplay);
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDisplay;
        private Button button1;
    }
}
