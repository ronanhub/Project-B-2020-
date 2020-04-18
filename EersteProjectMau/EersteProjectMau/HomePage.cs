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
            
            tabControl2.Visible = helpKnop.Screen;
            helpKnop.Turn_ON_or_OFF();
            openHelp.Text = (tabControl2.Visible == false) ? "OPEN HELP" : "SLUIT HELP";
            tabControl1.Size = (tabControl2.Visible == false) ? new Size(770, 310) : new Size(550, 310);
        }






        Tuple<int, int>[] locaties = new Tuple<int, int>[] { Vraag_Antwoord_Loc_1.Item3, Vraag_Antwoord_Loc_2.Item3 };
        public void changeHuidig(int xLoc, int yLoc)
        {
            huidig.Visible = true;
            huidig.Location = new Point(xLoc, yLoc);
        }



        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_1 = new Tuple<string, string, Tuple<int, int>>
          /* Vraag */                    ("Hoe zet ik de oven aan?",
          /* Antwoord */                  "Stap 1: Loop naar de oven" +
                                          "\n\n" +
                                          "Stap 2: Kijk naar de oven" +
                                          "\n\n" +
                                          "Stap 3: Zoek de 'AAN' knop" +
                                          "\n\n" +
                                          "Stap 4: Klik op de 'AAN' knop" +
                                          "\n\n" +
                                          "Stap 5: Je oven staat nu aan" +
                                          "\n\n" +
                                          "Stap 6: Geniet ervan" +
                                          "\n\n" +
                                          "Stap 7: ????" +
                                          "\n\n" +
                                          "Stap 8: profit",
          /* ID */                        Tuple.Create(2, 53));

        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_2 = new Tuple<string, string, Tuple<int, int>>
         /* Vraag */                      ("Hoe verzin ik goede vragen?",
         /* Antwoord */                   "Stap 1: Wat maakt een vraag goed?" +
                                          "\n\n" +
                                          "Stap 2: Nou?" +
                                          "\n\n" +
                                          "Stap 3: ????" +
                                          "\n\n" +
                                          "Stap 4: profit",
          /* ID */                         Tuple.Create(2, 95));






        public void changeTextbox(string shownAntwoord)
        {
            richTextBox1.Text = shownAntwoord;
        }


        Vragen vraag1 = new Vragen(Vraag_Antwoord_Loc_1.Item1, Vraag_Antwoord_Loc_1.Item2, Vraag_Antwoord_Loc_1.Item3);
        Vragen vraag2 = new Vragen(Vraag_Antwoord_Loc_2.Item1, Vraag_Antwoord_Loc_2.Item2, Vraag_Antwoord_Loc_2.Item3);

        public HomePage()
        {
            InitializeComponent();
        }


        private void homePage_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl2.Appearance = TabAppearance.FlatButtons;
            tabControl2.ItemSize = new Size(0, 1);
            tabControl2.SizeMode = TabSizeMode.Fixed;
            Vraag1label.Text = vraag1.Vraag;
            Vraag2label.Text = vraag2.Vraag;
            this.ActiveControl = label1;

        }


        private void sluitHelp_Click(object sender, EventArgs e)
        {
            
        }


        private void openHelp_Click_1(object sender, EventArgs e)
        {
            Help_Open_Sluit();
        }

        private void faqButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
            tabControl2.SelectTab(3);
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
            tabControl2.SelectTab(0);
        }

        private void agendaButton_Click(object sender, EventArgs e)
        {
            
            tabControl1.SelectTab(1);
            tabControl2.SelectTab(1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            tabControl2.SelectTab(2);
        }

        private void helpPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Vraag1label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag1.Antwoord);
            changeHuidig(Vraag_Antwoord_Loc_1.Item3.Item1, Vraag_Antwoord_Loc_1.Item3.Item2);
        }

        private void Vraag2label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag2.Antwoord);
            changeHuidig(Vraag_Antwoord_Loc_2.Item3.Item1, Vraag_Antwoord_Loc_2.Item3.Item2);
        }

        private void hulpFAQ_Click(object sender, EventArgs e)
        {

        }

        private void stuurVraag_Click(object sender, EventArgs e)
        {
            StuurVraagFormcs stuurvraag = new StuurVraagFormcs();
            stuurvraag.Location = this.Location;
            stuurvraag.StartPosition = FormStartPosition.CenterScreen;
            stuurvraag.Show();
        }

        private void filmPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void helpFAQ_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
