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
using System.Text.RegularExpressions;


namespace EersteProjectMau
{
    public partial class StuurVraagFormcs : Form
    {
        bool emailPattern = false;
        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                    return true;
            }
            return false;
        }


        public void stopForm(string stopReden)
        {
            betaalStop stoppenNuuuu = new betaalStop(stopReden);
            stoppenNuuuu.Text = stopReden;
            stoppenNuuuu.Location = this.Location;
            stoppenNuuuu.StartPosition = FormStartPosition.CenterScreen;
            stoppenNuuuu.Show();
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


        public StuurVraagFormcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validaterings.BackColor = Color.Lime;
            Verstuur.Enabled = true;
        }
        private void validaterings_Click_1(object sender, EventArgs e)
        {
            validaterings.BackColor = Color.Lime;
            Verstuur.Enabled = true;
        }
        private void validaterings_Click(object sender, EventArgs e)
        {
            validaterings.BackColor = Color.Lime;

            Verstuur.Enabled = true;
            Verstuur.Image = Properties.Resources.send_true;
            Verstuur.Cursor = Cursors.Hand;
        }
        private void Verstuur_Click(object sender, EventArgs e)
        {
            if      (Voornaam.Text == "" || Voornaam.Text == "Vul hier uw voornaam in")
                stopForm("Vul uw voornaam in");
            else if (Achternaam.Text == "" || Achternaam.Text == "Vul hier uw achternaam in")
                stopForm("Vul uw achternaam in");
            else if (Onderwerp.Text == "" || Onderwerp.Text == "Vul hier het onderwerp van uw vraag in")
                stopForm("Vul een onderwerp in");
            else if (Eigenvraag.Text.Length < 30)
                stopForm("Uw vraag is te kort");
            else if (emailPattern == false)
            {
                properEmail emailfout = new properEmail();

                errorProviderEmail.SetError(this.Email, "Vul een geldige email-adres in!");

                emailfout.mailBoxText(Email.Text);
                emailfout.Location = this.Location;
                emailfout.StartPosition = FormStartPosition.CenterScreen;
                emailfout.ShowDialog();
            }
            else
            { 
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                smtp.Credentials = new NetworkCredential("ashleyscinema010@gmail.com", "ashley010");

                smtp.EnableSsl = true;

                MailAddress mailfrom = new MailAddress("ashleyscinema010@gmail.com");
                MailAddress mailto = new MailAddress(Email.Text);
                MailMessage newmsg = new MailMessage(mailfrom, mailto);

                newmsg.Subject = this.Onderwerp.Text;
                newmsg.Body = $"Beste {Voornaam.Text} {Achternaam.Text},\n\nWij hebben uw vraag ontvangen en zullen ons best doen om binnen 3 werkdagen een antwoord naar u te sturen!\n\nUw vraag was:\n{  this.Eigenvraag.Text}";



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











        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        private void Voornaam_TextChanged(object sender, EventArgs e)
        {
            Voornaam.ForeColor = Color.Black;
        }

        private void Achternaam_TextChanged(object sender, EventArgs e)
        {
            Achternaam.ForeColor = Color.Black;
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            Email.ForeColor = Color.Black;
        }

        private void Onderwerp_TextChanged(object sender, EventArgs e)
        {
            Onderwerp.ForeColor = Color.Black;
        }

        private void Eigenvraag_TextChanged(object sender, EventArgs e)
        {
            Eigenvraag.ForeColor = Color.Black;
        }



        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        private void Voornaam_Click(object sender, EventArgs e)
        {
            if (Voornaam.Text == "Vul hier uw voornaam in")
            {
                Voornaam.Text = "";
            }
        }

        private void Achternaam_Click(object sender, EventArgs e)
        {
            if (Achternaam.Text == "Vul hier uw achternaam in")
            {
                Achternaam.Text = "";
            }
        }

        private void Email_Click(object sender, EventArgs e)
        {
            if (Email.Text == "Vul hier uw email-adres in")
            {
                Email.Text = "";
            }
        }

        private void Onderwerp_Click(object sender, EventArgs e)
        {
            if (Onderwerp.Text == "Vul hier het onderwerp van uw vraag in")
            {
                Onderwerp.Text = "";
            }
        }

        private void Eigenvraag_Click(object sender, EventArgs e)
        {
            if (Eigenvraag.Text == "Vul hier uw vraag in")
            {
                Eigenvraag.Text = "";
            }
        }



        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        private void Voornaam_Leave(object sender, EventArgs e)
        {
            if (Voornaam.Text == "")
            {
                Voornaam.Text = "Vul hier uw voornaam in";
                Voornaam.ForeColor = Color.Gray;
            }
        }

        private void Achternaam_Leave(object sender, EventArgs e)
        {
            if (Achternaam.Text == "")
            {
                Achternaam.Text = "Vul hier uw achternaam in";
                Achternaam.ForeColor = Color.Gray;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Vul hier uw email-adres in";
                Email.ForeColor = Color.Gray;
            }
            else
            {

                string pattern = "^([a-zA-Z0-9_\\-\\.]+)@([a-zA-Z0-9_\\-\\.]+)\\.([a-zA-Z]{2,5})$";
                if (Regex.IsMatch(Email.Text,pattern))
                {
                    emailPattern = true;
                }
            }
        }

        private void Onderwerp_Leave(object sender, EventArgs e)
        {
            if (Onderwerp.Text == "")
            {
                Onderwerp.Text = "Vul hier het onderwerp van uw vraag in";
                Onderwerp.ForeColor = Color.Gray;
            }
        }

        private void Eigenvraag_Leave(object sender, EventArgs e)
        {
            if (Eigenvraag.Text == "")
            {

                Eigenvraag.SelectionColor = Color.Gray;
                Eigenvraag.AppendText("Vul hier uw vraag in");
            }
        }

    }
}
