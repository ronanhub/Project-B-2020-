using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EersteProjectMau
{
    public class Vragen
    {
        private string _vraag;

        public string Vraag
        {
            get
            {
                return _vraag;
            }
            set
            {

                _vraag = value;

            }
        }
        private string _antwoord;
        public string Antwoord
        {
            get
            {
                return _antwoord;
            }
            set
            {

                _antwoord = value;

            }
        }

        public Tuple<int, int> Loc;
        public Vragen(string Vraag, string Antwoord, Tuple<int, int> Loc)
        {
            this.Clicked = true;

            this.Vraag = Vraag;
            this.Antwoord = Antwoord;
            this.Loc = Loc;
        }



        // --------------------------------
        private bool _state;

        public bool Clicked
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

        private bool _color;

        public bool vraagState
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public void Turn_ON_or_OFF()
        {
            if (this.vraagState == true)
            {
                this.vraagState = false;
            }
            else if (this.vraagState == false)
            {
                this.vraagState = true;
            }
        }
    }
        
}
