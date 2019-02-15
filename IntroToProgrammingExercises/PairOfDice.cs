using System;

namespace IntroToProgrammingExercises
{
    public class PairOfDice 
    {
        private int die1 = 3; // Number showing on the first die.
        private int die2 = 4; // Number showing on the second die.

        public int Die1
        {
            get { return die1; }
            set { die1 = value; }
        }
        
        public int Die2
        {
            get { return die2; }
            set { die2 = value; }
        }

        public void roll()
        {// Roll the dice by setting each of the dice to be // a random number between 1 and 6.
                var random = new Random();
                random.Next();
            
                die1 = (int)(random.Next()*6) + 1;

                die2 = (int) (random.Next() * 6) + 1;
        }
    }
            
    
}