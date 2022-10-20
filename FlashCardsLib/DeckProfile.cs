namespace FlashCardsLib
{
    public class DeckProfile
    {
        public string Native { get; private set; }
        public string Learning { get; private set; }

        public uint DeckSize { get; private set; }
        public const uint MaxDeckSize = 200;

        // A Deck is a combination of cards
        // Limit?? 200?

        public List<FlashCard> Deck = new List<FlashCard>();



    }
}