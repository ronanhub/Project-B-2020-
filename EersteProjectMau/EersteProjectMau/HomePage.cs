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
        private object tabControl;
        Help_On_OFF helpKnop = new Help_On_OFF();

        public void Help_Open_Sluit()
        {
            
            helpPanel1.Visible = helpKnop.Screen;
            helpKnop.Turn_ON_or_OFF();
            openHelp.Text = (helpPanel1.Visible == false) ? "OPEN HELP" : "SLUIT HELP";
            tabControl1.Size = (helpPanel1.Visible == false) ? new Size(770, 310) : new Size(550, 310);
        }



        public HomePage()
        {
            InitializeComponent();
        }


        private void homePage_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

        }


        private void sluitHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void openHelp_Click_1(object sender, EventArgs e)
        {
            Help_Open_Sluit();
        }

        private void faqButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void noHelpFaqPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void faq_header_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            
            tabControl1.SelectTab(0);
        }

        private void agendaButton_Click(object sender, EventArgs e)
        {
            
            tabControl1.SelectTab(1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void helpPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
