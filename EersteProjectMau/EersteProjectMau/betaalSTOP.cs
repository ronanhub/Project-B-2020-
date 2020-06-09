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
    public partial class betaalStop : Form
    {
        public betaalStop(string tekst)
        {
            InitializeComponent();
            labello.Text = tekst;
        }

        private void knopperd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
