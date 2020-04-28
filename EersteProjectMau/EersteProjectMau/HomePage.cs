using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        public Button vindStoel(int nummer)
        {
            string nummerString;
            if (nummer < 10)
            {
                nummerString = "0" + nummer.ToString();
            }
            else
            {
                nummerString = nummer.ToString();
            }
            var tabControl = this.Controls["tabControl1"] as TabControl;
            var tabPage = tabControl.Controls["tabPageStoelselectie"] as TabPage;
            return tabPage.Controls["buttonStoel" + nummerString] as Button;
            //return this.Controls["buttonStoel" + nummerString] as Button;
        }

        public List<zitPlaats> stoelGrid;
        public float basisPrijs;
        public string kortingsCode;
        public float totaalPrijs;
        public enum status
        {
            vrij = 0,
            bezet = 1,
            keuze = 2
        }
        public void updateKleur(Button button)
        {
            int nummer;
            Color kleur;
            string nummerString = button.Name.Substring(startIndex: 11, length: 2);
            Int32.TryParse(nummerString, out nummer);

            switch (stoelGrid[nummer].seatStatus)
            {
                case status.vrij:
                    {
                        kleur = System.Drawing.Color.Silver;
                        break;
                    }
                case status.keuze:
                    {
                        kleur = System.Drawing.Color.Green;
                        break;
                    }
                case status.bezet:
                    {
                        kleur = System.Drawing.Color.OrangeRed;
                        break;
                    }
                default:
                    {
                        kleur = System.Drawing.Color.Silver;
                        break;
                    }
            }

            button.BackColor = kleur;
        }

        public void updatePrijs(Button button)
        {
            int nummer;
            Color kleur;
            string nummerString = button.Name.Substring(startIndex: 11, length: 2);
            Int32.TryParse(nummerString, out nummer);

            button.Text = "€" + prijstString(stoelGrid[nummer].seatPrijs * checkKortingscode(textBoxKorting.Text));//(stoelGrid[nummer].Item1*checkKortingscode(textBoxKorting.Text)).ToString();
        }
        public void updatePrijs()
        {
            basisPrijs = 0.0f;
            for (int i = 0; i < 48; i++)
            {
                if (stoelGrid[i].seatStatus == status.keuze)
                {
                    basisPrijs += stoelGrid[i].seatPrijs;
                }
            }
            totaalPrijs = checkKortingscode(textBoxKorting.Text) * basisPrijs;
            labelPrijs.Text = "Totaal: € " + (totaalPrijs).ToString();
        }

        //geeft een prijs multiplier terug
        private float checkKortingscode(string code)
        {
            switch (code)
            {
                case "kortingNU":
                    {
                        return 0.8f;
                    }
                case "korting":
                    {
                        return 0.7f;
                    }
                default:
                    {
                        return 1.0f;
                    }
            }
        }
        public string prijstString(float prijs)
        {
            string result;
            result = prijs.ToString();
            int loc = result.IndexOf(",");
            if (loc == -1)
            {
                return result;
            }
            if (result.Length == loc)
            {
                return result + "00";
            }
            else if (result.Length == loc + 1)
            {
                return result + "00";
            }
            else if (result.Length == loc + 2)
            {
                return result + "0";
            }
            else  //(result.Length > loc + 1)
            {
                return result.Substring(0, loc + 3);
            }
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

        public class zitPlaats
        {
            public float seatPrijs;
            public status seatStatus;
            public zitPlaats(float SeatPrijs, status SeatStatus)
            {
                seatPrijs = SeatPrijs;
                seatStatus = SeatStatus;
            }
        }
        public class stoelGridClass
        {
            List<zitPlaats> stoelGrid;

            public stoelGridClass(List<zitPlaats> StoelGrid)
            {
                stoelGrid = StoelGrid;
            }
        }

        public List<zitPlaats> laadStoelGrid(string fileName)
        {
            string JsonString = File.ReadAllText(fileName);
            var resultList = new List<zitPlaats> { };
            return resultList;
        }
        public void saveStoelGrid(string fileName, List<zitPlaats> stoelGrid)
        {
            json = new JsonConvert();
            stoelGridClass Grid = new stoelGridClass(stoelGrid);
            string JsonString = json
            var resultList = new List<zitPlaats> { };
        }

        public HomePage()
        {
            InitializeComponent();
            //het maken van de stoelgrid met prijzen en status van stoel
            stoelGrid = laadStoelGrid("TestFile.txt");/*new List<zitPlaats> {
                new zitPlaats(10.8f,status.vrij), new zitPlaats(10.000f,status.vrij), new zitPlaats(10.0000f,status.vrij), new zitPlaats(10.0f,status.vrij),
                new zitPlaats(11.10f,status.vrij), new zitPlaats(11.1f,status.bezet), new zitPlaats(11.12f,status.vrij), new zitPlaats(11.10f,status.vrij),
                new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.vrij),

                new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.bezet), new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.vrij),
                new zitPlaats(11.0f,status.bezet), new zitPlaats(11.0f,status.vrij), new zitPlaats(11.0f,status.vrij), new zitPlaats(11.0f,status.vrij),
                new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.vrij),

                new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.vrij),
                new zitPlaats(11.0f,status.vrij), new zitPlaats(11.0f,status.vrij), new zitPlaats(11.0f,status.vrij), new zitPlaats(11.0f,status.vrij),
                new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.vrij),

                new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.vrij),
                new zitPlaats(11.0f,status.vrij), new zitPlaats(11.0f,status.vrij), new zitPlaats(11.0f,status.vrij), new zitPlaats(11.0f,status.vrij),
                new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.vrij), new zitPlaats(10.0f,status.bezet), new zitPlaats(10.0f,status.bezet)
            };*/
            for (int i = 0; i < 48; i++)
            {
                var stoel = vindStoel(i);
                updateKleur(stoel);
                updatePrijs(stoel);
            }
            basisPrijs = 0.0f;
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
            tabControl1.SelectTab(4);
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

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStoel00_Click(object sender, EventArgs e)
        {
            Tuple<int, int> stoel;
            int nummer;
            Button senderButton = sender as Button;

            //krijg het stoelnummer uit de naam van de button
            string nummerString = senderButton.Name.Substring(startIndex: 11, length: 2);
            //verander dit stoelnummer naar een int
            Int32.TryParse(nummerString, out nummer);
            /*stoel = stoelLocatie(nummer,12);
            MessageBox.Show("click op stoel "+stoel.Item1.ToString()+" - "+stoel.Item2.ToString());*/

            //verkrijg de huidige stoelstatus
            status stoelStatus = stoelGrid[nummer].seatStatus;

            switch (stoelStatus)
            {
                case status.vrij:
                    {
                        stoelStatus = status.keuze;
                        stoelGrid[nummer] = new zitPlaats(stoelGrid[nummer].seatPrijs, stoelStatus);
                        break;
                    }
                case status.keuze:
                    {
                        stoelStatus = status.vrij;
                        stoelGrid[nummer] = new zitPlaats(stoelGrid[nummer].seatPrijs, stoelStatus);
                        break;
                    }
            }
            updateKleur(senderButton);
            updatePrijs();
        }

        private void textBoxKorting_TextChanged(object sender, EventArgs e)
        {
            updatePrijs();
            for (int i = 0; i < 48; i++)
            {
                var stoel = vindStoel(i);
                updatePrijs(stoel);
            }
        }

        private void buttonBetalen_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.Controls["tabPageBetalen"] as TabPage;
        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void ButtonMaps_Click(object sender, EventArgs e)
        {
            if (PictureMaps.Visible== false)
            {
                PictureMaps.Visible = true;
            }
            else
            {
                PictureMaps.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
