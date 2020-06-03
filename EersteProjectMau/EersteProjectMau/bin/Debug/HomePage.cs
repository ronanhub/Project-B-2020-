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
using EersteProjectMau.Properties;

namespace EersteProjectMau
{
    public partial class HomePage : Form
    {
        MailMessage msg;
        private FlowLayoutPanel filmPanel;
        int kaartvalue = 5;
        Image betaalkBalkImage;


        Help_On_OFF helpKnop = new Help_On_OFF();
        public void Help_Open_Sluit()
        {

            tabControl2.Visible = helpKnop.Screen;
            helpKnop.Turn_ON_or_OFF();
            openHelp.Text = (tabControl2.Visible == false) ? "OPEN HELP" : "SLUIT HELP";
            tabControl1.Size = (tabControl2.Visible == false) ? new Size(1231, 510) : new Size(930, 510);

            vragenPaneel.Size = (tabControl2.Visible == false) ? new Size(629, 401) : new Size(529, 401);
            faqsplitter.Location = (tabControl2.Visible == false) ? new Point(652, 12) : new Point(552, 15);

            antwoorden.Location = (tabControl2.Visible == false) ? new Point(675, 53) : new Point(575, 53);
            huidigeVraag.Location = (tabControl2.Visible == false) ? new Point(669, 15) : new Point(569, 15);
            antwoorden.Size = (tabControl2.Visible == false) ? new Size(531, 375) : new Size(331, 455);

            kaartPanel.Size = (tabControl2.Visible == false) ? new Size(927, 494) : new Size(627, 494);

            homePoster.Size = (tabControl2.Visible == false) ? new Size(320, 479) : new Size(215, 311);
            reserveerButtonHome.Location = (tabControl2.Visible == false) ? new Point(680, 400) : new Point(703, 380);

            homePoster.Location = (tabControl2.Visible == false) ? new Point(880, 5) : new Point(692, 5);

            buttonZelfVraag2.Location = (tabControl2.Visible == false) ? new Point(1000, 402) : new Point(1, 1);
            buttonZelfVraag2.Visible = (tabControl2.Visible == false) ? true : false;
        }






        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ RESERVEREN RESERVEREN RESERVEREN RESERVEREN @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
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

        public List<Tuple<float, status, string>> stoelGrid;
        public float basisPrijs;
        public string kortingsCode;
        public float totaalPrijs;

