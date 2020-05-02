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
            this.validaterings = new System.Windows.Forms.Button();
            this.Onderwerp = new System.Windows.Forms.TextBox();
            this.stuurVraagHulp = new System.Windows.Forms.RichTextBox();
            this.Verstuur = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Eigenvraag
            // 
            this.Eigenvraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eigenvraag.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Eigenvraag.Location = new System.Drawing.Point(34, 214);
            this.Eigenvraag.Margin = new System.Windows.Forms.Padding(2);
            this.Eigenvraag.Name = "Eigenvraag";
            this.Eigenvraag.Size = new System.Drawing.Size(487, 160);
            this.Eigenvraag.TabIndex = 16;
            this.Eigenvraag.Text = "Uw vraag";
            this.Eigenvraag.Click += new System.EventHandler(this.Eigenvraag_Clicked);
            this.Eigenvraag.TextChanged += new System.EventHandler(this.Eigenvraag_TextChanged);
            this.Eigenvraag.Leave += new System.EventHandler(this.Eigenvraag_Leave);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(34, 95);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(487, 32);
            this.Email.TabIndex = 15;
            this.Email.Text = "Email Adres";
            this.Email.Click += new System.EventHandler(this.Email_Clicked);
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // Achternaam
            // 
            this.Achternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Achternaam.Location = new System.Drawing.Point(288, 37);
            this.Achternaam.Margin = new System.Windows.Forms.Padding(2);
            this.Achternaam.Name = "Achternaam";
            this.Achternaam.Size = new System.Drawing.Size(233, 32);
            this.Achternaam.TabIndex = 14;
            this.Achternaam.Text = "Achternaam";
            this.Achternaam.Click += new System.EventHandler(this.Achternaam_Clicked);
            this.Achternaam.TextChanged += new System.EventHandler(this.Achternaam_TextChanged);
            this.Achternaam.Leave += new System.EventHandler(this.Achternaam_Leave);
            // 
            // Voornaam
            // 
            this.Voornaam.BackColor = System.Drawing.Color.White;
            this.Voornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voornaam.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Voornaam.Location = new System.Drawing.Point(34, 37);
            this.Voornaam.Margin = new System.Windows.Forms.Padding(2);
            this.Voornaam.Name = "Voornaam";
            this.Voornaam.Size = new System.Drawing.Size(224, 32);
            this.Voornaam.TabIndex = 13;
            this.Voornaam.Text = "Voornaam";
            this.Voornaam.Click += new System.EventHandler(this.Voornaam_Clicked);
            this.Voornaam.TextChanged += new System.EventHandler(this.Voornaam_TextChanged);
            this.Voornaam.Leave += new System.EventHandler(this.Voornaam_Leave);
            // 
            // validaterings
            // 
            this.validaterings.BackColor = System.Drawing.Color.White;
            this.validaterings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validaterings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validaterings.Location = new System.Drawing.Point(243, 435);
            this.validaterings.Margin = new System.Windows.Forms.Padding(2);
            this.validaterings.Name = "validaterings";
            this.validaterings.Size = new System.Drawing.Size(33, 32);
            this.validaterings.TabIndex = 11;
            this.validaterings.UseVisualStyleBackColor = false;
            this.validaterings.Click += new System.EventHandler(this.validaterings_Click_1);
            // 
            // Onderwerp
            // 
            this.Onderwerp.BackColor = System.Drawing.Color.White;
            this.Onderwerp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Onderwerp.Location = new System.Drawing.Point(34, 155);
            this.Onderwerp.Margin = new System.Windows.Forms.Padding(2);
            this.Onderwerp.Name = "Onderwerp";
            this.Onderwerp.Size = new System.Drawing.Size(487, 32);
            this.Onderwerp.TabIndex = 19;
            this.Onderwerp.Text = "Onderwerp";
            this.Onderwerp.Click += new System.EventHandler(this.Onderwerp_Click);
            this.Onderwerp.TextChanged += new System.EventHandler(this.Onderwerp_TextChanged);
            this.Onderwerp.Leave += new System.EventHandler(this.Onderwerp_Leave);
            // 
            // stuurVraagHulp
            // 
            this.stuurVraagHulp.BackColor = System.Drawing.Color.White;
            this.stuurVraagHulp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stuurVraagHulp.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuurVraagHulp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.stuurVraagHulp.Location = new System.Drawing.Point(546, 30);
            this.stuurVraagHulp.Margin = new System.Windows.Forms.Padding(4);
            this.stuurVraagHulp.Name = "stuurVraagHulp";
            this.stuurVraagHulp.ReadOnly = true;
            this.stuurVraagHulp.Size = new System.Drawing.Size(533, 464);
            this.stuurVraagHulp.TabIndex = 20;
            this.stuurVraagHulp.Text = resources.GetString("stuurVraagHulp.Text");
            // 
            // Verstuur
            // 
            this.Verstuur.Enabled = false;
            this.Verstuur.Image = global::EersteProjectMau.Properties.Resources.send_false;
            this.Verstuur.Location = new System.Drawing.Point(34, 408);
            this.Verstuur.Margin = new System.Windows.Forms.Padding(2);
            this.Verstuur.Name = "Verstuur";
            this.Verstuur.Size = new System.Drawing.Size(167, 86);
            this.Verstuur.TabIndex = 12;
            this.Verstuur.UseVisualStyleBackColor = true;
            this.Verstuur.Click += new System.EventHandler(this.Verstuur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EersteProjectMau.Properties.Resources.geenrobot;
            this.pictureBox1.Location = new System.Drawing.Point(230, 409);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // StuurVraagFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1105, 537);
            this.Controls.Add(this.stuurVraagHulp);
            this.Controls.Add(this.Onderwerp);
            this.Controls.Add(this.validaterings);
            this.Controls.Add(this.Eigenvraag);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Achternaam);
            this.Controls.Add(this.Voornaam);
            this.Controls.Add(this.Verstuur);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox Onderwerp;
        private System.Windows.Forms.RichTextBox stuurVraagHulp;
    }
}