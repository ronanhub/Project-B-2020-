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
using System.IO;


namespace EersteProjectMau
{

    public partial class Email : Form
    {

        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        public Email()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            smtp.Credentials = new NetworkCredential("ashleyscinema010@gmail.com", "ashley010");

            smtp.EnableSsl = true;

            MailAddress mailfrom = new MailAddress("ashleyscinema010@gmail.com");
            MailAddress mailto = new MailAddress("ashleyscinema010@gmail.com");
            MailMessage newmsg = new MailMessage(mailfrom, mailto);

            newmsg.Subject = this.Onderwerp.Text;
            newmsg.Body = $"Zender: {uwMail.Text}\n\nVraagt: {  this.tekst.Text}";



            bool connected = CheckForInternetConnection();
            if (connected == true)
            {
                smtp.Send(newmsg);

                Verzonden sent = new Verzonden();
                string results = sent.Text;

                sent.Location = this.Location;
                sent.StartPosition = FormStartPosition.CenterScreen;
                sent.ShowDialog();
                if (sent.closer == "Closing...")
                {
                    this.Close();
                }
            }
            else
            {
                Nietverbonden geeninternet = new Nietverbonden();
                geeninternet.Location = this.Location;
                geeninternet.StartPosition = FormStartPosition.CenterScreen;
                geeninternet.ShowDialog();

            }



        }
    }
}
