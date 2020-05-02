namespace EersteProjectMau
{
    partial class StuurVraagFormcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuurVraagFormcs));
            this.Eigenvraag = new System.Windows.Forms.RichTextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Achternaam = new System.Windows.Forms.TextBox();
            this.Voornaam = new System.Windows.Forms.TextBox();
            this.Verstuur = new System.Windows.Forms.Button();
            this.validaterings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Eigenvraag
            // 
            this.Eigenvraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eigenvraag.Location = new System.Drawing.Point(45, 133);
            this.Eigenvraag.Name = "Eigenvraag";
            this.Eigenvraag.Size = new System.Drawing.Size(388, 150);
            this.Eigenvraag.TabIndex = 16;
            this.Eigenvraag.Text = "Uw vraag";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(45, 87);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(388, 27);
            this.Email.TabIndex = 15;
            this.Email.Text = "Email Adres";
            
            // 
            // Achternaam
            // 
            this.Achternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Achternaam.Location = new System.Drawing.Point(253, 45);
            this.Achternaam.Name = "Achternaam";
            this.Achternaam.Size = new System.Drawing.Size(180, 27);
            this.Achternaam.TabIndex = 14;
            this.Achternaam.Text = "Achternaam";
            // 
            // Voornaam
            // 
            this.Voornaam.BackColor = System.Drawing.Color.White;
            this.Voornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voornaam.Location = new System.Drawing.Point(45, 45);
            this.Voornaam.Name = "Voornaam";
            this.Voornaam.Size = new System.Drawing.Size(177, 27);
            this.Voornaam.TabIndex = 13;
            this.Voornaam.Text = "Voornaam";
            // 
            // Verstuur
            // 
            this.Verstuur.Enabled = false;
            this.Verstuur.Location = new System.Drawing.Point(45, 308);
            this.Verstuur.Name = "Verstuur";
            this.Verstuur.Size = new System.Drawing.Size(157, 60);
            this.Verstuur.TabIndex = 12;
            this.Verstuur.Text = "Verstuur";
            this.Verstuur.UseVisualStyleBackColor = true;
            this.Verstuur.Click += new System.EventHandler(this.Verstuur_Click_1);
            // 
            // validaterings
            // 
            this.validaterings.BackColor = System.Drawing.Color.White;
            this.validaterings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validaterings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validaterings.Location = new System.Drawing.Point(261, 329);
            this.validaterings.Name = "validaterings";
            this.validaterings.Size = new System.Drawing.Size(32, 31);
            this.validaterings.TabIndex = 11;
            this.validaterings.UseVisualStyleBackColor = false;
            this.validaterings.Click += new System.EventHandler(this.validaterings_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // StuurVraagFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 409);
            this.Controls.Add(this.Eigenvraag);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Achternaam);
            this.Controls.Add(this.Voornaam);
            this.Controls.Add(this.Verstuur);
            this.Controls.Add(this.validaterings);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StuurVraagFormcs";
            this.Text = "StuurVraagFormcs";
            this.Load += new System.EventHandler(this.StuurVraagFormcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Eigenvraag;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Achternaam;
        private System.Windows.Forms.TextBox Voornaam;
        private System.Windows.Forms.Button Verstuur;
        private System.Windows.Forms.Button validaterings;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}