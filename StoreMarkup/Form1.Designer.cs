namespace StoreMarkup
{
    partial class FrmMarkup
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
            this.LblCost = new System.Windows.Forms.Label();
            this.LblSellPrice = new System.Windows.Forms.Label();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.TxtSellPrice = new System.Windows.Forms.TextBox();
            this.BtnMarkup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblFormTitle
            // 
            this.LblFormTitle.AutoSize = true;
            this.LblFormTitle.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormTitle.ForeColor = System.Drawing.Color.Crimson;
            this.LblFormTitle.Location = new System.Drawing.Point(127, 94);
            this.LblFormTitle.Name = "LblFormTitle";
            this.LblFormTitle.Size = new System.Drawing.Size(344, 29);
            this.LblFormTitle.TabIndex = 0;
            this.LblFormTitle.Text = "Percentage Markup For Store Item";
            // 
            // LblCost
            // 
            this.LblCost.AutoSize = true;
            this.LblCost.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCost.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.LblCost.Location = new System.Drawing.Point(129, 183);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(159, 20);
            this.LblCost.TabIndex = 1;
            this.LblCost.Text = "Enter the Cost:";
            this.LblCost.Click += new System.EventHandler(this.LblCost_Click);
            // 
            // LblSellPrice
            // 
            this.LblSellPrice.AutoSize = true;
            this.LblSellPrice.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSellPrice.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.LblSellPrice.Location = new System.Drawing.Point(129, 248);
            this.LblSellPrice.Name = "LblSellPrice";
            this.LblSellPrice.Size = new System.Drawing.Size(239, 20);
            this.LblSellPrice.TabIndex = 2;
            this.LblSellPrice.Text = "Enter the Selling Price";
            // 
            // TxtCost
            // 
            this.TxtCost.Location = new System.Drawing.Point(401, 183);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(84, 22);
            this.TxtCost.TabIndex = 3;
            this.TxtCost.TextChanged += new System.EventHandler(this.TxtCost_TextChanged);
            // 
            // TxtSellPrice
            // 
            this.TxtSellPrice.Location = new System.Drawing.Point(401, 249);
            this.TxtSellPrice.Name = "TxtSellPrice";
            this.TxtSellPrice.Size = new System.Drawing.Size(84, 22);
            this.TxtSellPrice.TabIndex = 4;
            this.TxtSellPrice.TextChanged += new System.EventHandler(this.TxtSellPrice_TextChanged);
            // 
            // BtnMarkup
            // 
            this.BtnMarkup.BackColor = System.Drawing.Color.Fuchsia;
            this.BtnMarkup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarkup.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtnMarkup.Location = new System.Drawing.Point(248, 331);
            this.BtnMarkup.Name = "BtnMarkup";
            this.BtnMarkup.Size = new System.Drawing.Size(137, 42);
            this.BtnMarkup.TabIndex = 5;
            this.BtnMarkup.Text = "MARKUP";
            this.BtnMarkup.UseVisualStyleBackColor = false;
            this.BtnMarkup.Click += new System.EventHandler(this.BtnMarkup_Click);
            // 
            // FrmMarkup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.BtnMarkup);
            this.Controls.Add(this.TxtSellPrice);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.LblSellPrice);
            this.Controls.Add(this.LblCost);
            this.Controls.Add(this.LblFormTitle);
            this.Name = "FrmMarkup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pertentage Markup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFormTitle;
        private System.Windows.Forms.Label LblCost;
        private System.Windows.Forms.Label LblSellPrice;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.TextBox TxtSellPrice;
        private System.Windows.Forms.Button BtnMarkup;
    }
}

