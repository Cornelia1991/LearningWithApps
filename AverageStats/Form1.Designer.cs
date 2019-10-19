namespace AverageStats
{
    partial class FrmAverageStats
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
            this.BtnGetInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGetInfo
            // 
            this.BtnGetInfo.Location = new System.Drawing.Point(362, 86);
            this.BtnGetInfo.Name = "BtnGetInfo";
            this.BtnGetInfo.Size = new System.Drawing.Size(145, 53);
            this.BtnGetInfo.TabIndex = 0;
            this.BtnGetInfo.Text = "Get Average Stats";
            this.BtnGetInfo.UseVisualStyleBackColor = true;
            this.BtnGetInfo.Click += new System.EventHandler(this.BtnGetInfo_Click);
            // 
            // FrmAverageStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnGetInfo);
            this.Name = "FrmAverageStats";
            this.Text = "Average Stats";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGetInfo;
    }
}

