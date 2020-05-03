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
    public partial class Agenda : Form
    {
        List<Panel> panels = new List<Panel>();
        FlowLayoutPanel filmPanel = new FlowLayoutPanel();
        int aantalFilms = 3;

        public Agenda()
        {
            InitializeComponent();
        }
        
        public void createNewFilm(int amountOfFilms)
        {
            TextBox textBox1 = new TextBox();
            Label label1 = new Label();
            Panel panel = new Panel();
            panel.Location = new Point(5,5 + 300 * amountOfFilms);
            panel.Size = new Size(540, 280);
            panel.Controls.Add(textBox1);
            panel.Controls.Add(label1);
            
            panel.BackColor = SystemColors.Control;
            label1.Text = "label " + amountOfFilms.ToString();
            panels.Add(panel);



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
                filmPanel.Controls.Add(newPanel);
            }
            // Add the Label and TextBox controls to the Panel.
           
        }
        
       
        private void Agenda_Load(object sender, EventArgs e)
        {
            filmPanel.AutoScroll = true;
            filmPanel.Location = new Point(12, 135);
            Color white = Color.FromName("White");
            filmPanel.BackColor = white;
            filmPanel.Size = new Size(550, 300 * aantalFilms);
            
            this.Controls.Add(filmPanel);
            for (int i = 0; i < aantalFilms; i++)
            {
                
                createNewFilm(i);
                
            }
        }
    }
}
