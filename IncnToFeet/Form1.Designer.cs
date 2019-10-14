namespace IncnToFeet
{
    partial class FrmFeetInch
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
            this.BtnConvertInches = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConvertInches
            // 
            this.BtnConvertInches.Location = new System.Drawing.Point(124, 138);
            this.BtnConvertInches.Name = "BtnConvertInches";
            this.BtnConvertInches.Size = new System.Drawing.Size(226, 55);
            this.BtnConvertInches.TabIndex = 0;
            this.BtnConvertInches.Text = "Inches To Feet";
            this.BtnConvertInches.UseVisualStyleBackColor = true;
            this.BtnConvertInches.Click += new System.EventHandler(this.BtnConvertInches_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "12 Inches = 1 Foot";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // FrmFeetInch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConvertInches);
            this.Name = "FrmFeetInch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feet Inches Problem";
            this.Load += new System.EventHandler(this.FrmFeetInch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConvertInches;
        private System.Windows.Forms.Label label1;
    }
}

