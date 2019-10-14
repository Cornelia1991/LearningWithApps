namespace ColdCuts
{
    partial class FrmColdCuts
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
            this.LblTurkey = new System.Windows.Forms.Label();
            this.LblHam = new System.Windows.Forms.Label();
            this.LblTuna = new System.Windows.Forms.Label();
            this.TxtTurky = new System.Windows.Forms.TextBox();
            this.TxtHam = new System.Windows.Forms.TextBox();
            this.TxtTuna = new System.Windows.Forms.TextBox();
            this.BtnTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblFormTitle
            // 
            this.LblFormTitle.AutoSize = true;
            this.LblFormTitle.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LblFormTitle.Location = new System.Drawing.Point(84, 47);
            this.LblFormTitle.Name = "LblFormTitle";
            this.LblFormTitle.Size = new System.Drawing.Size(370, 32);
            this.LblFormTitle.TabIndex = 0;
            this.LblFormTitle.Text = "Get Cold Cuts By The Pound";
            // 
            // LblTurkey
            // 
            this.LblTurkey.AutoSize = true;
            this.LblTurkey.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTurkey.ForeColor = System.Drawing.Color.Navy;
            this.LblTurkey.Location = new System.Drawing.Point(53, 151);
            this.LblTurkey.Name = "LblTurkey";
            this.LblTurkey.Size = new System.Drawing.Size(194, 24);
            this.LblTurkey.TabIndex = 1;
            this.LblTurkey.Text = "Turkey $3.25/pound";
            // 
            // LblHam
            // 
            this.LblHam.AutoSize = true;
            this.LblHam.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHam.ForeColor = System.Drawing.Color.Navy;
            this.LblHam.Location = new System.Drawing.Point(53, 212);
            this.LblHam.Name = "LblHam";
            this.LblHam.Size = new System.Drawing.Size(177, 24);
            this.LblHam.TabIndex = 2;
            this.LblHam.Text = "Ham $3.00/pound";
            // 
            // LblTuna
            // 
            this.LblTuna.AutoSize = true;
            this.LblTuna.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTuna.ForeColor = System.Drawing.Color.Navy;
            this.LblTuna.Location = new System.Drawing.Point(53, 276);
            this.LblTuna.Name = "LblTuna";
            this.LblTuna.Size = new System.Drawing.Size(178, 24);
            this.LblTuna.TabIndex = 3;
            this.LblTuna.Text = "Tuna $3.60/pound";
            // 
            // TxtTurky
            // 
            this.TxtTurky.Location = new System.Drawing.Point(307, 151);
            this.TxtTurky.Name = "TxtTurky";
            this.TxtTurky.Size = new System.Drawing.Size(117, 22);
            this.TxtTurky.TabIndex = 4;
            this.TxtTurky.TextChanged += new System.EventHandler(this.TxtTurky_TextChanged);
            // 
            // TxtHam
            // 
            this.TxtHam.Location = new System.Drawing.Point(307, 215);
            this.TxtHam.Name = "TxtHam";
            this.TxtHam.Size = new System.Drawing.Size(117, 22);
            this.TxtHam.TabIndex = 5;
            this.TxtHam.TextChanged += new System.EventHandler(this.TxtHam_TextChanged);
            // 
            // TxtTuna
            // 
            this.TxtTuna.Location = new System.Drawing.Point(307, 288);
            this.TxtTuna.Name = "TxtTuna";
            this.TxtTuna.Size = new System.Drawing.Size(117, 22);
            this.TxtTuna.TabIndex = 6;
            this.TxtTuna.TextChanged += new System.EventHandler(this.TxtTuna_TextChanged);
            // 
            // BtnTotal
            // 
            this.BtnTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnTotal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnTotal.FlatAppearance.BorderSize = 0;
            this.BtnTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnTotal.Location = new System.Drawing.Point(160, 364);
            this.BtnTotal.Name = "BtnTotal";
            this.BtnTotal.Size = new System.Drawing.Size(178, 37);
            this.BtnTotal.TabIndex = 7;
            this.BtnTotal.Text = "GetTotal";
            this.BtnTotal.UseVisualStyleBackColor = false;
            this.BtnTotal.Click += new System.EventHandler(this.BtnTotal_Click);
            // 
            // FrmColdCuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.BtnTotal);
            this.Controls.Add(this.TxtTuna);
            this.Controls.Add(this.TxtHam);
            this.Controls.Add(this.TxtTurky);
            this.Controls.Add(this.LblTuna);
            this.Controls.Add(this.LblHam);
            this.Controls.Add(this.LblTurkey);
            this.Controls.Add(this.LblFormTitle);
            this.Name = "FrmColdCuts";
            this.Text = "Cold Cuts Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFormTitle;
        private System.Windows.Forms.Label LblTurkey;
        private System.Windows.Forms.Label LblHam;
        private System.Windows.Forms.Label LblTuna;
        private System.Windows.Forms.TextBox TxtTurky;
        private System.Windows.Forms.TextBox TxtHam;
        private System.Windows.Forms.TextBox TxtTuna;
        private System.Windows.Forms.Button BtnTotal;
    }
}

