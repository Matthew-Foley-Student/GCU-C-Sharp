namespace Random_Dice_Generator
{
    partial class Form1
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
            pctDice1 = new PictureBox();
            pctDice2 = new PictureBox();
            label1 = new Label();
            btnRollDice = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pctDice1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctDice2).BeginInit();
            SuspendLayout();
            // 
            // pctDice1
            // 
            pctDice1.Location = new Point(54, 130);
            pctDice1.Name = "pctDice1";
            pctDice1.Size = new Size(270, 237);
            pctDice1.SizeMode = PictureBoxSizeMode.StretchImage;
            pctDice1.TabIndex = 0;
            pctDice1.TabStop = false;
            // 
            // pctDice2
            // 
            pctDice2.Location = new Point(505, 130);
            pctDice2.Name = "pctDice2";
            pctDice2.Size = new Size(270, 237);
            pctDice2.SizeMode = PictureBoxSizeMode.StretchImage;
            pctDice2.TabIndex = 1;
            pctDice2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 81);
            label1.Name = "label1";
            label1.Size = new Size(73, 30);
            label1.TabIndex = 2;
            label1.Text = "Dice 1";
            // 
            // btnRollDice
            // 
            btnRollDice.BackColor = SystemColors.Desktop;
            btnRollDice.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRollDice.Location = new Point(330, 179);
            btnRollDice.Name = "btnRollDice";
            btnRollDice.Size = new Size(169, 96);
            btnRollDice.TabIndex = 4;
            btnRollDice.Text = "Roll Random Set Of Dice";
            btnRollDice.UseVisualStyleBackColor = false;
            btnRollDice.Click += RollRandomDiceEvent;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(608, 81);
            label3.Name = "label3";
            label3.Size = new Size(73, 30);
            label3.TabIndex = 5;
            label3.Text = "Dice 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnRollDice);
            Controls.Add(label1);
            Controls.Add(pctDice2);
            Controls.Add(pctDice1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pctDice1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctDice2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctDice1;
        private PictureBox pctDice2;
        private Label label1;
        private Button btnRollDice;
        private Label label3;
    }
}
