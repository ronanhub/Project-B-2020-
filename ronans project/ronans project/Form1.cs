using System;
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
                new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij),
                new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.bezet), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij),
                new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij),

                new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.bezet), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij),
                new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij),
                new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij), new Tuple<float,status>(10.0f,status.vrij),
            };
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

        public List<Tuple<float, status>> stoelGrid;
        public enum status {
            vrij = 0,
            bezet = 1,
            keuze = 2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Close(); };
            frm.Show();
            this.Hide();
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
