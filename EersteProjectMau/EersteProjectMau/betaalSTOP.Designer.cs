namespace EersteProjectMau
{
    partial class betaalStop
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
            this.labello = new System.Windows.Forms.Label();
            this.knopperd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labello
            // 
            this.labello.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labello.Location = new System.Drawing.Point(12, 52);
            this.labello.Name = "labello";
            this.labello.Size = new System.Drawing.Size(449, 248);
            this.labello.TabIndex = 0;
            this.labello.Text = "label1";
            // 
            // knopperd
            // 
            this.knopperd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.knopperd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knopperd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.knopperd.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knopperd.Location = new System.Drawing.Point(161, 215);
            this.knopperd.Name = "knopperd";
            this.knopperd.Size = new System.Drawing.Size(162, 85);
            this.knopperd.TabIndex = 1;
            this.knopperd.Text = "OK";
            this.knopperd.UseVisualStyleBackColor = false;
            this.knopperd.Click += new System.EventHandler(this.knopperd_Click);
            // 
            // betaalStop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(478, 369);
            this.Controls.Add(this.knopperd);
            this.Controls.Add(this.labello);
            this.Name = "betaalStop";
            this.Text = "betaalSTOP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labello;
        private System.Windows.Forms.Button knopperd;
    }
}