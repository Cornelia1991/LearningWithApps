namespace TestGrades
{
    partial class FrmTestGrades
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
            this.LblFormTitle = new System.Windows.Forms.Label();
            this.LblTestOne = new System.Windows.Forms.Label();
            this.LblTestTwo = new System.Windows.Forms.Label();
            this.LblTestThree = new System.Windows.Forms.Label();
            this.LblTestFour = new System.Windows.Forms.Label();
            this.TxtTestOne = new System.Windows.Forms.TextBox();
            this.TxtTestTwo = new System.Windows.Forms.TextBox();
            this.TxtTestThree = new System.Windows.Forms.TextBox();
            this.TxtTestFour = new System.Windows.Forms.TextBox();
            this.BtnGetResult = new System.Windows.Forms.Button();
            this.TxtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblFormTitle
            // 
            this.LblFormTitle.AutoSize = true;
            this.LblFormTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormTitle.Location = new System.Drawing.Point(250, 52);
            this.LblFormTitle.Name = "LblFormTitle";
            this.LblFormTitle.Size = new System.Drawing.Size(376, 36);
            this.LblFormTitle.TabIndex = 0;
            this.LblFormTitle.Text = "Enter Your Average Grades";
            this.LblFormTitle.Click += new System.EventHandler(this.LblFormTitle_Click);
            // 
            // LblTestOne
            // 
            this.LblTestOne.AutoSize = true;
            this.LblTestOne.Location = new System.Drawing.Point(246, 149);
            this.LblTestOne.Name = "LblTestOne";
            this.LblTestOne.Size = new System.Drawing.Size(48, 17);
            this.LblTestOne.TabIndex = 1;
            this.LblTestOne.Text = "Test 1";
            // 
            // LblTestTwo
            // 
            this.LblTestTwo.AutoSize = true;
            this.LblTestTwo.Location = new System.Drawing.Point(246, 194);
            this.LblTestTwo.Name = "LblTestTwo";
            this.LblTestTwo.Size = new System.Drawing.Size(48, 17);
            this.LblTestTwo.TabIndex = 2;
            this.LblTestTwo.Text = "Test 2";
            // 
            // LblTestThree
            // 
            this.LblTestThree.AutoSize = true;
            this.LblTestThree.Location = new System.Drawing.Point(246, 234);
            this.LblTestThree.Name = "LblTestThree";
            this.LblTestThree.Size = new System.Drawing.Size(48, 17);
            this.LblTestThree.TabIndex = 3;
            this.LblTestThree.Text = "Test 3";
            // 
            // LblTestFour
            // 
            this.LblTestFour.AutoSize = true;
            this.LblTestFour.Location = new System.Drawing.Point(246, 274);
            this.LblTestFour.Name = "LblTestFour";
            this.LblTestFour.Size = new System.Drawing.Size(48, 17);
            this.LblTestFour.TabIndex = 4;
            this.LblTestFour.Text = "Test 4";
            this.LblTestFour.Click += new System.EventHandler(this.LblTestFour_Click);
            // 
            // TxtTestOne
            // 
            this.TxtTestOne.Location = new System.Drawing.Point(356, 144);
            this.TxtTestOne.Name = "TxtTestOne";
            this.TxtTestOne.Size = new System.Drawing.Size(69, 22);
            this.TxtTestOne.TabIndex = 5;
            this.TxtTestOne.TextChanged += new System.EventHandler(this.TxtTestOne_TextChanged);
            // 
            // TxtTestTwo
            // 
            this.TxtTestTwo.Location = new System.Drawing.Point(356, 189);
            this.TxtTestTwo.Name = "TxtTestTwo";
            this.TxtTestTwo.Size = new System.Drawing.Size(69, 22);
            this.TxtTestTwo.TabIndex = 6;
            this.TxtTestTwo.TextChanged += new System.EventHandler(this.TxtTestTwo_TextChanged);
            // 
            // TxtTestThree
            // 
            this.TxtTestThree.Location = new System.Drawing.Point(356, 229);
            this.TxtTestThree.Name = "TxtTestThree";
            this.TxtTestThree.Size = new System.Drawing.Size(69, 22);
            this.TxtTestThree.TabIndex = 7;
            this.TxtTestThree.TextChanged += new System.EventHandler(this.TxtTestThree_TextChanged);
            // 
            // TxtTestFour
            // 
            this.TxtTestFour.Location = new System.Drawing.Point(356, 271);
            this.TxtTestFour.Name = "TxtTestFour";
            this.TxtTestFour.Size = new System.Drawing.Size(69, 22);
            this.TxtTestFour.TabIndex = 8;
            this.TxtTestFour.TextChanged += new System.EventHandler(this.TxtTestFour_TextChanged);
            // 
            // BtnGetResult
            // 
            this.BtnGetResult.Location = new System.Drawing.Point(307, 319);
            this.BtnGetResult.Name = "BtnGetResult";
            this.BtnGetResult.Size = new System.Drawing.Size(75, 23);
            this.BtnGetResult.TabIndex = 9;
            this.BtnGetResult.Text = "Results";
            this.BtnGetResult.UseVisualStyleBackColor = true;
            this.BtnGetResult.Click += new System.EventHandler(this.BtnGetResult_Click);
            // 
            // TxtResults
            // 
            this.TxtResults.Location = new System.Drawing.Point(578, 191);
            this.TxtResults.Multiline = true;
            this.TxtResults.Name = "TxtResults";
            this.TxtResults.Size = new System.Drawing.Size(154, 102);
            this.TxtResults.TabIndex = 10;
            this.TxtResults.TextChanged += new System.EventHandler(this.TxtResults_TextChanged);
            // 
            // FrmTestGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResults);
            this.Controls.Add(this.BtnGetResult);
            this.Controls.Add(this.TxtTestFour);
            this.Controls.Add(this.TxtTestThree);
            this.Controls.Add(this.TxtTestTwo);
            this.Controls.Add(this.TxtTestOne);
            this.Controls.Add(this.LblTestFour);
            this.Controls.Add(this.LblTestThree);
            this.Controls.Add(this.LblTestTwo);
            this.Controls.Add(this.LblTestOne);
            this.Controls.Add(this.LblFormTitle);
            this.Name = "FrmTestGrades";
            this.Text = "Test Grades";
            this.Load += new System.EventHandler(this.FrmTestGrades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFormTitle;
        private System.Windows.Forms.Label LblTestOne;
        private System.Windows.Forms.Label LblTestTwo;
        private System.Windows.Forms.Label LblTestThree;
        private System.Windows.Forms.Label LblTestFour;
        private System.Windows.Forms.TextBox TxtTestOne;
        private System.Windows.Forms.TextBox TxtTestTwo;
        private System.Windows.Forms.TextBox TxtTestThree;
        private System.Windows.Forms.TextBox TxtTestFour;
        private System.Windows.Forms.Button BtnGetResult;
        private System.Windows.Forms.TextBox TxtResults;
    }
}

