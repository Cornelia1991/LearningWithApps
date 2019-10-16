namespace GasCompany
{
    partial class FrmGasCompany
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
            this.LblSubTitle = new System.Windows.Forms.Label();
            this.LblCcfAmount = new System.Windows.Forms.Label();
            this.TxtCcfAmount = new System.Windows.Forms.TextBox();
            this.BtnGetBill = new System.Windows.Forms.Button();
            this.LblSubLabel2 = new System.Windows.Forms.Label();
            this.LblKwh = new System.Windows.Forms.Label();
            this.TxtKwh = new System.Windows.Forms.TextBox();
            this.BtnKwh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblFormTitle
            // 
            this.LblFormTitle.AutoSize = true;
            this.LblFormTitle.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormTitle.Location = new System.Drawing.Point(288, 53);
            this.LblFormTitle.Name = "LblFormTitle";
            this.LblFormTitle.Size = new System.Drawing.Size(282, 30);
            this.LblFormTitle.TabIndex = 0;
            this.LblFormTitle.Text = "Calculate Your Gas Bill";
            // 
            // LblSubTitle
            // 
            this.LblSubTitle.AutoSize = true;
            this.LblSubTitle.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTitle.Location = new System.Drawing.Point(9, 123);
            this.LblSubTitle.Name = "LblSubTitle";
            this.LblSubTitle.Size = new System.Drawing.Size(338, 16);
            this.LblSubTitle.TabIndex = 1;
            this.LblSubTitle.Text = "First 8 ccf is 50 cents each addtional is 30 cents each";
            this.LblSubTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblCcfAmount
            // 
            this.LblCcfAmount.AutoSize = true;
            this.LblCcfAmount.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCcfAmount.Location = new System.Drawing.Point(50, 193);
            this.LblCcfAmount.Name = "LblCcfAmount";
            this.LblCcfAmount.Size = new System.Drawing.Size(188, 18);
            this.LblCcfAmount.TabIndex = 2;
            this.LblCcfAmount.Text = "Enter ccf used this month";
            // 
            // TxtCcfAmount
            // 
            this.TxtCcfAmount.Location = new System.Drawing.Point(103, 243);
            this.TxtCcfAmount.Name = "TxtCcfAmount";
            this.TxtCcfAmount.Size = new System.Drawing.Size(82, 22);
            this.TxtCcfAmount.TabIndex = 3;
            this.TxtCcfAmount.TextChanged += new System.EventHandler(this.TxtCcfAmount_TextChanged);
            // 
            // BtnGetBill
            // 
            this.BtnGetBill.Location = new System.Drawing.Point(86, 293);
            this.BtnGetBill.Name = "BtnGetBill";
            this.BtnGetBill.Size = new System.Drawing.Size(127, 34);
            this.BtnGetBill.TabIndex = 4;
            this.BtnGetBill.Text = "Get Bill";
            this.BtnGetBill.UseVisualStyleBackColor = true;
            this.BtnGetBill.Click += new System.EventHandler(this.BtnGetBill_Click);
            // 
            // LblSubLabel2
            // 
            this.LblSubLabel2.AutoSize = true;
            this.LblSubLabel2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubLabel2.Location = new System.Drawing.Point(415, 123);
            this.LblSubLabel2.Name = "LblSubLabel2";
            this.LblSubLabel2.Size = new System.Drawing.Size(407, 16);
            this.LblSubLabel2.TabIndex = 5;
            this.LblSubLabel2.Text = "First 12 kwh $2.80 | Next 78 kwh 8 cent | Excess 90 kwh 6 cent";
            this.LblSubLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblKwh
            // 
            this.LblKwh.AutoSize = true;
            this.LblKwh.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKwh.Location = new System.Drawing.Point(513, 193);
            this.LblKwh.Name = "LblKwh";
            this.LblKwh.Size = new System.Drawing.Size(196, 18);
            this.LblKwh.TabIndex = 6;
            this.LblKwh.Text = "Enter kwh used this month";
            // 
            // TxtKwh
            // 
            this.TxtKwh.Location = new System.Drawing.Point(589, 243);
            this.TxtKwh.Name = "TxtKwh";
            this.TxtKwh.Size = new System.Drawing.Size(81, 22);
            this.TxtKwh.TabIndex = 7;
            this.TxtKwh.TextChanged += new System.EventHandler(this.TxtKwh_TextChanged);
            // 
            // BtnKwh
            // 
            this.BtnKwh.Location = new System.Drawing.Point(569, 293);
            this.BtnKwh.Name = "BtnKwh";
            this.BtnKwh.Size = new System.Drawing.Size(127, 34);
            this.BtnKwh.TabIndex = 8;
            this.BtnKwh.Text = "Get Bill";
            this.BtnKwh.UseVisualStyleBackColor = true;
            this.BtnKwh.Click += new System.EventHandler(this.BtnKwh_Click);
            // 
            // FrmGasCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.BtnKwh);
            this.Controls.Add(this.TxtKwh);
            this.Controls.Add(this.LblKwh);
            this.Controls.Add(this.LblSubLabel2);
            this.Controls.Add(this.BtnGetBill);
            this.Controls.Add(this.TxtCcfAmount);
            this.Controls.Add(this.LblCcfAmount);
            this.Controls.Add(this.LblSubTitle);
            this.Controls.Add(this.LblFormTitle);
            this.Name = "FrmGasCompany";
            this.Text = "Gas Company";
            this.Load += new System.EventHandler(this.FrmGasCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFormTitle;
        private System.Windows.Forms.Label LblSubTitle;
        private System.Windows.Forms.Label LblCcfAmount;
        private System.Windows.Forms.TextBox TxtCcfAmount;
        private System.Windows.Forms.Button BtnGetBill;
        private System.Windows.Forms.Label LblSubLabel2;
        private System.Windows.Forms.Label LblKwh;
        private System.Windows.Forms.TextBox TxtKwh;
        private System.Windows.Forms.Button BtnKwh;
    }
}

