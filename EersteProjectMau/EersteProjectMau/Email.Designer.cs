namespace EersteProjectMau
{
    partial class Email
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Onderwerp = new System.Windows.Forms.TextBox();
            this.uwMail = new System.Windows.Forms.TextBox();
            this.labelUwMail = new System.Windows.Forms.Label();
            this.onderwerpLabel = new System.Windows.Forms.Label();
            this.tekstLabel = new System.Windows.Forms.Label();
            this.verstuur = new System.Windows.Forms.Button();
            this.tekst = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.15789F));
            this.tableLayoutPanel1.Controls.Add(this.Onderwerp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.uwMail, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelUwMail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.onderwerpLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tekstLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.verstuur, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tekst, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(191, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.58258F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.620523F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.64725F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.14965F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 345);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Onderwerp
            // 
            this.Onderwerp.Location = new System.Drawing.Point(157, 39);
            this.Onderwerp.Name = "Onderwerp";
            this.Onderwerp.Size = new System.Drawing.Size(238, 22);
            this.Onderwerp.TabIndex = 14;
            // 
            // uwMail
            // 
            this.uwMail.Location = new System.Drawing.Point(157, 3);
            this.uwMail.Name = "uwMail";
            this.uwMail.Size = new System.Drawing.Size(238, 22);
            this.uwMail.TabIndex = 13;
            // 
            // labelUwMail
            // 
            this.labelUwMail.AutoSize = true;
            this.labelUwMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUwMail.Location = new System.Drawing.Point(3, 0);
            this.labelUwMail.Name = "labelUwMail";
            this.labelUwMail.Size = new System.Drawing.Size(134, 32);
            this.labelUwMail.TabIndex = 5;
            this.labelUwMail.Text = "Uw Email";
            // 
            // onderwerpLabel
            // 
            this.onderwerpLabel.AutoSize = true;
            this.onderwerpLabel.Location = new System.Drawing.Point(3, 36);
            this.onderwerpLabel.Name = "onderwerpLabel";
            this.onderwerpLabel.Size = new System.Drawing.Size(78, 17);
            this.onderwerpLabel.TabIndex = 6;
            this.onderwerpLabel.Text = "Onderwerp";
            // 
            // tekstLabel
            // 
            this.tekstLabel.AutoSize = true;
            this.tekstLabel.Location = new System.Drawing.Point(3, 69);
            this.tekstLabel.Name = "tekstLabel";
            this.tekstLabel.Size = new System.Drawing.Size(43, 17);
            this.tekstLabel.TabIndex = 7;
            this.tekstLabel.Text = "Tekst";
            // 
            // verstuur
            // 
            this.verstuur.Location = new System.Drawing.Point(3, 277);
            this.verstuur.Name = "verstuur";
            this.verstuur.Size = new System.Drawing.Size(148, 51);
            this.verstuur.TabIndex = 8;
            this.verstuur.Text = "Send";
            this.verstuur.UseVisualStyleBackColor = true;
            // 
            // tekst
            // 
            this.tekst.Location = new System.Drawing.Point(157, 72);
            this.tekst.Name = "tekst";
            this.tekst.Size = new System.Drawing.Size(238, 173);
            this.tekst.TabIndex = 15;
            this.tekst.Text = "";
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Email";
            this.Text = "Email";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Onderwerp;
        private System.Windows.Forms.TextBox uwMail;
        private System.Windows.Forms.Label labelUwMail;
        private System.Windows.Forms.Label onderwerpLabel;
        private System.Windows.Forms.Label tekstLabel;
        private System.Windows.Forms.Button verstuur;
        private System.Windows.Forms.RichTextBox tekst;
    }
}