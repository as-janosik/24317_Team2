﻿ namespace MaintenanceTracker
{
    partial class OilOptionsForm
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
            this.Options = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.TrackBar();
            this.Lock = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.RichTextBox();
            this.brand = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.oilBrand = new System.Windows.Forms.TextBox();
            this.oilUse = new System.Windows.Forms.TextBox();
            this.TotalTxT = new System.Windows.Forms.TextBox();
            this.AmountTotal = new System.Windows.Forms.TextBox();
            this.GYRTXT = new System.Windows.Forms.TextBox();
            this.GYR = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // Option button
            // 
            this.Options.Location = new System.Drawing.Point(210, 360);
            this.Options.Name = "options";
            this.Options.Size = new System.Drawing.Size(117, 51);
            this.Options.TabIndex = 0;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = true;
            // 
            // Exit button
            // 
            this.Exit.Location = new System.Drawing.Point(210, 303);
            this.Exit.Name = "exit";
            this.Exit.Size = new System.Drawing.Size(117, 51);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.exit);
            // 
            // trackBar oil amount
            // 
            this.Amount.Location = new System.Drawing.Point(0, 243);
            this.Amount.Name = "amount";
            this.Amount.Size = new System.Drawing.Size(253, 45);
            this.Amount.Maximum = 60;
            this.Amount.Scroll += new System.EventHandler(this.FindNumber);
            // 
            // Lock button
            // 
            this.Lock.Location = new System.Drawing.Point(259, 243);
            this.Lock.Name = "lockButton";
            this.Lock.Size = new System.Drawing.Size(68, 35);
            this.Lock.TabIndex = 3;
            this.Lock.Text = "Lock";
            this.Lock.UseVisualStyleBackColor = true;
            this.Lock.Click += new System.EventHandler(this.LockScoll);
            // 
            // Information TxT
            // 
            this.Information.Location = new System.Drawing.Point(12, 300);
            this.Information.Name = "richTextBox1";
            this.Information.Size = new System.Drawing.Size(180, 100);
            this.Information.TabIndex = 4;
            this.Information.Text = "";
            this.Information.ReadOnly = true;
            // 
            // Brand of oil using
            // 
            this.brand.Location = new System.Drawing.Point(12, 89);
            this.brand.Name = "brandOfOil";
            this.brand.Text = "Brand of oil using";
            this.brand.Size = new System.Drawing.Size(130, 20);
            this.brand.TabIndex = 8;
            this.brand.ReadOnly = true;
            //
            // brand
            //
            this.oilBrand.Location = new System.Drawing.Point(150, 89);
            this.oilBrand.Name = "brand";
            this.oilBrand.Text = "";
            this.oilBrand.Size = new System.Drawing.Size(130, 20);
            this.oilBrand.TabIndex = 8;
            this.oilBrand.TextChanged += new System.EventHandler(this.oilBrandChange);
            // 
            // Type of oil using
            // 
            this.type.Location = new System.Drawing.Point(12, 128);
            this.type.Name = "oilType";
            this.type.Text = "Type of oil using";
            this.type.Size = new System.Drawing.Size(130, 20);
            this.type.TabIndex = 8;
            this.type.ReadOnly = true;
            //
            // oil
            //
            this.oilUse.Location = new System.Drawing.Point(150, 128);
            this.oilUse.Name = "brand";
            this.oilUse.Text = "";
            this.oilUse.Size = new System.Drawing.Size(130, 20);
            this.oilUse.TabIndex = 8;
            this.oilUse.TextChanged += new System.EventHandler(this.oilUseChange);
            // 
            // 
            // Oil Amount Text
            // 
            this.TotalTxT.Location = new System.Drawing.Point(12, 192);
            this.TotalTxT.Name = "OilAmount";
            this.TotalTxT.Text = "Oil Amount";
            this.TotalTxT.Size = new System.Drawing.Size(166, 20);
            this.TotalTxT.TabIndex = 6;
            this.TotalTxT.ReadOnly = true;
            // 
            // Oil Amount Total
            // 
            this.AmountTotal.Location = new System.Drawing.Point(210, 192);
            this.AmountTotal.Name = "AmountTxT";
            this.AmountTotal.Size = new System.Drawing.Size(74, 10);
            this.AmountTotal.TabIndex = 7;
            this.AmountTotal.TextChanged += new System.EventHandler(this.TotalChange);
            //
            // Time to change or not
            //  
            this.GYR.Location = new System.Drawing.Point(7, 12);
            this.GYR.Name = "GYR_Bar";
            this.GYR.Size = new System.Drawing.Size(320, 40);
            //
            // Time to change or not TXT
            // 
            this.GYRTXT.Location = new System.Drawing.Point(7, 50);
            this.GYRTXT.Name = "GYR_Txt";
            this.GYRTXT.Text = "GOOD";
            this.GYRTXT.Size = new System.Drawing.Size(320, 500);
            this.GYRTXT.ReadOnly = true;
            //
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 423);
            this.Controls.Add(this.GYR);
            this.Controls.Add(this.GYRTXT);
            this.Controls.Add(this.type);
            this.Controls.Add(this.oilUse);
            this.Controls.Add(this.AmountTotal);
            this.Controls.Add(this.TotalTxT);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.oilBrand);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.Lock);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Options);
            this.Name = "oil Form";
            this.Text = "Oil Options Form";
            this.Load += new System.EventHandler(this.OilTrackerForm);
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TrackBar Amount;
        private System.Windows.Forms.Button Lock;
        private System.Windows.Forms.RichTextBox Information;
        private System.Windows.Forms.TextBox brand;
        private System.Windows.Forms.TextBox TotalTxT;
        private System.Windows.Forms.TextBox oilBrand;
        private System.Windows.Forms.TextBox oilUse;
        private System.Windows.Forms.TextBox AmountTotal;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox GYRTXT;
        private System.Windows.Forms.ProgressBar GYR;

    }
}

