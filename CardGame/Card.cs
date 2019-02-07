
namespace CardGame
{
    public class Card
    {
        private string face;
        private string suit; 
        public int value;

        public Card(string cardFace, string cardSuit, int cardValue)
        {
            face = cardFace;
            suit = cardSuit;
            value = cardValue;
        }

        //Smooth console output
        public override string ToString()
        {
            return face + " of " + suit;
        }
    }
}
