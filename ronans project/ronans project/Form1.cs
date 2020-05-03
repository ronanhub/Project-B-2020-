﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ronans_project
{
    public partial class Form1 : Form
    {
        public Form1()
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
            for (int i = 0; i < 48; i++) {
                var stoel = vindStoel(i);
                updateKleur(stoel);
                updatePrijs(stoel);
            }
            basisPrijs = 0.0f;
        }
        public void updatePrijs() {
            basisPrijs = 0.0f;
            for (int i = 0; i < 48; i++) {
                if (stoelGrid[i].Item2 == status.keuze) {
                    basisPrijs += stoelGrid[i].Item1;
                }
            }
            labelPrijs.Text = "Totaal: € "+(checkKortingscode(textBoxKorting.Text)*basisPrijs).ToString();
        }
        public void updateKleur(Button button) {
            int nummer;
            Color kleur;
            string nummerString = button.Name.Substring(startIndex: 11, length: 2);
            Int32.TryParse(nummerString, out nummer);

            switch (stoelGrid[nummer].Item2)
            {
                case status.vrij: {
                    kleur = System.Drawing.Color.Silver;
                    break;
                }
                case status.keuze: {
                    kleur = System.Drawing.Color.Green;
                    break;
                }
                case status.bezet: {
                    kleur = System.Drawing.Color.OrangeRed;
                    break;
                }
                default: {
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
                return result.Substring(0,loc+3);
            }
        }

        public Button vindStoel(int nummer) {
            string nummerString;
            if (nummer < 10) {
                nummerString = "0" + nummer.ToString();
            }
            else {
                nummerString = nummer.ToString();
            }
            var tabControl = this.Controls["tabControl1"] as TabControl;
            var tabPage = tabControl.Controls["TabPage1"] as TabPage;
            return tabPage.Controls["buttonStoel" + nummerString] as Button;
            //return this.Controls["buttonStoel" + nummerString] as Button;
        }

        public List<Tuple<float, status>> stoelGrid;

        public float basisPrijs;
        public string kortingsCode;
        public enum status {
            vrij = 0,
            bezet = 1,
            keuze = 2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            /*var frm = new Form2();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Close(); };
            frm.Show();
            this.Hide();*/
        }

        public Tuple<int, int> stoelLocatie(int nummer, int width)
        {
            int x;
            int y;
            y = nummer / (width) + 1;
            x = nummer % (width) + 1;
            return new Tuple<int,int> (x,y);
        }

        private void buttonStoel1_Click(object sender, EventArgs e)
        {
            Tuple<int, int> stoel;
            int nummer;
            Button senderButton = sender as Button;

            //krijg het stoelnummer uit de naam van de button
            string nummerString = senderButton.Name.Substring(startIndex: 11, length: 2);
            //verander dit stoelnummer naar een int
            Int32.TryParse(nummerString,out nummer);
            /*stoel = stoelLocatie(nummer,12);
            MessageBox.Show("click op stoel "+stoel.Item1.ToString()+" - "+stoel.Item2.ToString());*/
            
            //verkrijg de huidige stoelstatus
            status stoelStatus = stoelGrid[nummer].Item2;

            switch (stoelStatus)
            {
                case status.vrij: {
                    stoelStatus = status.keuze;
                    stoelGrid[nummer] = new Tuple<float, status>(stoelGrid[nummer].Item1, stoelStatus);
                    break;
                }
                case status.keuze: {
                    stoelStatus = status.vrij;
                    stoelGrid[nummer] = new Tuple<float, status>(stoelGrid[nummer].Item1, stoelStatus);
                    break;
                }
            }
            updateKleur(senderButton);
            updatePrijs();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //geeft een prijs multiplier terug
        private float checkKortingscode(string code) {
            switch(code) {
                case "kortingNU": {
                    return 0.8f;
                }
                case "korting": {
                    return 0.7f;
                }
                default: {
                    return 1.0f;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updatePrijs();
            for (int i = 0; i < 48; i++)
            {
                var stoel = vindStoel(i);
                updatePrijs(stoel);
            }
        }
    }
}
