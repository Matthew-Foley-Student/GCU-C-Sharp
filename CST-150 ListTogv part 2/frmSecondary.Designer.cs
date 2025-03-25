namespace CST_150_ListTogv
{
    partial class frmSecondary
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
            gvSearchResults = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)gvSearchResults).BeginInit();
            SuspendLayout();
            // 
            // gvSearchResults
            // 
            gvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvSearchResults.Location = new Point(94, 68);
            gvSearchResults.Name = "gvSearchResults";
            gvSearchResults.Size = new Size(566, 369);
            gvSearchResults.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(286, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(147, 54);
            btnClose.TabIndex = 1;
            btnClose.Text = "Go Back";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmSecondary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(gvSearchResults);
            Name = "frmSecondary";
            Text = "frmSecondary";
            Load += frmSecondary_Load;
            ((System.ComponentModel.ISupportInitialize)gvSearchResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gvSearchResults;
        private Button btnClose;
    }
}