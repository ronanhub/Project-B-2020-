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
    public partial class HomePage : Form
    {
        MailMessage msg;
        private FlowLayoutPanel filmPanel;




        Help_On_OFF helpKnop = new Help_On_OFF();
        public void Help_Open_Sluit()
        {
            
            tabControl2.Visible = helpKnop.Screen;
            helpKnop.Turn_ON_or_OFF();
            openHelp.Text = (tabControl2.Visible == false) ? "OPEN HELP" : "SLUIT HELP";
            tabControl1.Size = (tabControl2.Visible == false) ? new Size(1231, 510) : new Size(923, 510);

            vragenPaneel.Size = (tabControl2.Visible == false) ? new Size(629, 401) : new Size(529, 401);
            faqsplitter.Location = (tabControl2.Visible == false) ? new Point(652, 12) : new Point(552, 15); 

            antwoorden.Location = (tabControl2.Visible == false) ? new Point(677, 12) : new Point(577, 12);
            antwoorden.Size = (tabControl2.Visible == false) ? new Size(531, 375) : new Size(331, 455);

            stuurVraag2.Location = (tabControl2.Visible == false) ? new Point(1000, 402) : new Point(1, 1);
            stuurVraag2.Visible = (tabControl2.Visible == false) ? true : false;
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














        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@FAQFAQFAQFAQFAQFAQFAQFAQFAQFAQ@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_1 = new Tuple<string, string, Tuple<int, int>>
          /* Vraag */                    ("Hoe kom ik bij de bioscoop?",
          /* Antwoord */                  "Stap 1: Druk op contact knop in het menu." +
                                          "\n\n" +
                                          "Stap 2: Druk op de kaart knop." +
                                          "\n\n" +
                                          "Stap 3: Ga naar het adres toe" +
                                          "\n\n" +
                                          "Stap 4: ????" +
                                          "\n\n" +
                                          "Stap 5: profit",
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

        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_3 = new Tuple<string, string, Tuple<int, int>>
          /* Vraag */                    ("Kan ik geld terug krijgen?",
          /* Antwoord */                  "Nee.",
          /* ID */                        Tuple.Create(2, 53));

        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_4 = new Tuple<string, string, Tuple<int, int>>
         /* Vraag */                      ("Mag ik een ticket 2x gebruiken?",
         /* Antwoord */                   "Tickets groeien niet aan de bomen",
          /* ID */                         Tuple.Create(2, 95));

        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_5 = new Tuple<string, string, Tuple<int, int>>
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

        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_6 = new Tuple<string, string, Tuple<int, int>>
         /* Vraag */                      ("Is het mogelijk om senioren korting te krijgen?",
         /* Antwoord */                   "Ben je serieus?",
          /* ID */                         Tuple.Create(2, 95));

        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_7 = new Tuple<string, string, Tuple<int, int>>
          /* Vraag */                    ("Is het eten en drinken gratis?",
          /* Antwoord */                  "In uw dromen.",
          /* ID */                        Tuple.Create(2, 53));

        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_8 = new Tuple<string, string, Tuple<int, int>>
         /* Vraag */                      ("Iphone of android?",
         /* Antwoord */                   "Mandroid >>>>> saaiphone",
          /* ID */                         Tuple.Create(2, 95));


        static Tuple<string, string, Tuple<int, int>> Vraag_Antwoord_Loc_9 = new Tuple<string, string, Tuple<int, int>>
         /* Vraag */                      ("Mijn vraag 9?",
         /* Antwoord */                   "Stap 1: ASDASDSDASD?" +
                                          "\n\n" +
                                          "Stap 2: ADSSADASD?" +
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
        Vragen vraag3 = new Vragen(Vraag_Antwoord_Loc_3.Item1, Vraag_Antwoord_Loc_3.Item2, Vraag_Antwoord_Loc_3.Item3);
        Vragen vraag4 = new Vragen(Vraag_Antwoord_Loc_4.Item1, Vraag_Antwoord_Loc_4.Item2, Vraag_Antwoord_Loc_4.Item3);
        Vragen vraag5 = new Vragen(Vraag_Antwoord_Loc_5.Item1, Vraag_Antwoord_Loc_5.Item2, Vraag_Antwoord_Loc_5.Item3);
        Vragen vraag6 = new Vragen(Vraag_Antwoord_Loc_6.Item1, Vraag_Antwoord_Loc_6.Item2, Vraag_Antwoord_Loc_6.Item3);
        Vragen vraag7 = new Vragen(Vraag_Antwoord_Loc_7.Item1, Vraag_Antwoord_Loc_7.Item2, Vraag_Antwoord_Loc_7.Item3);
        Vragen vraag8 = new Vragen(Vraag_Antwoord_Loc_8.Item1, Vraag_Antwoord_Loc_8.Item2, Vraag_Antwoord_Loc_8.Item3);
        Vragen vraag9 = new Vragen(Vraag_Antwoord_Loc_9.Item1, Vraag_Antwoord_Loc_9.Item2, Vraag_Antwoord_Loc_9.Item3);



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

            for(int l = 0;l< stoelLijst.Count;l++)
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

            this.ActiveControl = label1;

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
                        stoelGrid[nummer] = new Tuple<float,status,string>(stoelGrid[nummer].Item1, stoelStatus, "");
                        break;
                    }
                case status.keuze:
                    {
                        stoelStatus = status.vrij;
                        stoelGrid[nummer] = new Tuple<float,status,string>(stoelGrid[nummer].Item1, stoelStatus, "");
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
            changeTextbox(vraag1.Antwoord);
        }
        private void Vraag2label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag2.Antwoord);
        }
        private void Vraag3label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag3.Antwoord);
        }
        private void Vraag4label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag4.Antwoord);
        }
        private void Vraag5label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag5.Antwoord);
        }
        private void Vraag6label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag6.Antwoord);
        }
        private void Vraag7label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag7.Antwoord);
        }
        private void Vraag8label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag8.Antwoord);
        }
        private void Vraag9label_Click(object sender, EventArgs e)
        {
            changeTextbox(vraag9.Antwoord);
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





        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ CONTACT CONTACT CONTACT CONTACT @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        private void ButtonMaps_Click(object sender, EventArgs e)
        {
            if (PictureMaps.Visible == false)
            {
                PictureMaps.Visible = true;
            }
            else
            {
                PictureMaps.Visible = false;
            }
        }
        private void mapButton_Click(object sender, EventArgs e)
        {
            if (PictureMaps.Visible == false)
            {
                PictureMaps.Visible = true;
            }
            else
            {
                PictureMaps.Visible = false;
            }
        }
      

    

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void betalingKlaar_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox6.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox5.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox6.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox5.Checked = false;
            checkBox4.Checked = false;
            checkBox6.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }

        private void buttonBetalen1_Click(object sender, EventArgs e)
        {
            saveFilmStoelen(huidigeFilm.titel, huidigeFilm.datum, stoelGrid, "NieuweKlant");
            tabControl1.SelectedTab = tabControl1.Controls["tabPageBetalen"] as TabPage;
            labelbedragBetaal1.Text = basisPrijs.ToString();
            tabControl2.SelectTab(5);
        }

        private void buttonVorigeBetaal1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.Controls["tabPageStoelselectie"] as TabPage;
            tabControl2.SelectTab(4);
        }

        private void buttonVolgendeBetaal1_Click(object sender, EventArgs e)
        {
            
            if ((textBox1.Text == "" || textBox1.Text == "Voorbeeld@gmail.com")|| (textBox2.Text == "" || textBox2.Text == "Voornaam") || (textBox3.Text == "" || textBox3.Text == "Achternaam") || (textBox4.Text == "" || textBox4.Text == "Wijnhaven 107" )|| (textBox5.Text == "" || textBox5.Text == "0000 AA" )|| textBox6.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Voer al uw gegevens in.");
                tabControl1.SelectTab(5);
                tabControl2.SelectTab(5);
            }
            else
            {
                tabControl1.SelectTab(6);
                tabControl2.SelectTab(6);
                labelBedrag1.Text = basisPrijs.ToString();
            }

        }

        private void buttonVorigeBank1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
            tabControl2.SelectTab(5);
        }

        private void buttonVolgendeBank1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true)
            {
                tabControl1.SelectTab(7);
                tabControl2.SelectTab(7);
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == false)
            {
                MessageBox.Show("Select a bank.");
                tabControl1.SelectTab(6);
            }
            else if (checkBox5.Checked == true || checkBox6.Checked == true)
            {
                tabControl1.SelectTab(8);
                tabControl2.SelectTab(8);
            }

        }

        private void buttonBetalenFinal1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            MessageBox.Show("Betaling is gelukt.");
            tabControl2.SelectTab(0);
        }

        private void buttonVorigeFinal1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
            tabControl2.SelectTab(6);
        }

