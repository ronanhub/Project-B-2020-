using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EersteProjectMau
{
    class Help_On_OFF
    {
        private bool _state;

        public bool Screen
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }

        public void Turn_ON_or_OFF()
        {
            if (this.Screen == true)
            {
                this.Screen = false;
            }
            else if (this.Screen == false)
            {
                this.Screen = true;
            }
        }
    }
}
