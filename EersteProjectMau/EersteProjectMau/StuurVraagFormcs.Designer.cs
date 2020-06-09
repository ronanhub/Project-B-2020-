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
            this.Uwvraaglabel = new System.Windows.Forms.Label();
            this.Onderwerplabel = new System.Windows.Forms.Label();
            this.Emailadreslabel = new System.Windows.Forms.Label();
            this.Voornaamlabel = new System.Windows.Forms.Label();
            this.Acthernaamlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.stuurVraagHulp.Location = new System.Drawing.Point(629, 46);
            this.stuurVraagHulp.Margin = new System.Windows.Forms.Padding(4);
            this.stuurVraagHulp.Name = "stuurVraagHulp";
            this.stuurVraagHulp.ReadOnly = true;
            this.stuurVraagHulp.Size = new System.Drawing.Size(533, 254);
            this.stuurVraagHulp.TabIndex = 29;
            this.stuurVraagHulp.Text = resources.GetString("stuurVraagHulp.Text");
            // 
            // Onderwerp
            // 
            this.Onderwerp.BackColor = System.Drawing.Color.White;
            this.Onderwerp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Onderwerp.ForeColor = System.Drawing.Color.Gray;
            this.Onderwerp.Location = new System.Drawing.Point(49, 186);
            this.Onderwerp.Margin = new System.Windows.Forms.Padding(2);
            this.Onderwerp.Name = "Onderwerp";
            this.Onderwerp.Size = new System.Drawing.Size(537, 32);
            this.Onderwerp.TabIndex = 28;
            this.Onderwerp.Text = "Vul hier het onderwerp van uw vraag in";
            this.Onderwerp.Click += new System.EventHandler(this.Onderwerp_Click);
            this.Onderwerp.TextChanged += new System.EventHandler(this.Onderwerp_TextChanged);
            this.Onderwerp.Leave += new System.EventHandler(this.Onderwerp_Leave);
            // 
            // validaterings
            // 
            this.validaterings.BackColor = System.Drawing.Color.White;
            this.validaterings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validaterings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validaterings.Location = new System.Drawing.Point(882, 370);
            this.validaterings.Margin = new System.Windows.Forms.Padding(2);
            this.validaterings.Name = "validaterings";
            this.validaterings.Size = new System.Drawing.Size(33, 32);
            this.validaterings.TabIndex = 21;
            this.validaterings.UseVisualStyleBackColor = false;
            this.validaterings.Click += new System.EventHandler(this.validaterings_Click);
            // 
            // Eigenvraag
            // 
            this.Eigenvraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eigenvraag.ForeColor = System.Drawing.Color.Gray;
            this.Eigenvraag.Location = new System.Drawing.Point(49, 260);
            this.Eigenvraag.Margin = new System.Windows.Forms.Padding(2);
            this.Eigenvraag.Name = "Eigenvraag";
            this.Eigenvraag.Size = new System.Drawing.Size(537, 170);
            this.Eigenvraag.TabIndex = 26;
            this.Eigenvraag.Text = "Vul hier uw vraag in";
            this.Eigenvraag.Click += new System.EventHandler(this.Eigenvraag_Click);
            this.Eigenvraag.TextChanged += new System.EventHandler(this.Eigenvraag_TextChanged);
            this.Eigenvraag.Leave += new System.EventHandler(this.Eigenvraag_Leave);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Gray;
            this.Email.Location = new System.Drawing.Point(49, 116);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(537, 32);
            this.Email.TabIndex = 25;
            this.Email.Text = "Vul hier uw email-adres in";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // Achternaam
            // 
            this.Achternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Achternaam.ForeColor = System.Drawing.Color.Gray;
            this.Achternaam.Location = new System.Drawing.Point(322, 46);
            this.Achternaam.Margin = new System.Windows.Forms.Padding(2);
            this.Achternaam.Name = "Achternaam";
            this.Achternaam.Size = new System.Drawing.Size(262, 32);
            this.Achternaam.TabIndex = 24;
            this.Achternaam.Text = "Vul hier uw achternaam in";
            this.Achternaam.Click += new System.EventHandler(this.Achternaam_Click);
            this.Achternaam.TextChanged += new System.EventHandler(this.Achternaam_TextChanged);
            this.Achternaam.Leave += new System.EventHandler(this.Achternaam_Leave);
            // 
            // Voornaam
            // 
            this.Voornaam.BackColor = System.Drawing.Color.White;
            this.Voornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voornaam.ForeColor = System.Drawing.Color.Gray;
            this.Voornaam.Location = new System.Drawing.Point(49, 46);
            this.Voornaam.Margin = new System.Windows.Forms.Padding(2);
            this.Voornaam.Name = "Voornaam";
            this.Voornaam.Size = new System.Drawing.Size(250, 32);
            this.Voornaam.TabIndex = 23;
            this.Voornaam.Text = "Vul hier uw voornaam in";
            this.Voornaam.Click += new System.EventHandler(this.Voornaam_Click);
            this.Voornaam.TextChanged += new System.EventHandler(this.Voornaam_TextChanged);
            this.Voornaam.Leave += new System.EventHandler(this.Voornaam_Leave);
            // 
            // Verstuur
            // 
            this.Verstuur.Enabled = false;
            this.Verstuur.Image = global::EersteProjectMau.Properties.Resources.send_false;
            this.Verstuur.Location = new System.Drawing.Point(629, 344);
            this.Verstuur.Margin = new System.Windows.Forms.Padding(2);
            this.Verstuur.Name = "Verstuur";
            this.Verstuur.Size = new System.Drawing.Size(167, 86);
            this.Verstuur.TabIndex = 22;
            this.Verstuur.UseVisualStyleBackColor = true;
            this.Verstuur.Click += new System.EventHandler(this.Verstuur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EersteProjectMau.Properties.Resources.geenrobot;
            this.pictureBox1.Location = new System.Drawing.Point(874, 344);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.BlinkRate = 500;
            this.errorProviderEmail.ContainerControl = this;
            // 
            // Uwvraaglabel
            // 
            this.Uwvraaglabel.AutoSize = true;
            this.Uwvraaglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uwvraaglabel.ForeColor = System.Drawing.Color.Black;
            this.Uwvraaglabel.Location = new System.Drawing.Point(48, 233);
            this.Uwvraaglabel.Name = "Uwvraaglabel";
            this.Uwvraaglabel.Size = new System.Drawing.Size(325, 25);
            this.Uwvraaglabel.TabIndex = 30;
            this.Uwvraaglabel.Text = "Uw vraag (minimaal 30 woorden)\r\n";
            // 
            // Onderwerplabel
            // 
            this.Onderwerplabel.AutoSize = true;
            this.Onderwerplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Onderwerplabel.ForeColor = System.Drawing.Color.Black;
            this.Onderwerplabel.Location = new System.Drawing.Point(48, 159);
            this.Onderwerplabel.Name = "Onderwerplabel";
            this.Onderwerplabel.Size = new System.Drawing.Size(117, 25);
            this.Onderwerplabel.TabIndex = 31;
            this.Onderwerplabel.Text = "Onderwerp";
            // 
            // Emailadreslabel
            // 
            this.Emailadreslabel.AutoSize = true;
            this.Emailadreslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailadreslabel.ForeColor = System.Drawing.Color.Black;
            this.Emailadreslabel.Location = new System.Drawing.Point(48, 89);
            this.Emailadreslabel.Name = "Emailadreslabel";
            this.Emailadreslabel.Size = new System.Drawing.Size(127, 25);
            this.Emailadreslabel.TabIndex = 32;
            this.Emailadreslabel.Text = "Email Adres";
            // 
            // Voornaamlabel
            // 
            this.Voornaamlabel.AutoSize = true;
            this.Voornaamlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voornaamlabel.ForeColor = System.Drawing.Color.Black;
            this.Voornaamlabel.Location = new System.Drawing.Point(48, 18);
            this.Voornaamlabel.Name = "Voornaamlabel";
            this.Voornaamlabel.Size = new System.Drawing.Size(110, 25);
            this.Voornaamlabel.TabIndex = 33;
            this.Voornaamlabel.Text = "Voornaam";
            // 
            // Acthernaamlabel
            // 
            this.Acthernaamlabel.AutoSize = true;
            this.Acthernaamlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acthernaamlabel.ForeColor = System.Drawing.Color.Black;
            this.Acthernaamlabel.Location = new System.Drawing.Point(327, 18);
            this.Acthernaamlabel.Name = "Acthernaamlabel";
            this.Acthernaamlabel.Size = new System.Drawing.Size(127, 25);
            this.Acthernaamlabel.TabIndex = 34;
            this.Acthernaamlabel.Text = "Achternaam";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(604, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 470);
            this.panel1.TabIndex = 35;
            // 
            // StuurVraagFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(1200, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Acthernaamlabel);
            this.Controls.Add(this.Voornaamlabel);
            this.Controls.Add(this.Emailadreslabel);
            this.Controls.Add(this.Onderwerplabel);
            this.Controls.Add(this.Uwvraaglabel);
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
        private System.Windows.Forms.Label Uwvraaglabel;
        private System.Windows.Forms.Label Acthernaamlabel;
        private System.Windows.Forms.Label Voornaamlabel;
        private System.Windows.Forms.Label Emailadreslabel;
        private System.Windows.Forms.Label Onderwerplabel;
        private System.Windows.Forms.Panel panel1;
    }
}