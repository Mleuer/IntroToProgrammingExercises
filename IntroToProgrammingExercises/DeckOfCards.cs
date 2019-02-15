using System;

namespace IntroToProgrammingExercises
{
   public class Card {
       
       /**
        * This card's suit, one of the constants SPADES, HEARTS, DIAMONDS,
        * CLUBS, or JOKER.  The suit cannot be changed after the card is
        * constructed.
        */
       private readonly Suit suit; 
       
       /**
        * The card's value.  For a normal cards, this is one of the values
        * 1 through 13, with 1 representing ACE.  For a JOKER, the value
        * can be anything.  The value cannot be changed after the card
        * is constructed.
        */
       private readonly CardValue value;
       
       /**
        * Creates a Joker, with 1 as the associated value.  (Note that
        * "new Card()" is equivalent to "new Card(1,Card.JOKER)".)
        */
//       public Card() {
//          suit = Suit.Hearts;
//          value = CardValue.
//       }
       
       /**
        * Creates a card with a specified suit and value.
        * @param theValue the value of the new card.  For a regular card (non-oker),
        * the value must be in the range 1 through 13, with 1 representing an Ace.
        * You can use the constants Card.ACE, Card.JACK, Card.QUEEN, and Card.KING.  
        * For a Joker, the value can be anything.
        * @param theSuit the suit of the new card.  This must be one of the values
        * Card.SPADES, Card.HEARTS, Card.DIAMONDS, Card.CLUBS, or Card.JOKER.
        * @throws IllegalArgumentException if the parameter values are not in the
        * permissable ranges
        */
       public Card(ushort theValue, ushort theSuit) {
          if (theSuit < (ushort)Suit.Hearts || theSuit > (ushort)Suit.Clubs) 
             throw new InvalidOperationException("Illegal playing card suit");
          if (theValue < (ushort)CardValue.ace || theValue > (ushort)CardValue.king)
             throw new InvalidOperationException("Illegal playing card value");
          value = (CardValue)theValue;
          suit = (Suit)theSuit;
       }
    
       /**
        * Returns the suit of this card.
        * @returns the suit, which is one of the constants Card.SPADES, 
        * Card.HEARTS, Card.DIAMONDS, Card.CLUBS, or Card.JOKER
        */
       public Suit getSuit() {
          return suit;
       }
       
       /**
        * Returns the value of this card.
        * @return the value, which is one the numbers 1 through 13, inclusive for
        * a regular card, and which can be any value for a Joker.
        */
       public CardValue getValue() {
          return value;
       }
       
       /**
        * Returns a String representation of the card's suit.
        * @return one of the strings "Spades", "Hearts", "Diamonds", "Clubs"
        * or "Joker".
        */
       public String getSuitAsString() {
          switch ( suit ) 
          {
          case Suit.Spades:   return "Spades";
          case Suit.Hearts:   return "Hearts";
          case Suit.Diamonds: return "Diamonds";
          case Suit.Clubs:    return "Clubs";
          default:       return "Joker";
          }
       }
       
       /**
        * Returns a String representation of the card's value.
        * @return for a regular card, one of the strings "Ace", "2",
        * "3", ..., "10", "Jack", "Queen", or "King".  For a Joker, the 
        * string is always a numerical.
//        */
//       public String getValueAsString() {
//          
//             switch ( value ) {
//             case 1:   return "Ace";
//             case 2:   return "2";
//             case 3:   return "3";
//             case 4:   return "4";
//             case 5:   return "5";
//             case 6:   return "6";
//             case 7:   return "7";
//             case 8:   return "8";
//             case 9:   return "9";
//             case 10:  return "10";
//             case 11:  return "Jack";
//             case 12:  return "Queen";
//             default:  return "King";
//             
//          }
//       }
       
       /**
        * Returns a string representation of this card, including both
        * its suit and its value (except that for a Joker with value 1,
        * the return value is just "Joker").  Sample reutrn values
        * are: "Queen of Hearts", "10 of Diamonds", "Ace of Spades",
        * "Joker", "Joker #2"
        */

   }

   public enum Suit : ushort 
   {
      Hearts = 0,
      Diamonds = 1,
      Spades = 2,
      Clubs = 3
   }
   public enum CardValue : ushort
   {
      ace = 1,
      two = 2,
      three = 3,
      four = 4,
      five = 5,
      six = 6,
      seven = 7,
      eight = 8,
      nine = 9,
      ten = 10,
      jack = 11,
      queen = 12,
      king = 13
   }
   
   
   
}