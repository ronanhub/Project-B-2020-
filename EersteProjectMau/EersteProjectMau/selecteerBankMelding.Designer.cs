namespace EersteProjectMau
{
    partial class selecteerBankMelding
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
            this.buttonSelecteerBankMeldingVerder = new System.Windows.Forms.Button();
            this.labelSelecteerBankMelding = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSelecteerBankMeldingVerder
            // 
            this.buttonSelecteerBankMeldingVerder.Location = new System.Drawing.Point(223, 232);
            this.buttonSelecteerBankMeldingVerder.Name = "buttonSelecteerBankMeldingVerder";
            this.buttonSelecteerBankMeldingVerder.Size = new System.Drawing.Size(130, 58);
            this.buttonSelecteerBankMeldingVerder.TabIndex = 0;
            this.buttonSelecteerBankMeldingVerder.Text = "Verder";
            this.buttonSelecteerBankMeldingVerder.UseVisualStyleBackColor = true;
            this.buttonSelecteerBankMeldingVerder.Click += new System.EventHandler(this.buttonSelecteerBankMeldingVerder_Click);
            // 
            // labelSelecteerBankMelding
            // 
            this.labelSelecteerBankMelding.AutoSize = true;
            this.labelSelecteerBankMelding.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelecteerBankMelding.Location = new System.Drawing.Point(166, 122);
            this.labelSelecteerBankMelding.Name = "labelSelecteerBankMelding";
            this.labelSelecteerBankMelding.Size = new System.Drawing.Size(247, 62);
            this.labelSelecteerBankMelding.TabIndex = 1;
            this.labelSelecteerBankMelding.Text = "Selecteer een bank\r\nvoor u verder gaat";
            // 
            // selecteerBankMelding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 314);
            this.Controls.Add(this.labelSelecteerBankMelding);
            this.Controls.Add(this.buttonSelecteerBankMeldingVerder);
            this.Name = "selecteerBankMelding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelecteerBankMeldingVerder;
        private System.Windows.Forms.Label labelSelecteerBankMelding;
    }
}