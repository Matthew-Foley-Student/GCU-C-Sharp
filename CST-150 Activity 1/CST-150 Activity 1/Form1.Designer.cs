namespace CST_150_Activity_1
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
            lblEarthWeight = new Label();
            lblMarsWeight = new Label();
            lblMars = new Label();
            btnConvert = new Button();
            txtEarthWeight = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblEarthWeight
            // 
            lblEarthWeight.AutoSize = true;
            lblEarthWeight.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEarthWeight.Location = new Point(118, 72);
            lblEarthWeight.Name = "lblEarthWeight";
            lblEarthWeight.Size = new Size(252, 25);
            lblEarthWeight.TabIndex = 0;
            lblEarthWeight.Text = "Enter Your weight on Earth";
            lblEarthWeight.Click += label1_Click;
            // 
            // lblMarsWeight
            // 
            lblMarsWeight.AutoSize = true;
            lblMarsWeight.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarsWeight.Location = new Point(403, 178);
            lblMarsWeight.Name = "lblMarsWeight";
            lblMarsWeight.Size = new Size(59, 25);
            lblMarsWeight.TabIndex = 1;
            lblMarsWeight.Text = "Label";
            // 
            // lblMars
            // 
            lblMars.AutoSize = true;
            lblMars.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMars.Location = new Point(170, 178);
            lblMars.Name = "lblMars";
            lblMars.Size = new Size(200, 25);
            lblMars.TabIndex = 2;
            lblMars.Text = "Your Weight on Mars";
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvert.Location = new Point(353, 248);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(157, 62);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Convert Weight";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += ConvertButtonClickEvent;
            // 
            // txtEarthWeight
            // 
            txtEarthWeight.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEarthWeight.Location = new Point(403, 77);
            txtEarthWeight.Name = "txtEarthWeight";
            txtEarthWeight.Size = new Size(107, 33);
            txtEarthWeight.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(516, 85);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 5;
            label1.Text = "lbs";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtEarthWeight);
            Controls.Add(btnConvert);
            Controls.Add(lblMars);
            Controls.Add(lblMarsWeight);
            Controls.Add(lblEarthWeight);
            Name = "Form1";
            Text = "Your Weight on Mars";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEarthWeight;
        private Label lblMarsWeight;
        private Label lblMars;
        private Button btnConvert;
        private TextBox txtEarthWeight;
        private Label label1;
    }
}
