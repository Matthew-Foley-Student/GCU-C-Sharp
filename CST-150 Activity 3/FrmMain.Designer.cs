namespace CST_150_Activity_3
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
            button1 = new Button();
            selectFileDialog = new OpenFileDialog();
            lblSelectedFile = new Label();
            lblResults = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.DarkOliveGreen;
            button1.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(297, 27);
            button1.Name = "button1";
            button1.Size = new Size(137, 48);
            button1.TabIndex = 0;
            button1.Text = "Read File";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnReadFileClickEvent;
            // 
            // selectFileDialog
            // 
            selectFileDialog.FileName = "openFileDialog1";
            // 
            // lblSelectedFile
            // 
            lblSelectedFile.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectedFile.ForeColor = Color.Firebrick;
            lblSelectedFile.Location = new Point(-2, 390);
            lblSelectedFile.Name = "lblSelectedFile";
            lblSelectedFile.Size = new Size(801, 60);
            lblSelectedFile.TabIndex = 1;
            lblSelectedFile.Text = "label1";
            lblSelectedFile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResults.Location = new Point(141, 129);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(67, 16);
            lblResults.TabIndex = 2;
            lblResults.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResults);
            Controls.Add(lblSelectedFile);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private OpenFileDialog selectFileDialog;
        private Label lblSelectedFile;
        private Label lblResults;
    }
}
