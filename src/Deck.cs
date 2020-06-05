using System;

namespace Solitaire.CardDeck
{
	public class CardDeck
	{


		public Card[] Deck {get; set;}

		public CardDeck (bool shuffled = false) {
			Deck = GenerateDeck();

			if (shuffled) Shuffle (Deck);
		}

		public static Card[] GenerateDeck ()
		{
			Card[] Deck = new Card[52];
			int c = 0;

			// Iterate over each enum value for suit and suit value
			foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit))) {
				foreach (Card.Value val in Enum.GetValues(typeof(Card.Value))) {
					Deck[c] = new Card (val, suit);
					c++;
				}
			}

			return Deck;
		}

		public static void Shuffle (Card[] deck)
		{
			Random rand = new Random();

			for (int i=0; i < deck.Length; i++) {
				int randIndex = rand.Next(52);
				Card temp = deck[randIndex];

				deck[randIndex] = deck[i];
				deck[i] = temp;
			}
		}

		public void PrintDeck()
		{
			for (int i=0; i < Deck.Length; i++) {
					if (i % 13 == 0)
						Console.WriteLine ();
					Console.Write (Deck[i].ToString());
			}
			Console.WriteLine ();
		}

	}
}