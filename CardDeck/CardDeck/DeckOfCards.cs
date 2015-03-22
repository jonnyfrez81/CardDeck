using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck
{
    class DeckOfCards
    {

        private Card[] deck;
        private int AMOUNT_OF_CARDS = 52;
        private int currentCard = 0;


        public DeckOfCards()
        {

            string [] faces = {"Ett", "Två", "Tre", "Fyra", "Fem", "Sex", "Sju", "Åtta", "Nio", "Tio", "Knäck", "Drottning", "Kung"};
            string[] sutis = {"Spader", "Hjärter", "Dimant", "Klöver" };

            deck = new Card[AMOUNT_OF_CARDS];

            for (int count = 0; count < AMOUNT_OF_CARDS; count++)
            {

                deck[count] = new Card(faces[count % 13], sutis[count / 13]);

                Console.WriteLine(deck[count]);
                

            }


        }


    }
}
