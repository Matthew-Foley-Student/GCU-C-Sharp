namespace WinFormsApp1
{
    partial class FrmSeconds
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
            btnRun = new Button();
            txtUserEntery = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblResults = new Label();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRun.Location = new Point(344, 107);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(121, 54);
            btnRun.TabIndex = 0;
            btnRun.Text = "Apply The Seconds";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += ManageSecondsEventHandler;
            // 
            // txtUserEntery
            // 
            txtUserEntery.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserEntery.Location = new Point(324, 70);
            txtUserEntery.MaximumSize = new Size(161, 0);
            txtUserEntery.Name = "txtUserEntery";
            txtUserEntery.Size = new Size(161, 31);
            txtUserEntery.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 76);
            label1.Name = "label1";
            label1.Size = new Size(298, 25);
            label1.TabIndex = 2;
            label1.Text = "Enter the Number Of Seconds";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(491, 76);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 3;
            label2.Text = "Seconds";
            label2.Click += label2_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(363, 185);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(57, 15);
            lblResults.TabIndex = 4;
            lblResults.Text = "lblResults";
            // 
            // FrmSeconds
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 450);
            Controls.Add(lblResults);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUserEntery);
            Controls.Add(btnRun);
            Name = "FrmSeconds";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private TextBox txtUserEntery;
        private Label label1;
        private Label label2;
        private Label lblResults;
    }
}
