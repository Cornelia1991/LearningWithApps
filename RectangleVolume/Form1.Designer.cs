namespace RectangleVolume
{
    partial class FrmRectangleVolume
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
            this.LblVolumeTitle = new System.Windows.Forms.Label();
            this.TxtLength = new System.Windows.Forms.TextBox();
            this.TxtWidth = new System.Windows.Forms.TextBox();
            this.TxtHeight = new System.Windows.Forms.TextBox();
            this.LblLength = new System.Windows.Forms.Label();
            this.LblWidth = new System.Windows.Forms.Label();
            this.LblHeight = new System.Windows.Forms.Label();
            this.BtnGetVolume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblVolumeTitle
            // 
            this.LblVolumeTitle.AutoSize = true;
            this.LblVolumeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVolumeTitle.ForeColor = System.Drawing.Color.Coral;
            this.LblVolumeTitle.Location = new System.Drawing.Point(224, 57);
            this.LblVolumeTitle.Name = "LblVolumeTitle";
            this.LblVolumeTitle.Size = new System.Drawing.Size(348, 29);
            this.LblVolumeTitle.TabIndex = 0;
            this.LblVolumeTitle.Text = "Find the Volume of a Rectangle";
            // 
            // TxtLength
            // 
            this.TxtLength.Location = new System.Drawing.Point(307, 198);
            this.TxtLength.Name = "TxtLength";
            this.TxtLength.Size = new System.Drawing.Size(151, 22);
            this.TxtLength.TabIndex = 1;
            this.TxtLength.TextChanged += new System.EventHandler(this.TxtLength_TextChanged);
            // 
            // TxtWidth
            // 
            this.TxtWidth.Location = new System.Drawing.Point(307, 288);
            this.TxtWidth.Name = "TxtWidth";
            this.TxtWidth.Size = new System.Drawing.Size(151, 22);
            this.TxtWidth.TabIndex = 2;
            this.TxtWidth.TextChanged += new System.EventHandler(this.TxtWidth_TextChanged);
            // 
            // TxtHeight
            // 
            this.TxtHeight.Location = new System.Drawing.Point(307, 371);
            this.TxtHeight.Name = "TxtHeight";
            this.TxtHeight.Size = new System.Drawing.Size(151, 22);
            this.TxtHeight.TabIndex = 3;
            this.TxtHeight.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // LblLength
            // 
            this.LblLength.AutoSize = true;
            this.LblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblLength.Location = new System.Drawing.Point(311, 172);
            this.LblLength.Name = "LblLength";
            this.LblLength.Size = new System.Drawing.Size(138, 20);
            this.LblLength.TabIndex = 4;
            this.LblLength.Text = "Enter The Length";
            // 
            // LblWidth
            // 
            this.LblWidth.AutoSize = true;
            this.LblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblWidth.Location = new System.Drawing.Point(311, 262);
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(130, 20);
            this.LblWidth.TabIndex = 5;
            this.LblWidth.Text = "Enter The Width";
            this.LblWidth.Click += new System.EventHandler(this.LblWidth_Click);
            // 
            // LblHeight
            // 
            this.LblHeight.AutoSize = true;
            this.LblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblHeight.Location = new System.Drawing.Point(313, 344);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(136, 20);
            this.LblHeight.TabIndex = 6;
            this.LblHeight.Text = "Enter The Height";
            // 
            // BtnGetVolume
            // 
            this.BtnGetVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnGetVolume.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnGetVolume.Location = new System.Drawing.Point(317, 456);
            this.BtnGetVolume.Name = "BtnGetVolume";
            this.BtnGetVolume.Size = new System.Drawing.Size(146, 39);
            this.BtnGetVolume.TabIndex = 7;
            this.BtnGetVolume.Text = "Find Volume";
            this.BtnGetVolume.UseVisualStyleBackColor = false;
            this.BtnGetVolume.Click += new System.EventHandler(this.BtnGetVolume_Click);
            // 
            // FrmRectangleVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.BtnGetVolume);
            this.Controls.Add(this.LblHeight);
            this.Controls.Add(this.LblWidth);
            this.Controls.Add(this.LblLength);
            this.Controls.Add(this.TxtHeight);
            this.Controls.Add(this.TxtWidth);
            this.Controls.Add(this.TxtLength);
            this.Controls.Add(this.LblVolumeTitle);
            this.Name = "FrmRectangleVolume";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volume of Rectangle";
            this.Load += new System.EventHandler(this.FrmRectangleVolume_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblVolumeTitle;
        private System.Windows.Forms.TextBox TxtLength;
        private System.Windows.Forms.TextBox TxtWidth;
        private System.Windows.Forms.TextBox TxtHeight;
        private System.Windows.Forms.Label LblLength;
        private System.Windows.Forms.Label LblWidth;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.Button BtnGetVolume;
    }
}