/*        private void textboxMaand1_TextChanged(object sender, EventArgs e)
        {
            if (textboxMaand1.Text == "Maand")
            {
                textboxMaand1.Text = "";
            }
        }

        private void textBoxJaar1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxJaar1.Text == "Jaar")
            {
                textBoxJaar1.Text = "";
            }
        }*/

        private void textBoxZoeken1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxZoeken1.Text == "Zoeken...")
            {
                textBoxZoeken1.Text = "";
            }
        }

        private void buttonZelfVraag1_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.ForeColor = Color.Black;
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void BetaalGegevens_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBoxNaam1.Text == "" || textBoxRekeningnummer1.Text == "" || textboxPasnummer1.Text == "")
            {
                MessageBox.Show("Vul alle gegevens in.");
            }
            else
            {
                buttonBetalenFinal1.Enabled = true;
                button1.BackColor = Color.Lime;
                buttonBetalenFinal1.BackColor = Color.Lime;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox6.Checked = false;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            MessageBox.Show("Betaling is gelukt.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Vul alle gegevens in");
            }
            else
            {
                button3.Enabled = true;
                button3.BackColor = Color.Lime;
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            MessageBox.Show("Betaling is gelukt.");
            tabControl2.SelectTab(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
            tabControl2.SelectTab(6);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void textboxPasnummer1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Voorbeeld@gmail.com")
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Black;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Black;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.Black;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ForeColor = Color.Black;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Voorbeeld@gmail.com";

            }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Voornaam")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Voornaam";
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Achternaam")
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Achternaam";
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Wijnhaven 107")
            {
                textBox4.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Wijnhaven 107";
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "0000 AA")
            {
                textBox5.Text = "";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "0000 AA";
            }
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "Rotterdam")
            {
                textBox6.Text = "";
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Rotterdam";
            }
        }


        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Nederland";
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "Nederland")
            {
                textBox6.Text = "";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.ForeColor = Color.Black;
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "Maand")
            {
                textBox9.Text = "";
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Maand";
            }
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "Jaar")
            {
                textBox11.Text = "";
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                textBox11.Text = "Jaar";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            checkBox4.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            checkBox5.Checked = true;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            checkBox6.Checked = true;
        }
    }
}
