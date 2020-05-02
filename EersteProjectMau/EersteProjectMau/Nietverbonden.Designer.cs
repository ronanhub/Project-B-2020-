namespace EersteProjectMau
{
    partial class Nietverbonden
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
            this.Klikopok = new System.Windows.Forms.Label();
            this.connectieText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OKbutton
            // 
            this.OKbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.OKbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKbutton.Location = new System.Drawing.Point(45, 287);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(189, 127);
            this.OKbutton.TabIndex = 7;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = false;
            // 
            // Klikopok
            // 
            this.Klikopok.AutoSize = true;
            this.Klikopok.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klikopok.Location = new System.Drawing.Point(12, 119);
            this.Klikopok.Name = "Klikopok";
            this.Klikopok.Size = new System.Drawing.Size(347, 78);
            this.Klikopok.TabIndex = 6;
            this.Klikopok.Text = "Klik op OK om het\r\nnogmaals te proberen";
            // 
            // connectieText
            // 
            this.connectieText.AutoSize = true;
            this.connectieText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectieText.Location = new System.Drawing.Point(12, 9);
            this.connectieText.Name = "connectieText";
            this.connectieText.Size = new System.Drawing.Size(690, 78);
            this.connectieText.TabIndex = 5;
            this.connectieText.Text = "Oeps! We kunnen uw vraag niet sturen.\r\nControleer uw verbinding met het internet." +
    "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EersteProjectMau.Properties.Resources.geenverbinding;
            this.pictureBox1.Location = new System.Drawing.Point(336, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Nietverbonden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 536);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.Klikopok);
            this.Controls.Add(this.connectieText);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Nietverbonden";
            this.Text = "Nietverbonden";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Label Klikopok;
        private System.Windows.Forms.Label connectieText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}