        public class film
        {
            public string titel;
            public DateTime datum;
            public film(string filmTitel, DateTime filmDatum)
            {
                titel = filmTitel;
                datum = filmDatum;
            }
        }
        public film huidigeFilm;
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
                        kleur = System.Drawing.Color.LimeGreen;
                        break;
                    }
                case status.bezet:
                    {
                        kleur = System.Drawing.Color.Tomato;
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














        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@FAQFAQFAQFAQFAQFAQFAQFAQFAQFAQ@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_1 = new Tuple<string, string, Tuple<int, int>>
          /* Vraag */                    ("Waar is de bioscoop?",
          /* Antwoord */                  "Het adres ziet u als u op de 'Contact' knop klikt",
          /* ID */                        Tuple.Create(2, 53));

        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_2 = new Tuple<string, string, Tuple<int, int>>
         /* Vraag */                      ("Zijn de wc's gratis?",
         /* Antwoord */                   "Ja",
          /* ID */                         Tuple.Create(2, 95));

        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_3 = new Tuple<string, string, Tuple<int, int>>
          /* Vraag */                    ("Kan ik mijn ticket ruilen voor een andere film?",
          /* Antwoord */                  "Nee helaas.",
          /* ID */                        Tuple.Create(2, 53));

        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_4 = new Tuple<string, string, Tuple<int, int>>
         /* Vraag */                      ("Is het mogelijk om een hele zaal te huren?",
         /* Antwoord */                   "Daarvoor moet u speciaal contact opnemen met ons via ons telefoonnummer 0645186589",
          /* ID */                         Tuple.Create(2, 95));

        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_5 = new Tuple<string, string, Tuple<int, int>>
          /* Vraag */                    ("Zijn er pauzes midden in de film?",
          /* Antwoord */                  "Ja, om de 45 minuten houden we een pauze van 15 minuten",
          /* ID */                        Tuple.Create(2, 53));

        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_6 = new Tuple<string, string, Tuple<int, int>>
         /* Vraag */                      ("Mag een niet-senior meekomen?",
         /* Antwoord */                   "Ja zeker!",
          /* ID */                         Tuple.Create(2, 95));

        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_7 = new Tuple<string, string, Tuple<int, int>>
          /* Vraag */                    ("Is het eten en drinken gratis?",
          /* Antwoord */                  "Nee helaas, de klant moet daarvoor betalen",
          /* ID */                        Tuple.Create(2, 53));

        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_8 = new Tuple<string, string, Tuple<int, int>>
         /* Vraag */                      ("Hoe gebruik ik de kortingscode?",
         /* Antwoord */                   "Dat zult u zien tijdens het betaalproces",
          /* ID */                         Tuple.Create(2, 95));


        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_9 = new Tuple<string, string, Tuple<int, int>>
         /* Vraag */                      ("Hoe kan ik contact opnemen?",
         /* Antwoord */                   "Stap 1: Druk op 'Contact'" +
                                          "\n\n" +
                                          "Stap 2: Hier kunt u kiezen uit verschillende manieren van contact opnemen met ons",
          /* ID */                         Tuple.Create(2, 95));


        public void changeTextbox(string shownAntwoord, string shownVraag)
        {
            antwoorden.Text = shownAntwoord;
            huidigeVraag.Text = shownVraag;
        }


        Vragen vraag1 = new Vragen(Vraag_Antwoord_Loc_1.Item1, Vraag_Antwoord_Loc_1.Item2, Vraag_Antwoord_Loc_1.Item3);
        Vragen vraag2 = new Vragen(Vraag_Antwoord_Loc_2.Item1, Vraag_Antwoord_Loc_2.Item2, Vraag_Antwoord_Loc_2.Item3);
        Vragen vraag3 = new Vragen(Vraag_Antwoord_Loc_3.Item1, Vraag_Antwoord_Loc_3.Item2, Vraag_Antwoord_Loc_3.Item3);
        Vragen vraag4 = new Vragen(Vraag_Antwoord_Loc_4.Item1, Vraag_Antwoord_Loc_4.Item2, Vraag_Antwoord_Loc_4.Item3);
        Vragen vraag5 = new Vragen(Vraag_Antwoord_Loc_5.Item1, Vraag_Antwoord_Loc_5.Item2, Vraag_Antwoord_Loc_5.Item3);
        Vragen vraag6 = new Vragen(Vraag_Antwoord_Loc_6.Item1, Vraag_Antwoord_Loc_6.Item2, Vraag_Antwoord_Loc_6.Item3);
        Vragen vraag7 = new Vragen(Vraag_Antwoord_Loc_7.Item1, Vraag_Antwoord_Loc_7.Item2, Vraag_Antwoord_Loc_7.Item3);
        Vragen vraag8 = new Vragen(Vraag_Antwoord_Loc_8.Item1, Vraag_Antwoord_Loc_8.Item2, Vraag_Antwoord_Loc_8.Item3);
        Vragen vraag9 = new Vragen(Vraag_Antwoord_Loc_9.Item1, Vraag_Antwoord_Loc_9.Item2, Vraag_Antwoord_Loc_9.Item3);
        //Label huidigeVraagBovenAntwoord = new Label();



        public string fileStringMaker(string filmTitel, DateTime tijdstip, bool addExtension = false)
        {
            string returnString;

            string titelString = filmTitel.Replace(" ", "").ToLower();
            string datumString = tijdstip.Date.ToShortDateString();
            string tijdString = tijdstip.TimeOfDay.Hours.ToString() + tijdstip.TimeOfDay.Minutes.ToString();

            returnString = titelString + "_" + datumString + "_" + tijdString;
            if (addExtension)
            {
                returnString = returnString + ".csv";
            }

            return returnString;
        }

        public List<Tuple<float, status, string>> loadFilmStoelen(string filmNaam, DateTime tijdstip)
        {
            List<Tuple<float, status, string>> lijst = new List<Tuple<float, status, string>>();

            if (File.Exists(fileStringMaker(filmNaam, tijdstip, true)))
            {
                string[] data = File.ReadAllLines(fileStringMaker(filmNaam, tijdstip, true));
                List<Tuple<int, float, status, string>> stoelStringSeperated;

                for (int l = 1; l < data.Length; l++)
                {
                    string[] items = data[l].Split(';');
                    int stoelNummer;
                    float stoelPrijs;
                    status stoelStatus;
                    string stoelKoper;

                    Int32.TryParse(items[0], out stoelNummer);
                    stoelPrijs = float.Parse(items[1]);
                    switch (items[2].ToLower())
                    {
                        case "vrij":
                            stoelStatus = status.vrij;
                            break;
                        case "bezet":
                            stoelStatus = status.bezet;
                            break;
                        case "keuze":
                            stoelStatus = status.bezet;
                            break;
                        default:
                            stoelStatus = status.vrij;
                            break;
                    }
                    stoelKoper = items[3];

                    Tuple<float, status, string> newTuple = new Tuple<float, status, string>(stoelPrijs, stoelStatus, stoelKoper);
                    lijst.Add(newTuple);
                }
            }
            else
            {
                lijst = new List<Tuple<float, status, string>> {
                new Tuple<float,status,string>(10.8f,status.vrij,""), new Tuple<float,status,string>(10.000f,status.vrij,""), new Tuple<float,status,string>(10.0000f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""),
                new Tuple<float,status,string>(11.10f,status.vrij,""), new Tuple<float,status,string>(11.1f,status.vrij,""), new Tuple<float,status,string>(11.12f,status.vrij,""), new Tuple<float,status,string>(11.10f,status.vrij,""),
                new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""),

                new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""),
                new Tuple<float,status,string>(11.0f,status.vrij,""), new Tuple<float,status,string>(11.0f,status.vrij,""), new Tuple<float,status,string>(11.0f,status.vrij,""), new Tuple<float,status,string>(11.0f,status.vrij,""),
                new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""),

                new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""),
                new Tuple<float,status,string>(11.0f,status.vrij,""), new Tuple<float,status,string>(11.0f,status.vrij,""), new Tuple<float,status,string>(11.0f,status.vrij,""), new Tuple<float,status,string>(11.0f,status.vrij,""),
                new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""),

                new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""),
                new Tuple<float,status,string>(11.0f,status.vrij,""), new Tuple<float,status,string>(11.0f,status.vrij,""), new Tuple<float,status,string>(11.0f,status.vrij,""), new Tuple<float,status,string>(11.0f,status.vrij,""),
                new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,"")
                };
            }
            return lijst;
        }

        public void saveFilmStoelen(string filmNaam, DateTime tijdstip, List<Tuple<float, status, string>> stoelLijst, string klantnaam)
        {

            List<string> Data = new List<string>();
            Data.Add("Stoel;Prijs;Status;Klant");

            for (int l = 0; l < stoelLijst.Count; l++)
            {
                if (stoelLijst[l].Item2 == status.keuze)
                {
                    Data.Add((l).ToString() + ";" + stoelLijst[l].Item1.ToString() + ";" + status.bezet.ToString() + ";" + klantnaam);
                }
                else
                {
                    Data.Add((l).ToString() + ";" + stoelLijst[l].Item1.ToString() + ";" + stoelLijst[l].Item2.ToString() + ";" + stoelLijst[l].Item3);
                }
            }

            File.WriteAllLines(fileStringMaker(filmNaam, tijdstip, true), Data);
        }

        //@@@@@@@@@@@@@@@@@@@ HET PROGRAMMA BEGNINT HIER @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        public HomePage()
        {

            InitializeComponent();
            //het maken van de stoelgrid met prijzen en status van stoel
            stoelGrid = loadFilmStoelen("12 Years A Slave", new DateTime(2020, 2, 21, 16, 30, 0));/*new List<Tuple<float, status, string>> {
                new Tuple<float,status,string>(10.8f,status.vrij,""), new Tuple<float,status,string>(10.000f,status.vrij,""), new Tuple<float,status,string>(10.0000f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""),
                new Tuple<float,status,string>(11.10f,status.vrij,""), new Tuple<float,status,string>(11.1f,status.bezet,"klantnaam"), new Tuple<float,status,string>(11.12f,status.vrij,""), new Tuple<float,status,string>(11.10f,status.vrij,""),
                new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""),

                new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.bezet,"klantnaam"), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""),
                new Tuple<float,status,string>(11.0f,status.bezet,"klantnaam"), new Tuple<float,status,string>(11.0f,status.vrij,""), new Tuple<float,status,string>(11.0f,status.vrij,""), new Tuple<float,status,string>(11.0f,status.vrij,""),
                new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""),

                new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""),
                new Tuple<float,status,string>(11.0f,status.vrij,""), new Tuple<float,status,string>(11.0f,status.vrij,""), new Tuple<float,status,string>(11.0f,status.vrij,""), new Tuple<float,status,string>(11.0f,status.vrij,""),
                new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""),

                new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""),
                new Tuple<float,status,string>(11.0f,status.vrij,""), new Tuple<float,status,string>(11.0f,status.vrij,""), new Tuple<float,status,string>(11.0f,status.vrij,""), new Tuple<float,status,string>(11.0f,status.vrij,""),
                new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.vrij,""), new Tuple<float,status,string>(10.0f,status.bezet,"klantnaam"), new Tuple<float,status,string>(10.0f,status.bezet,"klantnaam")
            };*/
            for (int i = 0; i < 48; i++)
            {
                var stoel = vindStoel(i);
                updateKleur(stoel);
                updatePrijs(stoel);
            }
            basisPrijs = 0.0f;

            msg = new MailMessage();


        }


        Image ZoomPicture(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width / 5), Convert.ToInt32(img.Height * size.Height / 5));
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
        }

        PictureBox org;

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
            Vraag3label.Text = vraag3.Vraag;
            Vraag4label.Text = vraag4.Vraag;
            Vraag5label.Text = vraag5.Vraag;
            Vraag6label.Text = vraag6.Vraag;
            Vraag7label.Text = vraag7.Vraag;
            Vraag8label.Text = vraag8.Vraag;
            Vraag9label.Text = vraag9.Vraag;

            this.ActiveControl = homeTitel;


            this.DoubleBuffered = true;
            org = new PictureBox();
            org.Image = kaartBox.Image;
            kaartBox.Image = ZoomPicture(org.Image, new Size(5, 5));

        }

        private void openHelp_Click_1(object sender, EventArgs e)
        {
            Help_Open_Sluit();
        }






        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ AGENDA AGENDA AGENDA AGENDA @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@


        /*public void createNewFilm(int amountOfFilms)
        {
            List<Panel> panels = new List<Panel>();
            String[] films = { "Dunkirk", "1917", "Op hoop \nvan zegen" };
            String[] filmdesc = { 
                "Dunkirk start als honderdduizenden Britse en \ngeallieerde soldaten omsingeld zijn door vijandelijke \ntroepen. Gevangen op het strand met hun rug naar de zee \nstaan ze voor een onmogelijke situatie als de vijand \ndichterbij komt.",
            "Van Oscar®winnende regisseur Sam Mendes \n(Skyfall, Spectre, American Beauty) komt \neen meeslepend oorlogsdrama over de \nEerste Wereldoorlog; 1917.",
                "Op hoop van zegen is een film uit 1986, gebaseerd \nop het gelijknamige sociaal-kritische toneelstuk \nvan Herman Heijermans uit 1900. De film gaat over de \nzware omstandigheden van de vissers en hun families \ndie slechts instrumenten waren in de handen van op winst \nbeluste reders." };
            String[] fotoArray = {@"C:\Dunkirk_Clean.jpg", @"C:\1917_clean.jpeg", @"C:\ohvz.jpg" };
            Button reserveerbutton = new Button();
            Label label1 = new Label();
            Label label2 = new Label();
            Label label3 = new Label();
            Panel panel = new Panel();
            PictureBox filmPhoto = new PictureBox();
            filmPhoto.Location = new Point(600, 20);
            panel.Controls.Add(filmPhoto);
            filmPhoto.Size = new Size(250, 300);
            filmPhoto.LoadAsync(fotoArray[amountOfFilms]);
            panel.Size = new Size(895, 400);
            panel.Controls.Add(label1);
            panel.Controls.Add(label2);
            panel.Controls.Add(label3);
            panel.Controls.Add(reserveerbutton);
            Color white = Color.FromName("White");
            panel.BackColor = white;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 35);
            label1.Location = new Point(70, 50);
            label1.Text = films[amountOfFilms];
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15);
            if (amountOfFilms != 2)
            {
                label2.Location = new Point(80, 120);
            } else
            {
                label2.Location = new Point(80, 160);
            }
            label2.Text = filmdesc[amountOfFilms];
            label2.Size = new Size(300, 400);
            reserveerbutton.Location = new Point(625, 330);
            reserveerbutton.Size = new Size(200, 50);
            reserveerbutton.Text = "Reserveer nu!";
            reserveerbutton.Click += new EventHandler(reserveerbutton_Click);
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
            
        }*/


        private void reserveerbutton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
            tabControl2.SelectTab(4);
        }



        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@RESERVEREN RESERVEREN RESERVEREN RESERVEREN@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
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
                        stoelGrid[nummer] = new Tuple<float, status, string>(stoelGrid[nummer].Item1, stoelStatus, "");
                        break;
                    }
                case status.keuze:
                    {
                        stoelStatus = status.vrij;
                        stoelGrid[nummer] = new Tuple<float, status, string>(stoelGrid[nummer].Item1, stoelStatus, "");
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






        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ NAVIGATIE NAVIGATIE NAVIGATIE NAVIGATIE @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        private void homeButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            tabControl2.SelectTab(0);
        }

        private void agendaButton1_Click(object sender, EventArgs e)
        {
            int aantalFilms = 3;
            tabControl1.SelectTab(1);
            tabControl2.SelectTab(1);
            /*
            filmPanel = new FlowLayoutPanel();
            filmPanel.Location = new Point(0, 0);
            Color black = Color.FromName("Black");
            filmPanel.BackColor = black;
            filmPanel.Size = new Size(900, 410 * aantalFilms);


            agendaPage.Controls.Add(filmPanel);


            for (int i = 0; i < aantalFilms; i++)
            {

                //createNewFilm(i);

            }*/
        }
        private void contactButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            tabControl2.SelectTab(2);
        }
        private void faqButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
            tabControl2.SelectTab(3);
        }
        private void reserveerButton1_Click(object sender, EventArgs e)
        {
            film nieuweFilm = new film("12 Years A Slave", new DateTime(2020, 2, 21, 16, 30, 0));
            naarStoelSelectie(nieuweFilm);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
            tabControl2.SelectTab(5);
        }

        public void naarStoelSelectie(film nieuweFilm)
        {
            tabControl1.SelectTab(4);
            tabControl2.SelectTab(4);
            huidigeFilm = nieuweFilm;
            stoelGrid = loadFilmStoelen(nieuweFilm.titel, nieuweFilm.datum);

            for (int i = 0; i < 48; i++)
            {
                var stoel = vindStoel(i);
                updateKleur(stoel);
                updatePrijs(stoel);
            }
            basisPrijs = 0.0f;
            labelStoelSelectieFilmTitel.Text = nieuweFilm.titel;
            labelStoelSelectieFilmDatum.Text = nieuweFilm.datum.ToString();
        }



        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ FAQ FAQ FAQ FAQ FAQ FAQ FAQ @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        private void Vraag1label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag1.Antwoord, vraag1.Vraag);
        }
        private void Vraag2label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag2.Antwoord, vraag2.Vraag);
        }
        private void Vraag3label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag3.Antwoord, vraag3.Vraag);
        }
        private void Vraag4label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag4.Antwoord, vraag4.Vraag);
        }
        private void Vraag5label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag5.Antwoord, vraag5.Vraag);
        }
        private void Vraag6label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag6.Antwoord, vraag6.Vraag);
        }
        private void Vraag7label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag7.Antwoord, vraag7.Vraag);
        }
        private void Vraag8label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag8.Antwoord, vraag8.Vraag);
        }
        private void Vraag9label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag9.Antwoord, vraag9.Vraag);
        }



        private void stuurVraagHelp_Click(object sender, EventArgs e)
        {
            StuurVraagFormcs stuurvraag = new StuurVraagFormcs();
            stuurvraag.Text = "Verstuur je vraag";


            stuurvraag.Location = this.Location;
            stuurvraag.StartPosition = FormStartPosition.CenterScreen;
            stuurvraag.Show();
        }
        private void stuurVraag2_Click(object sender, EventArgs e)
        {
            StuurVraagFormcs stuurvraag = new StuurVraagFormcs();
            stuurvraag.Text = "Verstuur je vraag";


            stuurvraag.Location = this.Location;
            stuurvraag.StartPosition = FormStartPosition.CenterScreen;
            stuurvraag.Show();
        }





        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ BETALEN BETALEN BETALEN @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@




        private void abnCheck_CheckedChanged(object sender, EventArgs e)
        {
            ingCheck.Checked = false;
            raboCheck.Checked = false;
            snsCheck.Checked = false;
            checkVisa.Checked = false;
            checkMastercard.Checked = false;

        }

        private void ingCheck_CheckedChanged(object sender, EventArgs e)
        {
            abnCheck.Checked = false;
            raboCheck.Checked = false;
            snsCheck.Checked = false;
            checkVisa.Checked = false;
            checkMastercard.Checked = false;

        }

        private void snsCheck_CheckedChanged(object sender, EventArgs e)
        {
            abnCheck.Checked = false;
            ingCheck.Checked = false;
            raboCheck.Checked = false;
            checkVisa.Checked = false;
            checkMastercard.Checked = false;

        }

        private void raboCheck_CheckedChanged(object sender, EventArgs e)
        {
            abnCheck.Checked = false;
            ingCheck.Checked = false;
            snsCheck.Checked = false;
            checkVisa.Checked = false;
            checkMastercard.Checked = false;
        }


        private void buttonVorigeBetaal1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.Controls["tabPageStoelselectie"] as TabPage;
            tabControl2.SelectTab(4);
        }

        private void buttonVolgendeBetaal1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
            tabControl2.SelectTab(6);
            labelBedrag1.Text = totaalPrijs.ToString();
        }

        private void buttonVorigeBank1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
            tabControl2.SelectTab(5);
        }

        private void buttonVolgendeBank1_Click(object sender, EventArgs e)
        {
            if (abnCheck.Checked == true || ingCheck.Checked == true || snsCheck.Checked == true || raboCheck.Checked == true)
            {
                tabControl1.SelectTab(7);
                tabControl2.SelectTab(7);
            }
            else if (checkVisa.Checked == true || checkMastercard.Checked == true)
            {
                tabControl1.SelectTab(8);
                tabControl2.SelectTab(8);
            }
            else
            {
                MessageBox.Show("Kies een bank.");
            }
        }

        private void buttonBetalenFinal1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            tabControl2.SelectTab(0);
            MessageBox.Show("Betaling is gelukt.");
        }

        private void buttonVorigeFinal1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
            tabControl2.SelectTab(6);
        }




        private void textBoxZoeken1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxZoeken1.Text == "Zoeken...")
            {
                textBoxZoeken1.Text = "";
            }
        }

        private void buttonZelfVraag2_Click(object sender, EventArgs e)
        {
            StuurVraagFormcs stuurvraag = new StuurVraagFormcs();
            stuurvraag.Text = "Verstuur je vraag";


            stuurvraag.Location = this.Location;
            stuurvraag.StartPosition = FormStartPosition.CenterScreen;
            stuurvraag.Show();
        }


        private void buttonStelZelfVraagg1_Click(object sender, EventArgs e)
        {
            StuurVraagFormcs stuurvraag = new StuurVraagFormcs();
            stuurvraag.Text = "Verstuur je vraag";


            stuurvraag.Location = this.Location;
            stuurvraag.StartPosition = FormStartPosition.CenterScreen;
            stuurvraag.Show();
        }

        private void buttonStuurMail1_Click(object sender, EventArgs e)
        {
            StuurVraagFormcs stuurvraag = new StuurVraagFormcs();
            stuurvraag.Text = "Verstuur je vraag";


            stuurvraag.Location = this.Location;
            stuurvraag.StartPosition = FormStartPosition.CenterScreen;
            stuurvraag.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            film nieuweFilm = new film("Dunkirk", new DateTime(2020, 2, 28, 16, 30, 0));
            naarStoelSelectie(nieuweFilm);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            StuurVraagFormcs stuurvraag = new StuurVraagFormcs();
            stuurvraag.Text = "Verstuur je vraag";


            stuurvraag.Location = this.Location;
            stuurvraag.StartPosition = FormStartPosition.CenterScreen;
            stuurvraag.Show();
        }

        private void plus_Click(object sender, EventArgs e)
        {

            kaartvalue += 1;
            if (kaartvalue != 0)
            {
                kaartBox.Image = null;
                kaartBox.Image = ZoomPicture(org.Image, new Size(kaartvalue, kaartvalue));
            }
        }

        private void min_Click(object sender, EventArgs e)
        {

            if (kaartvalue > 5)
            {
                kaartvalue -= 1;
                if (kaartvalue != 0)
                {
                    kaartBox.Image = null;
                    kaartBox.Image = ZoomPicture(org.Image, new Size(kaartvalue, kaartvalue));
                }
            }

        }




        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
            tabControl2.SelectTab(6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
            tabControl2.SelectTab(7);
        }






        private void meerFilmsButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            tabControl2.SelectTab(0);
        }

        private void sluitKruisButton_Click(object sender, EventArgs e)
        {
            Help_Open_Sluit();
            sluitKruisButton.Visible = false;
            openPlusButton.Visible = true;
        }

        private void openPlusButton_Click(object sender, EventArgs e)
        {
            Help_Open_Sluit();
            openPlusButton.Visible = false;
            sluitKruisButton.Visible = true;
        }

        private void gegevensButton_Click(object sender, EventArgs e)
        {
            saveFilmStoelen(huidigeFilm.titel, huidigeFilm.datum, stoelGrid, "NieuweKlant");
            tabControl1.SelectedTab = tabControl1.Controls["tabPageBetalen"] as TabPage;
            bedragBetaal2.Text = totaalPrijs.ToString();
            tabControl2.SelectTab(5);

        }

        private void BetaalPaginaGeenRobot_Click(object sender, EventArgs e)
        {
            if ((textboxPasnummer1.Text == "" || textboxPasnummer1.Text == "000") || (textBoxRekeningnummer1.Text == "" || textBoxRekeningnummer1.Text == "NL00ABNA0123456789") )
            {
                MessageBox.Show("Vul alle gegevens in.");
            }
            else if(textBoxRekeningnummer1.Text.Length != 18)
            {
                MessageBox.Show("Vul een geldig rekeningnummer in.");
            }
            else if(textboxPasnummer1.Text.Length != 3)
            {
                MessageBox.Show("Vul een geldig pasnummer in.");
            }
            else
            {
                buttonBetalenFinal1.Enabled = true;
                BetaalPaginaGeenRobot.BackColor = Color.Lime;
                buttonBetalenFinal1.BackColor = Color.Lime;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_Leave(object sender, EventArgs e)
        {

        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_Leave(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textboxPasnummer1_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (char.IsNumber(e.KeyChar) && (textboxPasnummer1.Text.Length < 3) )
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void textBoxRekeningnummer1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxRekeningnummer1.Text.Length <= 1)
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            }
            
            else if ( (textBoxRekeningnummer1.Text.Length >= 2) && (textBoxRekeningnummer1.Text.Length <= 3) )
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            
           else if ( (textBoxRekeningnummer1.Text.Length >= 4) && textBoxRekeningnummer1.Text.Length <= 7)
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            }
            else if (textBoxRekeningnummer1.Text.Length < 18)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            else
            {
                 e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void betaalVoornaam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void betaalAchternaam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void betaalPlaats_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxRekeningnummer1_Click(object sender, EventArgs e)
        {
            if ( textBoxRekeningnummer1.Text == "NL00ABNA0123456789")
            {
                textBoxRekeningnummer1.Text = "";
            }
        }

        private void textBoxRekeningnummer1_Leave(object sender, EventArgs e)
        {
            if (textBoxRekeningnummer1.Text == "")
            {
                textBoxRekeningnummer1.Text = "NL00ABNA0123456789";
            }
        }

        private void textboxPasnummer1_Click(object sender, EventArgs e)
        {
            if (textboxPasnummer1.Text == "000")
            {
                textboxPasnummer1.Text = "";
            }
        }

        private void textboxPasnummer1_Leave(object sender, EventArgs e)
        {
            if (textboxPasnummer1.Text == "")
            {
                textboxPasnummer1.Text = "000";
            }
        }

        private void betaalEmail_Click(object sender, EventArgs e)
        {
            if (betaalEmail.Text == "Voorbeeld@gmail.com")
            {
                betaalEmail.Text = "";
            }
        }

        private void betaalEmail_Leave(object sender, EventArgs e)
        {
            if (betaalEmail.Text == "")
            {
                betaalEmail.Text = "Voorbeeld@gmail.com";
            }
        }

        private void betaalVoornaam_Click(object sender, EventArgs e)
        {
            if (betaalVoornaam.Text == "Ashley")
            {
                betaalVoornaam.Text = "";
            }
        }

        private void betaalVoornaam_Leave(object sender, EventArgs e)
        {
            if (betaalVoornaam.Text == "")
            {
                betaalVoornaam.Text = "Ashley";
            }
        }

        private void betaalAchternaam_Click(object sender, EventArgs e)
        {
            if (betaalAchternaam.Text == "Bunk")
            {
                betaalAchternaam.Text = "";
            }
        }

        private void betaalAchternaam_Leave(object sender, EventArgs e)
        {
            if (betaalAchternaam.Text == "")
            {
                betaalAchternaam.Text = "Bunk";
            }
        }

        private void betaalAdres_Click(object sender, EventArgs e)
        {
            if (betaalAdres.Text == "Wijnhaven 107")
            {
                betaalAdres.Text = "";
            }
        }

        private void betaalAdres_Leave(object sender, EventArgs e)
        {
            if (betaalAdres.Text == "")
            {
                betaalAdres.Text = "Wijnhaven 107";
            }
        }

        private void betaalPostcode_Click(object sender, EventArgs e)
        {
            if (betaalPostcode.Text == "1234AB")
            {
                betaalPostcode.Text = "";
            }
        }

        private void betaalPostcode_Leave(object sender, EventArgs e)
        {
            if (betaalPostcode.Text == "")
            {
                betaalPostcode.Text = "1234AB";
            }
        }

        private void betaalPlaats_Click(object sender, EventArgs e)
        {
            if (betaalPlaats.Text == "Rotterdam")
            {
                betaalPlaats.Text = "";
            }
        }

        private void betaalPostcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (betaalPostcode.Text.Length <= 3)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            else if (betaalPostcode.Text.Length <= 5)
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void betaalLand_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void FotoABN_Click(object sender, EventArgs e)
        {
            abnCheck.Checked = true;
        }

        private void FotoSNS_Click(object sender, EventArgs e)
        {
            snsCheck.Checked = true;
        }

        private void FotoING_Click(object sender, EventArgs e)
        {
            ingCheck.Checked = true;
        }

        private void FotoRabobank_Click(object sender, EventArgs e)
        {
            raboCheck.Checked = true;
        }

        private void FotoMastercard_Click(object sender, EventArgs e)
        {
            checkMastercard.Checked = true;
        }

        private void FotoVisa_Click(object sender, EventArgs e)
        {
            checkVisa.Checked = true;
        }

        private void checkMastercard_CheckedChanged(object sender, EventArgs e)
        {
            abnCheck.Checked = false;
            ingCheck.Checked = false;
            raboCheck.Checked = false;
            snsCheck.Checked = false;
            checkVisa.Checked = false;
           
        }

        private void checkVisa_CheckedChanged(object sender, EventArgs e)
        {
            abnCheck.Checked = false;
            ingCheck.Checked = false;
            raboCheck.Checked = false;
            snsCheck.Checked = false;
            checkMastercard.Checked = false;
        }

        private void VorigeCreditcard_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
            tabControl2.SelectTab(6);
        }

        private void VolgendeCreditcard_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            tabControl2.SelectTab(0);
            MessageBox.Show("Betaling is gelukt.");
        }

        private void NaamCreditcardEigenaar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void ComboboxMaand_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void RekeningnummerCreditcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(RekeningnummerCreditcard.Text.Length <= 15)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
            
        }

        private void CvcCreditcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CvcCreditcard.Text.Length <= 2)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
    }
}
