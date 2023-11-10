using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    internal class Deck
    {

        public List<Card> Cards { get; set; }


        //get next card

        public Card DrawCard()
        {
            Card card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }


        //create deck

        public Deck()
        {
            Cards = new List<Card>();

            //create 52 cards
            string[] faces = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Spades", "Diamonds", "Clubs" };

            for (int i = 0; i < 4; i++) //suits
            {
                for (int j = 0; j < 13; j++)  //faces
                {
                    Card c1 = new Card() { Face = faces[j], Suit = suits[i] };
                    Cards.Add(c1);
                }
            }



        }

        public void DisplayCards()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine($"{card.Face} of {card.Suit}");
            }
        }

        //shuufle deck
        public void shuffleDeck()
        {
            Random rng = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
        }

        


    }

    internal class Card
    {

        public string Face { get; set; }  //Ace, 2, 3... Jack...
        public string Suit { get; set; }  //spades, diamonds etc

        public int Value { get; set; }

        string[] faces = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        string[] suits = { "Hearts", "Spades", "Diamonds", "Clubs" };
    }
    internal class Hand
    {
        private List<Card> cards; 
        
        public string Suit { get; set; }  //spades, diamonds etc

        public string Face { get; set; }  //Ace, 2, 3... Jack...

        public int Value { get; set; }


        string[] faces = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        string[] suits = { "Hearts", "Spades", "Diamonds", "Clubs" };

        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }
        public int GetTotal()
        {
            //Face = faces[rng.Next(0, 13)];
            //Suit = suits[rng.Next(0, 4)];
            int total = 0;  
            int numAces=0;

            foreach (Card card in cards)
            {
                if (Face == "Jack" || Face == "Queen" || Face == "King")
                {
                    Value = 10;
                }
                else if (Face == "Ace")
                {
                    Value = 11;
                }
                else
                {
                    Value = int.Parse(Face);
                }
            }

        }
        public override string ToString()
        {
            return $"{Face} of  {Suit}";
        }

    }
    
}
