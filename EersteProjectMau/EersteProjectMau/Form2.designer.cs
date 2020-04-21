namespace WindowsFormsAppbook
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Verstuur = new System.Windows.Forms.Button();
            this.Voornaam = new System.Windows.Forms.TextBox();
            this.Achternaam = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Eigenvraag = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(260, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 31);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Verstuur
            // 
            this.Verstuur.Enabled = false;
            this.Verstuur.Location = new System.Drawing.Point(44, 304);
            this.Verstuur.Name = "Verstuur";
            this.Verstuur.Size = new System.Drawing.Size(157, 60);
            this.Verstuur.TabIndex = 5;
            this.Verstuur.Text = "Verstuur";
            this.Verstuur.UseVisualStyleBackColor = true;
            this.Verstuur.Click += new System.EventHandler(this.Verstuur_Click);
            // 
            // Voornaam
            // 
            this.Voornaam.BackColor = System.Drawing.Color.White;
            this.Voornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voornaam.Location = new System.Drawing.Point(44, 41);
            this.Voornaam.Name = "Voornaam";
            this.Voornaam.Size = new System.Drawing.Size(177, 27);
            this.Voornaam.TabIndex = 6;
            this.Voornaam.Text = "Voornaam";
            this.Voornaam.Click += new System.EventHandler(this.Voornaam_Clicked);
            this.Voornaam.TextChanged += new System.EventHandler(this.Voornaam_TextChanged);
            // 
            // Achternaam
            // 
            this.Achternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Achternaam.Location = new System.Drawing.Point(252, 41);
            this.Achternaam.Name = "Achternaam";
            this.Achternaam.Size = new System.Drawing.Size(180, 27);
            this.Achternaam.TabIndex = 7;
            this.Achternaam.Text = "Achternaam";
            this.Achternaam.Click += new System.EventHandler(this.Achternaam_Clicked);
            this.Achternaam.TextChanged += new System.EventHandler(this.Achternaam_TextChanged);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(44, 83);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(388, 27);
            this.Email.TabIndex = 8;
            this.Email.Text = "Email Adres";
            this.Email.Click += new System.EventHandler(this.Email_Clicked);
            this.Email.Leave += new System.EventHandler(this.Email_TextChanged);
            // 
            // Eigenvraag
            // 
            this.Eigenvraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eigenvraag.Location = new System.Drawing.Point(44, 129);
            this.Eigenvraag.Name = "Eigenvraag";
            this.Eigenvraag.Size = new System.Drawing.Size(388, 150);
            this.Eigenvraag.TabIndex = 9;
            this.Eigenvraag.Text = "Uw vraag";
            this.Eigenvraag.Click += new System.EventHandler(this.Eigenvraag_Clicked);
            this.Eigenvraag.TextChanged += new System.EventHandler(this.Eigenvraag_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 397);
            this.Controls.Add(this.Eigenvraag);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Achternaam);
            this.Controls.Add(this.Voornaam);
            this.Controls.Add(this.Verstuur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Verstuur;
        private System.Windows.Forms.TextBox Voornaam;
        private System.Windows.Forms.TextBox Achternaam;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.RichTextBox Eigenvraag;
    }
}