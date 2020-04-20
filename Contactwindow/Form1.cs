using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace Contactwindow
{
    public partial class ContactWindow : Form
    {
        NetworkCredential login;
        SmtpClient Client;
        MailMessage msg;

        public ContactWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmailBtn_Click(object sender, EventArgs e)
        {
            if (StuurMailBox.Visible==false)
            {
                StuurMailBox.Visible = true;
            }
            
            
        }

        private void LocatieButton_Click(object sender, EventArgs e)
        {
            if (LocatiePic.Visible == false)
            {
                LocatiePic.Visible = true;
            }
            else
            {
                LocatiePic.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VolgendeMailbox_Click(object sender, EventArgs e)
        {
            login = new NetworkCredential(UserEmailText.Text, txtWachtwoord.Text);
            Client = new SmtpClient(txtSmtp.Text);
            Client.Port = Convert.ToInt32(txtPort.Text);
            Client.EnableSsl = ChkSSL.Checked;
            Client.Credentials = login;
            

            if(StuurMailBox.Visible== true)
            {
                InvulMailBox.Visible = true;
                StuurMailBox.Visible = false;
            }
        }

        private void StuurMailText_Click(object sender, EventArgs e)
        {
            msg = new MailMessage { From = new MailAddress(UserEmailText.Text + txtSmtp.Text.Replace("smtp.", "@"), "lucy", Encoding.UTF8) };
            msg.To.Add(new MailAddress(txtTo.Text));
            if (!string.IsNullOrEmpty(txtCC.Text))
            {
                msg.To.Add(new MailAddress(txtCC.Text));
            }


            if (InvulMailBox.Visible == true)
            {
                InvulMailBox.Visible = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
