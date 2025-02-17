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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            imageList1 = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(312, 346);
            button1.Name = "button1";
            button1.Size = new Size(176, 92);
            button1.TabIndex = 0;
            button1.Text = "Back To Homepage";
            button1.UseVisualStyleBackColor = false;
            button1.Click += CloseWindow;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 22);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 1;
            label1.Text = "Lumber (Oak)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(616, 22);
            label2.Name = "label2";
            label2.Size = new Size(27, 19);
            label2.TabIndex = 2;
            label2.Text = "15";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(257, 81);
            label3.Name = "label3";
            label3.Size = new Size(118, 19);
            label3.TabIndex = 3;
            label3.Text = "Lumber (Teak)";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(616, 81);
            label4.Name = "label4";
            label4.Size = new Size(27, 19);
            label4.TabIndex = 4;
            label4.Text = "28";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(257, 151);
            label5.Name = "label5";
            label5.Size = new Size(161, 19);
            label5.TabIndex = 5;
            label5.Text = "SnowGlobe (Frosty)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(616, 151);
            label6.Name = "label6";
            label6.Size = new Size(18, 19);
            label6.TabIndex = 6;
            label6.Text = "5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(257, 232);
            label7.Name = "label7";
            label7.Size = new Size(158, 19);
            label7.TabIndex = 7;
            label7.Text = "Flooring (Lenolium)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(616, 232);
            label8.Name = "label8";
            label8.Size = new Size(36, 19);
            label8.TabIndex = 8;
            label8.Text = "203";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(257, 308);
            label9.Name = "label9";
            label9.Size = new Size(134, 19);
            label9.TabIndex = 9;
            label9.Text = "Flooring (Vienal)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(616, 308);
            label10.Name = "label10";
            label10.Size = new Size(27, 19);
            label10.TabIndex = 10;
            label10.Text = "68";
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Inventory";
            Text = "Inventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ImageList imageList1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}