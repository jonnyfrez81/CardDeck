using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck
{
    class Card
    {

        private string face;
        private string suits;

        public Card(string face, string suits)
        {

            this.face = face;
            this.suits = suits;


        }



        public override string ToString()
        {
            return face + " av " + suits;
        }

    }
}
