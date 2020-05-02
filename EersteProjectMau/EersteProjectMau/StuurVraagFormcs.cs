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
    public partial class StuurVraagFormcs : Form
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

        private void StuurVraagFormcs_Load(object sender, EventArgs e)
        {

        }

        

       
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

        

        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        private void Email_Clicked(object sender, EventArgs e)
        {
            if (Email.Text == "Email Adres")
            {
                Email.Text = "";
            }

        }
        private void Eigenvraag_Clicked(object sender, EventArgs e)
        {
            if (Eigenvraag.Text == "Uw vraag")
            {
                Eigenvraag.Text = "";
            }
        }

        private void Voornaam_Clicked(object sender, EventArgs e)
        {
            if (Voornaam.Text == "Voornaam")
            {
                Voornaam.Text = "";
            }
        }

        private void Achternaam_Clicked(object sender, EventArgs e)
        {
            if (Achternaam.Text == "Achternaam")
            {
                Achternaam.Text = "";
            }

        }

        private void validaterings_Click_1(object sender, EventArgs e)
        {
            validaterings.BackColor = Color.Lime;
            
            Verstuur.Enabled = true;
            Verstuur.Image = Properties.Resources.send_true;
            Verstuur.Cursor = Cursors.Hand;
        }

        private void Onderwerp_Click(object sender, EventArgs e)
        {
            if (Onderwerp.Text == "Onderwerp")
            {
                Onderwerp.Text = "";
            }
        }









        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        private void Voornaam_Leave(object sender, EventArgs e)
        {
            if (Voornaam.Text == "")
            {
                Voornaam.Text = "Voornaam";
                Voornaam.ForeColor = Color.Gray;
            }
        }

        private void Achternaam_Leave(object sender, EventArgs e)
        {
            if (Achternaam.Text == "")
            {
                Achternaam.Text = "Achternaam";
                Achternaam.ForeColor = Color.Gray;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Email Adres";
                Email.ForeColor = Color.Gray;
            }
        }

        private void Onderwerp_Leave(object sender, EventArgs e)
        {
            if (Onderwerp.Text == "")
            {
                Onderwerp.Text = "Onderwerp";
                Onderwerp.ForeColor = Color.Gray;
            }
        }

        private void Eigenvraag_Leave(object sender, EventArgs e)
        {
            if (Eigenvraag.Text == "")
            {
                
                Eigenvraag.SelectionColor = Color.Gray;
                Eigenvraag.AppendText("Uw vraag");
            }
        }
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@















        private void Verstuur_Click(object sender, EventArgs e)
        {
            if (Email.Text == "" || Email.Text == "Email Adres")
            {
                MessageBox.Show("Vul een email adres in");
            }
            else
            {
                if (Eigenvraag.Text == "")
                {
                    MessageBox.Show("Vul een vraag in");
                }
                else
                {
                    if (Eigenvraag.Text.Length < 30)
                    {
                        MessageBox.Show("Uw vraag is te kort");
                    }
                    else
                    {

                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                        smtp.Credentials = new NetworkCredential("ashleyscinema010@gmail.com", "ashley010");

                        smtp.EnableSsl = true;

                        MailAddress mailfrom = new MailAddress("ashleyscinema010@gmail.com");
                        MailAddress mailto = new MailAddress("ashleyscinema010@gmail.com");
                        MailMessage newmsg = new MailMessage(mailfrom, mailto);

                        newmsg.Subject = this.Onderwerp.Text;
                        newmsg.Body = $"Nieuwe vraag van {Voornaam.Text} {Achternaam.Text}\n\nE-mail: {Email.Text}\n\nVraagt: {  this.Eigenvraag.Text}";



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
        }

       

    }



    

        

       

        

        
    }
