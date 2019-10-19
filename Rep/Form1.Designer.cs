namespace Rep
{
    partial class FrmRep
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
            this.BtnRepEx = new System.Windows.Forms.Button();
            this.BtnCounter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRepEx
            // 
            this.BtnRepEx.Location = new System.Drawing.Point(226, 42);
            this.BtnRepEx.Name = "BtnRepEx";
            this.BtnRepEx.Size = new System.Drawing.Size(134, 40);
            this.BtnRepEx.TabIndex = 0;
            this.BtnRepEx.Text = "Rep Example";
            this.BtnRepEx.UseVisualStyleBackColor = true;
            this.BtnRepEx.Click += new System.EventHandler(this.BtnRepEx_Click);
            // 
            // BtnCounter
            // 
            this.BtnCounter.Location = new System.Drawing.Point(226, 130);
            this.BtnCounter.Name = "BtnCounter";
            this.BtnCounter.Size = new System.Drawing.Size(141, 46);
            this.BtnCounter.TabIndex = 1;
            this.BtnCounter.Text = "Counter Loop";
            this.BtnCounter.UseVisualStyleBackColor = true;
            this.BtnCounter.Click += new System.EventHandler(this.BtnCounter_Click);
            // 
            // FrmRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 387);
            this.Controls.Add(this.BtnCounter);
            this.Controls.Add(this.BtnRepEx);
            this.Name = "FrmRep";
            this.Text = "Rep Intro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRepEx;
        private System.Windows.Forms.Button BtnCounter;
    }
}

