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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuurVraagFormcs));
            this.stuurVraagHulp = new System.Windows.Forms.RichTextBox();
            this.Onderwerp = new System.Windows.Forms.TextBox();
            this.validaterings = new System.Windows.Forms.Button();
            this.Eigenvraag = new System.Windows.Forms.RichTextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Achternaam = new System.Windows.Forms.TextBox();
            this.Voornaam = new System.Windows.Forms.TextBox();
            this.Verstuur = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // stuurVraagHulp
            // 
            this.stuurVraagHulp.BackColor = System.Drawing.Color.White;
            this.stuurVraagHulp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stuurVraagHulp.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuurVraagHulp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.stuurVraagHulp.Location = new System.Drawing.Point(697, 22);
            this.stuurVraagHulp.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.stuurVraagHulp.Name = "stuurVraagHulp";
            this.stuurVraagHulp.ReadOnly = true;
            this.stuurVraagHulp.Size = new System.Drawing.Size(709, 570);
            this.stuurVraagHulp.TabIndex = 29;
            this.stuurVraagHulp.Text = resources.GetString("stuurVraagHulp.Text");
            // 
            // Onderwerp
            // 
            this.Onderwerp.BackColor = System.Drawing.Color.White;
            this.Onderwerp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Onderwerp.Location = new System.Drawing.Point(15, 176);
            this.Onderwerp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Onderwerp.Name = "Onderwerp";
            this.Onderwerp.Size = new System.Drawing.Size(629, 38);
            this.Onderwerp.TabIndex = 28;
            this.Onderwerp.Text = "Onderwerp";
            this.Onderwerp.Click += new System.EventHandler(this.Onderwerp_Click);
            this.Onderwerp.TextChanged += new System.EventHandler(this.Onderwerp_TextChanged);
            this.Onderwerp.Leave += new System.EventHandler(this.Onderwerp_Leave);
            // 
            // validaterings
            // 
            this.validaterings.BackColor = System.Drawing.Color.White;
            this.validaterings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validaterings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validaterings.Location = new System.Drawing.Point(287, 521);
            this.validaterings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validaterings.Name = "validaterings";
            this.validaterings.Size = new System.Drawing.Size(44, 39);
            this.validaterings.TabIndex = 21;
            this.validaterings.UseVisualStyleBackColor = false;
            this.validaterings.Click += new System.EventHandler(this.validaterings_Click);
            // 
            // Eigenvraag
            // 
            this.Eigenvraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eigenvraag.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Eigenvraag.Location = new System.Drawing.Point(15, 249);
            this.Eigenvraag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Eigenvraag.Name = "Eigenvraag";
            this.Eigenvraag.Size = new System.Drawing.Size(629, 196);
            this.Eigenvraag.TabIndex = 26;
            this.Eigenvraag.Text = "Uw vraag";
            this.Eigenvraag.Click += new System.EventHandler(this.Eigenvraag_Click);
            this.Eigenvraag.TextChanged += new System.EventHandler(this.Eigenvraag_TextChanged);
            this.Eigenvraag.Leave += new System.EventHandler(this.Eigenvraag_Leave);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(15, 102);
            this.Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(629, 38);
            this.Email.TabIndex = 25;
            this.Email.Text = "Email Adres";
<<<<<<< HEAD
            
=======
            this.Email.Click += new System.EventHandler(this.Email_Click);
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
>>>>>>> master
            // 
            // Achternaam
            // 
            this.Achternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Achternaam.Location = new System.Drawing.Point(353, 31);
            this.Achternaam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Achternaam.Name = "Achternaam";
            this.Achternaam.Size = new System.Drawing.Size(291, 38);
            this.Achternaam.TabIndex = 24;
            this.Achternaam.Text = "Achternaam";
            this.Achternaam.Click += new System.EventHandler(this.Achternaam_Click);
            this.Achternaam.TextChanged += new System.EventHandler(this.Achternaam_TextChanged);
            this.Achternaam.Leave += new System.EventHandler(this.Achternaam_Leave);
            // 
            // Voornaam
            // 
            this.Voornaam.BackColor = System.Drawing.Color.White;
            this.Voornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voornaam.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Voornaam.Location = new System.Drawing.Point(15, 31);
            this.Voornaam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Voornaam.Name = "Voornaam";
            this.Voornaam.Size = new System.Drawing.Size(297, 38);
            this.Voornaam.TabIndex = 23;
            this.Voornaam.Text = "Voornaam";
            this.Voornaam.Click += new System.EventHandler(this.Voornaam_Click);
            this.Voornaam.TextChanged += new System.EventHandler(this.Voornaam_TextChanged);
            this.Voornaam.Leave += new System.EventHandler(this.Voornaam_Leave);
            // 
            // Verstuur
            // 
            this.Verstuur.Enabled = false;
            this.Verstuur.Image = global::EersteProjectMau.Properties.Resources.send_false;
            this.Verstuur.Location = new System.Drawing.Point(15, 487);
            this.Verstuur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Verstuur.Name = "Verstuur";
            this.Verstuur.Size = new System.Drawing.Size(223, 106);
            this.Verstuur.TabIndex = 22;
            this.Verstuur.UseVisualStyleBackColor = true;
            this.Verstuur.Click += new System.EventHandler(this.Verstuur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EersteProjectMau.Properties.Resources.geenrobot;
            this.pictureBox1.Location = new System.Drawing.Point(276, 489);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.BlinkRate = 500;
            this.errorProviderEmail.ContainerControl = this;
            // 
            // StuurVraagFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1437, 638);
            this.Controls.Add(this.stuurVraagHulp);
            this.Controls.Add(this.Onderwerp);
            this.Controls.Add(this.validaterings);
            this.Controls.Add(this.Eigenvraag);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Achternaam);
            this.Controls.Add(this.Voornaam);
            this.Controls.Add(this.Verstuur);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StuurVraagFormcs";
            this.Text = "StuurVraagFormcs";
            this.Load += new System.EventHandler(this.StuurVraagFormcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox stuurVraagHulp;
        private System.Windows.Forms.TextBox Onderwerp;
        private System.Windows.Forms.Button validaterings;
        private System.Windows.Forms.RichTextBox Eigenvraag;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Achternaam;
        private System.Windows.Forms.TextBox Voornaam;
        private System.Windows.Forms.Button Verstuur;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
    }
}