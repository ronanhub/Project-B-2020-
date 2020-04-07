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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }


        private void homePage_Load(object sender, EventArgs e)
        {

        }


        private void sluitHelp_Click(object sender, EventArgs e)
        {
            filmPanel1.Visible = false;
            helpPanel1.Visible = false;
            noHelpMainPanel.Visible = true;
            sluitHelp.Visible = false;
            openHelp.Visible = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void openHelp_Click_1(object sender, EventArgs e)
        {
            filmPanel1.Visible = true;
            helpPanel1.Visible = true;
            noHelpMainPanel.Visible = false;
            sluitHelp.Visible = true;
            openHelp.Visible = false;
        }

        private void agendaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agenda agenda = new Agenda();
            agenda.FormClosing += delegate { this.Close(); };
            agenda.Show();
        }
    }
}
