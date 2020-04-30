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
        // HelpKnop
        private object tabControl;
        Help_On_OFF helpKnop = new Help_On_OFF();
        private FlowLayoutPanel filmPanel;
        public void Help_Open_Sluit()
        {

            tabControl2.Visible = helpKnop.Screen;
            helpKnop.Turn_ON_or_OFF();
            openHelp.Text = (tabControl2.Visible == false) ? "OPEN HELP" : "SLUIT HELP";
            tabControl1.Size = (tabControl2.Visible == false) ? new Size(1231, 510) : new Size(923, 510);
            antwoorden.Size = (tabControl2.Visible == false) ? new Size(631, 255) : new Size(331, 455);

            stuurVraag2.Location = (tabControl2.Visible == false) ? new Point(1000, 402) : new Point(1, 1);
            stuurVraag2.Visible = (tabControl2.Visible == false) ? true : false;
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

        public List<Tuple<float, status>> stoelGrid;
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

            switch (stoelGrid[nummer].Item2)
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

            button.Text = "€" + prijstString(stoelGrid[nummer].Item1 * checkKortingscode(textBoxKorting.Text));//(stoelGrid[nummer].Item1*checkKortingscode(textBoxKorting.Text)).ToString();
        }
        public void updatePrijs()
        {
            basisPrijs = 0.0f;
            for (int i = 0; i < 48; i++)
            {
                if (stoelGrid[i].Item2 == status.keuze)
                {
                    basisPrijs += stoelGrid[i].Item1;
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
            //huidig.Visible = true;
            //huidig.Location = new Point(xLoc, yLoc);
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
            antwoorden.Text = shownAntwoord;
        }


        Vragen vraag1 = new Vragen(Vraag_Antwoord_Loc_1.Item1, Vraag_Antwoord_Loc_1.Item2, Vraag_Antwoord_Loc_1.Item3);
        Vragen vraag2 = new Vragen(Vraag_Antwoord_Loc_2.Item1, Vraag_Antwoord_Loc_2.Item2, Vraag_Antwoord_Loc_2.Item3);

        public HomePage()
        {
            InitializeComponent();
            //het maken van de stoelgrid met prijzen en status van stoel
            stoelGrid = new List<Tuple<float, status>> {
                new Tuple<float,status>(10.8f,status.vrij), new Tuple<float,status>(10.000f,status.vrij), new Tuple<float,status>(10.0000f,status.vrij), new Tuple<float,status>(10.0f,status.vrij),
                new Tuple<float,status>(11.10f,status.vrij), new Tuple<float,status>(11.1f,status.bezet), new Tuple<float,status>(11.12f,status.vrij), new Tuple<float,status>(11.10f,status.vrij),
                new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij),

                new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.bezet), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij),
                new Tuple<float,status>(11.0f,status.bezet), new Tuple<float,status>(11.0f,status.vrij), new Tuple<float,status>(11.0f,status.vrij), new Tuple<float,status>(11.0f,status.vrij),
                new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij),

                new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij),
                new Tuple<float,status>(11.0f,status.vrij), new Tuple<float,status>(11.0f,status.vrij), new Tuple<float,status>(11.0f,status.vrij), new Tuple<float,status>(11.0f,status.vrij),
                new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij),

                new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij),
                new Tuple<float,status>(11.0f,status.vrij), new Tuple<float,status>(11.0f,status.vrij), new Tuple<float,status>(11.0f,status.vrij), new Tuple<float,status>(11.0f,status.vrij),
                new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.bezet), new Tuple<float,status>(10.0f,status.bezet)
            };
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

        

        private void homeButton_Click(object sender, EventArgs e)
        {
            
            tabControl1.SelectTab(0);
            tabControl2.SelectTab(0);
        }

        private void agendaButton_Click(object sender, EventArgs e)
        {
            int aantalFilms = 3;
            tabControl1.SelectTab(1);
            tabControl2.SelectTab(1);

            filmPanel = new FlowLayoutPanel();
            filmPanel.Location = new Point(0,0);
            Color black = Color.FromName("Black");
            filmPanel.BackColor = black;
            filmPanel.Size = new Size(900, 410 * aantalFilms);


            tabPage2.Controls.Add(filmPanel);


            for (int i = 0; i < aantalFilms; i++)
            {

                createNewFilm(i);

            }
        }

        public void createNewFilm(int amountOfFilms)
        {
            List<Panel> panels = new List<Panel>();
            String[] films = { "Dunkirk", "1917", "Op hoop \nvan zegen" };

            Label label1 = new Label();
            Panel panel = new Panel();
            PictureBox filmPhoto = new PictureBox();
            filmPhoto.Location = new Point(500, 50);
            panel.Controls.Add(filmPhoto);
            filmPhoto.Size = new Size(400, 600);
            filmPhoto.LoadAsync(@"C:\palace.jpg");
            panel.Size = new Size(895, 400);
            panel.Controls.Add(label1);
            Color white = Color.FromName("White");
            panel.BackColor = white;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 35);
            label1.Location = new Point(70, 50);
            label1.Text = films[amountOfFilms];
            panels.Add(panel);
            filmPanel.Controls.Add(panel);


            // Initialize the Panel control.
            //panels[amountOfFilms].Location = new Point(10, 72 * amountOfFilms);
            //panels[amountOfFilms].Size = new Size(264, 152);
            // Set the Borderstyle for the Panel to three-dimensional.
            //panels[amountOfFilms].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            // Initialize the Label and TextBox controls.
            //label1.Location = new Point(16, 16);

            //label1.Size = new Size(104, 16);
            //textBox1.Location = new Point(16, 32);
            //textBox1.Text = "";
            //textBox1.Size = new Size(152, 20);

            // Add the Panel control to the form.
            foreach (Panel newPanel in panels)
            {
                //filmPanel.Controls.Add(newPanel);
            }
            // Add the Label and TextBox controls to the Panel.

        }


        private void Agenda_Load(object sender, EventArgs e)
        {
            
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
            status stoelStatus = stoelGrid[nummer].Item2;

            switch (stoelStatus)
            {
                case status.vrij:
                    {
                        stoelStatus = status.keuze;
                        stoelGrid[nummer] = new Tuple<float, status>(stoelGrid[nummer].Item1, stoelStatus);
                        break;
                    }
                case status.keuze:
                    {
                        stoelStatus = status.vrij;
                        stoelGrid[nummer] = new Tuple<float, status>(stoelGrid[nummer].Item1, stoelStatus);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
