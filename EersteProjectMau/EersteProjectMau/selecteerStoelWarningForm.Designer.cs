﻿namespace EersteProjectMau
{
    partial class selecteerStoelWarningForm
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
            this.LabelKiesBankWarning = new System.Windows.Forms.Label();
            this.buttonBankWarningVerder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelKiesBankWarning
            // 
            this.LabelKiesBankWarning.AutoSize = true;
            this.LabelKiesBankWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelKiesBankWarning.Location = new System.Drawing.Point(39, 33);
            this.LabelKiesBankWarning.Name = "LabelKiesBankWarning";
            this.LabelKiesBankWarning.Size = new System.Drawing.Size(423, 110);
            this.LabelKiesBankWarning.TabIndex = 86;
            this.LabelKiesBankWarning.Text = "Kies uw stoelen\r\nvoor U verder gaat";
            // 
            // buttonBankWarningVerder
            // 
            this.buttonBankWarningVerder.Location = new System.Drawing.Point(168, 202);
            this.buttonBankWarningVerder.Name = "buttonBankWarningVerder";
            this.buttonBankWarningVerder.Size = new System.Drawing.Size(164, 56);
            this.buttonBankWarningVerder.TabIndex = 85;
            this.buttonBankWarningVerder.Text = "Oké";
            this.buttonBankWarningVerder.UseVisualStyleBackColor = true;
            this.buttonBankWarningVerder.Click += new System.EventHandler(this.buttonBankWarningVerder_Click);
            // 
            // selecteerStoelWarningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 270);
            this.Controls.Add(this.LabelKiesBankWarning);
            this.Controls.Add(this.buttonBankWarningVerder);
            this.Name = "selecteerStoelWarningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelKiesBankWarning;
        private System.Windows.Forms.Button buttonBankWarningVerder;
    }
}