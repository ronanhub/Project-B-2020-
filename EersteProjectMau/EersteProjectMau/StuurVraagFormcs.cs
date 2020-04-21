using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EersteProjectMau
{
    public partial class StuurVraagFormcs : Form
    {
        public StuurVraagFormcs()
        {
            InitializeComponent();
        }

        private void robot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void robot_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            validaterings.BackColor = Color.Lime;
            Verstuur.Enabled = true;





        }

        private void Verstuur_Click(object sender, EventArgs e)
        {
            

        }

        private void Voornaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void Achternaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {




        }




        private void Eigenvraag_TextChanged(object sender, EventArgs e)
        {

        }

        private void StuurVraagFormcs_Load(object sender, EventArgs e)
        {

        }

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
        }

        private void Verstuur_Click_1(object sender, EventArgs e)
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
                        MessageBox.Show(" Je vraag is verstuurd!\n " +
                            "We zullen ons best niet doen om binnen een dag \n" +
                            " antwoord te sturen naar je e-mail :)");
                        this.Hide();
                    }
                }

            }
        }
    }
}
