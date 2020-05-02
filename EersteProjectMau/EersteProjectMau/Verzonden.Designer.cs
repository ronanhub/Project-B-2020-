namespace EersteProjectMau
{
    partial class Verzonden
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
            this.OKbutton = new System.Windows.Forms.Button();
            this.Klikopokomverder = new System.Windows.Forms.Label();
            this.verzondenText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // OKbutton
            // 
            this.OKbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OKbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKbutton.Location = new System.Drawing.Point(410, 197);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(139, 87);
            this.OKbutton.TabIndex = 10;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = false;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // Klikopokomverder
            // 
            this.Klikopokomverder.AutoSize = true;
            this.Klikopokomverder.BackColor = System.Drawing.Color.Transparent;
            this.Klikopokomverder.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klikopokomverder.Location = new System.Drawing.Point(13, 197);
            this.Klikopokomverder.Name = "Klikopokomverder";
            this.Klikopokomverder.Size = new System.Drawing.Size(290, 78);
            this.Klikopokomverder.TabIndex = 9;
            this.Klikopokomverder.Text = "Klik op OK om het\r\nverder te gaan.\r\n";
            // 
            // verzondenText
            // 
            this.verzondenText.AutoSize = true;
            this.verzondenText.BackColor = System.Drawing.Color.Transparent;
            this.verzondenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verzondenText.Location = new System.Drawing.Point(32, 9);
            this.verzondenText.Name = "verzondenText";
            this.verzondenText.Size = new System.Drawing.Size(456, 46);
            this.verzondenText.TabIndex = 8;
            this.verzondenText.Text = "Uw vraag is verzonden!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EersteProjectMau.Properties.Resources.inbox;
            this.pictureBox1.Location = new System.Drawing.Point(1, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 325);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EersteProjectMau.Properties.Resources._4494c524a5f4629df73fa90fd5c4d03a_confetti_transparent_gif_on_gifer_by_manariel_480_328;
            this.pictureBox2.Location = new System.Drawing.Point(-34, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(611, 430);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Verzonden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 518);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.Klikopokomverder);
            this.Controls.Add(this.verzondenText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Verzonden";
            this.Text = "Verzonden";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Label Klikopokomverder;
        private System.Windows.Forms.Label verzondenText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}