namespace Solitaire.Card
{
	public class Card
	{
		public static char PrintValue (Value v)
		{
			switch (v) {
				case Value.TWO: 	return '2';
				case Value.THREE: 	return '3';
				case Value.FOUR: 	return '4';
				case Value.FIVE: 	return '5';
				case Value.SIX: 	return '6';
				case Value.SEVEN: 	return '7';
				case Value.EIGHT: 	return '8';
				case Value.NINE: 	return '9';
				case Value.TEN: 	return '\u2169';
				case Value.JACK: 	return 'J';
				case Value.QUEEN: 	return 'Q';
				case Value.KING: 	return 'K';
				case Value.ACE: 	return 'A';
				default: 			return '?';
			}

		}

		public static char PrintSuit (Suit s)
		{
			switch (s) {
				case Suit.HEARTS:  	 return '\u2665';
				case Suit.DIAMONDS:  return '\u2666';
				case Suit.CLUBS: 	 return '\u2663';
				case Suit.SPADES:	 return '\u2660';
				default: 			 return '?';

			}
		}

		public enum Suit 
		{
			HEARTS,
			DIAMONDS,
			CLUBS,
			SPADES		
		}

		public enum Value 
		{
			TWO,
			THREE,
			FOUR,
			FIVE,
			SIX,
			SEVEN,
			EIGHT,
			NINE,
			TEN,
			JACK,
			QUEEN,
			KING,
			ACE
		}

		public Value CardValue {get; set;}
		public Suit CardSuit {get; set;}

		public Card ( Value _cardValue, Suit _cardSuit ) 
		{
			CardValue = _cardValue;
			CardSuit  = _cardSuit;
		}

		public override string ToString ()
		{
			return $"[{PrintValue(CardValue)}{PrintSuit(CardSuit)}]";
		}

	}
}