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
    public partial class properEmail : Form
    {
        public properEmail()
        {
            InitializeComponent();
        }

        public void mailBoxText(string t)
        {
            this.ActiveControl = label1;
            jouwmail.Text = t;
        }

        private void snap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
