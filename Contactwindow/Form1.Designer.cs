namespace Contactwindow
{
    partial class ContactWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactWindow));
            this.Titel = new System.Windows.Forms.Label();
            this.OnderTitel = new System.Windows.Forms.Label();
            this.AdressBox = new System.Windows.Forms.GroupBox();
            this.LocatieButton = new System.Windows.Forms.Button();
            this.BedrijfAdress = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.ContactBox = new System.Windows.Forms.GroupBox();
            this.EmailBtn = new System.Windows.Forms.Button();
            this.BedrijfEmail = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.BdrijfTelefoon = new System.Windows.Forms.Label();
            this.ContactLabe = new System.Windows.Forms.Label();
            this.LocatiePic = new System.Windows.Forms.PictureBox();
            this.StuurMailBox = new System.Windows.Forms.GroupBox();
            this.VolgendeMailbox = new System.Windows.Forms.Button();
            this.UserEmailLbl = new System.Windows.Forms.Label();
            this.UserEmailText = new System.Windows.Forms.TextBox();
            this.InvulMailBox = new System.Windows.Forms.GroupBox();
            this.StuurMailText = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblCC = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSmtp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ChkSSL = new System.Windows.Forms.CheckBox();
            this.AdressBox.SuspendLayout();
            this.ContactBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocatiePic)).BeginInit();
            this.StuurMailBox.SuspendLayout();
            this.InvulMailBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titel
            // 
            this.Titel.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titel.ForeColor = System.Drawing.Color.DarkOrange;
            this.Titel.Location = new System.Drawing.Point(220, 9);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(507, 88);
            this.Titel.TabIndex = 0;
            this.Titel.Text = "ASHLEY\'S CINEMA";
            // 
            // OnderTitel
            // 
            this.OnderTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnderTitel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OnderTitel.Location = new System.Drawing.Point(398, 78);
            this.OnderTitel.Name = "OnderTitel";
            this.OnderTitel.Size = new System.Drawing.Size(118, 34);
            this.OnderTitel.TabIndex = 1;
            this.OnderTitel.Text = "Voor 65+ers";
            this.OnderTitel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdressBox
            // 
            this.AdressBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AdressBox.Controls.Add(this.LocatieButton);
            this.AdressBox.Controls.Add(this.BedrijfAdress);
            this.AdressBox.Controls.Add(this.AdressLabel);
            this.AdressBox.Location = new System.Drawing.Point(23, 196);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(406, 105);
            this.AdressBox.TabIndex = 5;
            this.AdressBox.TabStop = false;
            // 
            // LocatieButton
            // 
            this.LocatieButton.Location = new System.Drawing.Point(159, 62);
            this.LocatieButton.Name = "LocatieButton";
            this.LocatieButton.Size = new System.Drawing.Size(75, 23);
            this.LocatieButton.TabIndex = 2;
            this.LocatieButton.Text = "Locatie";
            this.LocatieButton.UseVisualStyleBackColor = true;
            this.LocatieButton.Click += new System.EventHandler(this.LocatieButton_Click);
            // 
            // BedrijfAdress
            // 
            this.BedrijfAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedrijfAdress.Location = new System.Drawing.Point(91, 20);
            this.BedrijfAdress.Name = "BedrijfAdress";
            this.BedrijfAdress.Size = new System.Drawing.Size(315, 23);
            this.BedrijfAdress.TabIndex = 1;
            this.BedrijfAdress.Text = "Wijnhaven 109 .3011 WN Rotterdam\r\n";
            // 
            // AdressLabel
            // 
            this.AdressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressLabel.Location = new System.Drawing.Point(7, 20);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(78, 23);
            this.AdressLabel.TabIndex = 0;
            this.AdressLabel.Text = "Adress:";
            // 
            // ContactBox
            // 
            this.ContactBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ContactBox.Controls.Add(this.EmailBtn);
            this.ContactBox.Controls.Add(this.BedrijfEmail);
            this.ContactBox.Controls.Add(this.EmailLabel);
            this.ContactBox.Controls.Add(this.BdrijfTelefoon);
            this.ContactBox.Controls.Add(this.ContactLabe);
            this.ContactBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ContactBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactBox.Location = new System.Drawing.Point(23, 378);
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.Size = new System.Drawing.Size(435, 118);
            this.ContactBox.TabIndex = 6;
            this.ContactBox.TabStop = false;
            // 
            // EmailBtn
            // 
            this.EmailBtn.Location = new System.Drawing.Point(108, 73);
            this.EmailBtn.Name = "EmailBtn";
            this.EmailBtn.Size = new System.Drawing.Size(151, 39);
            this.EmailBtn.TabIndex = 4;
            this.EmailBtn.Text = "StuurEmail";
            this.EmailBtn.UseVisualStyleBackColor = true;
            this.EmailBtn.Click += new System.EventHandler(this.EmailBtn_Click);
            // 
            // BedrijfEmail
            // 
            this.BedrijfEmail.Location = new System.Drawing.Point(75, 39);
            this.BedrijfEmail.Name = "BedrijfEmail";
            this.BedrijfEmail.Size = new System.Drawing.Size(264, 31);
            this.BedrijfEmail.TabIndex = 3;
            this.BedrijfEmail.Text = "AshleysCinema@65Plus.com";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(7, 39);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(62, 24);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email:";
            // 
            // BdrijfTelefoon
            // 
            this.BdrijfTelefoon.Location = new System.Drawing.Point(104, 9);
            this.BdrijfTelefoon.Name = "BdrijfTelefoon";
            this.BdrijfTelefoon.Size = new System.Drawing.Size(121, 30);
            this.BdrijfTelefoon.TabIndex = 1;
            this.BdrijfTelefoon.Text = "06 4567 8790";
            // 
            // ContactLabe
            // 
            this.ContactLabe.Location = new System.Drawing.Point(6, 9);
            this.ContactLabe.Name = "ContactLabe";
            this.ContactLabe.Size = new System.Drawing.Size(92, 30);
            this.ContactLabe.TabIndex = 0;
            this.ContactLabe.Text = "Telefoon:";
            // 
            // LocatiePic
            // 
            this.LocatiePic.Image = ((System.Drawing.Image)(resources.GetObject("LocatiePic.Image")));
            this.LocatiePic.Location = new System.Drawing.Point(435, 115);
            this.LocatiePic.Name = "LocatiePic";
            this.LocatiePic.Size = new System.Drawing.Size(609, 452);
            this.LocatiePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LocatiePic.TabIndex = 7;
            this.LocatiePic.TabStop = false;
            this.LocatiePic.Visible = false;
            this.LocatiePic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // StuurMailBox
            // 
            this.StuurMailBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StuurMailBox.Controls.Add(this.ChkSSL);
            this.StuurMailBox.Controls.Add(this.txtSmtp);
            this.StuurMailBox.Controls.Add(this.label7);
            this.StuurMailBox.Controls.Add(this.txtPort);
            this.StuurMailBox.Controls.Add(this.label6);
            this.StuurMailBox.Controls.Add(this.txtWachtwoord);
            this.StuurMailBox.Controls.Add(this.label5);
            this.StuurMailBox.Controls.Add(this.VolgendeMailbox);
            this.StuurMailBox.Controls.Add(this.UserEmailLbl);
            this.StuurMailBox.Controls.Add(this.UserEmailText);
            this.StuurMailBox.Location = new System.Drawing.Point(29, 502);
            this.StuurMailBox.Name = "StuurMailBox";
            this.StuurMailBox.Size = new System.Drawing.Size(400, 215);
            this.StuurMailBox.TabIndex = 8;
            this.StuurMailBox.TabStop = false;
            this.StuurMailBox.Visible = false;
            // 
            // VolgendeMailbox
            // 
            this.VolgendeMailbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolgendeMailbox.Location = new System.Drawing.Point(219, 162);
            this.VolgendeMailbox.Name = "VolgendeMailbox";
            this.VolgendeMailbox.Size = new System.Drawing.Size(150, 36);
            this.VolgendeMailbox.TabIndex = 3;
            this.VolgendeMailbox.Text = "Volgende";
            this.VolgendeMailbox.UseVisualStyleBackColor = true;
            this.VolgendeMailbox.Click += new System.EventHandler(this.VolgendeMailbox_Click);
            // 
            // UserEmailLbl
            // 
            this.UserEmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserEmailLbl.Location = new System.Drawing.Point(17, 17);
            this.UserEmailLbl.Name = "UserEmailLbl";
            this.UserEmailLbl.Size = new System.Drawing.Size(62, 23);
            this.UserEmailLbl.TabIndex = 2;
            this.UserEmailLbl.Text = "Email:\r\n";
            // 
            // UserEmailText
            // 
            this.UserEmailText.Location = new System.Drawing.Point(89, 17);
            this.UserEmailText.Name = "UserEmailText";
            this.UserEmailText.Size = new System.Drawing.Size(305, 20);
            this.UserEmailText.TabIndex = 1;
            this.UserEmailText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // InvulMailBox
            // 
            this.InvulMailBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InvulMailBox.Controls.Add(this.txtSubject);
            this.InvulMailBox.Controls.Add(this.txtCC);
            this.InvulMailBox.Controls.Add(this.txtTo);
            this.InvulMailBox.Controls.Add(this.lblMessage);
            this.InvulMailBox.Controls.Add(this.lblSubject);
            this.InvulMailBox.Controls.Add(this.lblCC);
            this.InvulMailBox.Controls.Add(this.lblTo);
            this.InvulMailBox.Controls.Add(this.StuurMailText);
            this.InvulMailBox.Controls.Add(this.txtMessage);
            this.InvulMailBox.Location = new System.Drawing.Point(487, 406);
            this.InvulMailBox.Name = "InvulMailBox";
            this.InvulMailBox.Size = new System.Drawing.Size(516, 251);
            this.InvulMailBox.TabIndex = 9;
            this.InvulMailBox.TabStop = false;
            this.InvulMailBox.Visible = false;
            // 
            // StuurMailText
            // 
            this.StuurMailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuurMailText.Location = new System.Drawing.Point(337, 207);
            this.StuurMailText.Name = "StuurMailText";
            this.StuurMailText.Size = new System.Drawing.Size(165, 34);
            this.StuurMailText.TabIndex = 1;
            this.StuurMailText.Text = "Stuur Mail";
            this.StuurMailText.UseVisualStyleBackColor = true;
            this.StuurMailText.Click += new System.EventHandler(this.StuurMailText_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(76, 110);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(426, 91);
            this.txtMessage.TabIndex = 0;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(7, 20);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To:";
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(6, 45);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(24, 13);
            this.lblCC.TabIndex = 3;
            this.lblCC.Text = "CC:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(6, 71);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Subject:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(6, 113);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Message:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(76, 19);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(426, 20);
            this.txtTo.TabIndex = 6;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(76, 45);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(426, 20);
            this.txtCC.TabIndex = 7;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(76, 71);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(426, 20);
            this.txtSubject.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wachtwoord:\r\n\r\n";
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Location = new System.Drawing.Point(183, 43);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.PasswordChar = '*';
            this.txtWachtwoord.Size = new System.Drawing.Size(150, 20);
            this.txtWachtwoord.TabIndex = 5;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(73, 85);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(71, 20);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "587";
            this.txtPort.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Port:\r\n\r\n";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtSmtp
            // 
            this.txtSmtp.Location = new System.Drawing.Point(98, 122);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(91, 20);
            this.txtSmtp.TabIndex = 9;
            this.txtSmtp.Text = "Smtp.gmail.com";
            this.txtSmtp.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "SMTP:\r\n\r\n";
            // 
            // ChkSSL
            // 
            this.ChkSSL.AutoSize = true;
            this.ChkSSL.Location = new System.Drawing.Point(204, 87);
            this.ChkSSL.Name = "ChkSSL";
            this.ChkSSL.Size = new System.Drawing.Size(46, 17);
            this.ChkSSL.TabIndex = 10;
            this.ChkSSL.Text = "SSL";
            this.ChkSSL.UseVisualStyleBackColor = true;
            // 
            // ContactWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.InvulMailBox);
            this.Controls.Add(this.StuurMailBox);
            this.Controls.Add(this.LocatiePic);
            this.Controls.Add(this.ContactBox);
            this.Controls.Add(this.AdressBox);
            this.Controls.Add(this.OnderTitel);
            this.Controls.Add(this.Titel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactWindow";
            this.Load += new System.EventHandler(this.ContactWindow_Load);
            this.AdressBox.ResumeLayout(false);
            this.ContactBox.ResumeLayout(false);
            this.ContactBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocatiePic)).EndInit();
            this.StuurMailBox.ResumeLayout(false);
            this.StuurMailBox.PerformLayout();
            this.InvulMailBox.ResumeLayout(false);
            this.InvulMailBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.Label OnderTitel;
        private System.Windows.Forms.GroupBox AdressBox;
        private System.Windows.Forms.Button LocatieButton;
        private System.Windows.Forms.Label BedrijfAdress;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.GroupBox ContactBox;
        private System.Windows.Forms.Button EmailBtn;
        private System.Windows.Forms.Label BedrijfEmail;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label BdrijfTelefoon;
        private System.Windows.Forms.Label ContactLabe;
        private System.Windows.Forms.PictureBox LocatiePic;
        private System.Windows.Forms.GroupBox StuurMailBox;
        private System.Windows.Forms.TextBox UserEmailText;
        private System.Windows.Forms.Button VolgendeMailbox;
        private System.Windows.Forms.Label UserEmailLbl;
        private System.Windows.Forms.GroupBox InvulMailBox;
        private System.Windows.Forms.Button StuurMailText;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtSmtp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ChkSSL;
    }
}

