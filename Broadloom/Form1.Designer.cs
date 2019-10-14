namespace Broadloom
{
    partial class FrmBroadloom
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
            this.LblLength = new System.Windows.Forms.Label();
            this.LblWidth = new System.Windows.Forms.Label();
            this.TxtLength = new System.Windows.Forms.TextBox();
            this.TxtWidth = new System.Windows.Forms.TextBox();
            this.BtnTotal = new System.Windows.Forms.Button();
            this.LblSubTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblFormTitle
            // 
            this.LblFormTitle.AutoSize = true;
            this.LblFormTitle.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFormTitle.Location = new System.Drawing.Point(33, 57);
            this.LblFormTitle.Name = "LblFormTitle";
            this.LblFormTitle.Size = new System.Drawing.Size(402, 28);
            this.LblFormTitle.TabIndex = 0;
            this.LblFormTitle.Text = "Find the Cost of Broadloom";
            // 
            // LblLength
            // 
            this.LblLength.AutoSize = true;
            this.LblLength.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLength.ForeColor = System.Drawing.Color.LightCyan;
            this.LblLength.Location = new System.Drawing.Point(34, 176);
            this.LblLength.Name = "LblLength";
            this.LblLength.Size = new System.Drawing.Size(179, 20);
            this.LblLength.TabIndex = 1;
            this.LblLength.Text = "Enter The Length ";
            // 
            // LblWidth
            // 
            this.LblWidth.AutoSize = true;
            this.LblWidth.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWidth.ForeColor = System.Drawing.Color.LightCyan;
            this.LblWidth.Location = new System.Drawing.Point(34, 272);
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(159, 20);
            this.LblWidth.TabIndex = 2;
            this.LblWidth.Text = "Enter The Width";
            this.LblWidth.Click += new System.EventHandler(this.LblWidth_Click);
            // 
            // TxtLength
            // 
            this.TxtLength.Location = new System.Drawing.Point(310, 176);
            this.TxtLength.Name = "TxtLength";
            this.TxtLength.Size = new System.Drawing.Size(57, 22);
            this.TxtLength.TabIndex = 3;
            this.TxtLength.TextChanged += new System.EventHandler(this.TxtLength_TextChanged);
            // 
            // TxtWidth
            // 
            this.TxtWidth.Location = new System.Drawing.Point(310, 272);
            this.TxtWidth.Name = "TxtWidth";
            this.TxtWidth.Size = new System.Drawing.Size(57, 22);
            this.TxtWidth.TabIndex = 4;
            this.TxtWidth.TextChanged += new System.EventHandler(this.TxtWidth_TextChanged);
            // 
            // BtnTotal
            // 
            this.BtnTotal.Location = new System.Drawing.Point(148, 355);
            this.BtnTotal.Name = "BtnTotal";
            this.BtnTotal.Size = new System.Drawing.Size(137, 33);
            this.BtnTotal.TabIndex = 5;
            this.BtnTotal.Text = "Total";
            this.BtnTotal.UseVisualStyleBackColor = true;
            this.BtnTotal.Click += new System.EventHandler(this.BtnTotal_Click);
            // 
            // LblSubTitle
            // 
            this.LblSubTitle.AutoSize = true;
            this.LblSubTitle.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTitle.ForeColor = System.Drawing.Color.LightCyan;
            this.LblSubTitle.Location = new System.Drawing.Point(116, 96);
            this.LblSubTitle.Name = "LblSubTitle";
            this.LblSubTitle.Size = new System.Drawing.Size(219, 20);
            this.LblSubTitle.TabIndex = 6;
            this.LblSubTitle.Text = "$12 Per Square Meters";
            // 
            // FrmBroadloom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.LblSubTitle);
            this.Controls.Add(this.BtnTotal);
            this.Controls.Add(this.TxtWidth);
            this.Controls.Add(this.TxtLength);
            this.Controls.Add(this.LblWidth);
            this.Controls.Add(this.LblLength);
            this.Controls.Add(this.LblFormTitle);
            this.Name = "FrmBroadloom";
            this.Text = "Broadloom Cost";
            this.Load += new System.EventHandler(this.FrmBroadloom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFormTitle;
        private System.Windows.Forms.Label LblLength;
        private System.Windows.Forms.Label LblWidth;
        private System.Windows.Forms.TextBox TxtLength;
        private System.Windows.Forms.TextBox TxtWidth;
        private System.Windows.Forms.Button BtnTotal;
        private System.Windows.Forms.Label LblSubTitle;
    }
}

