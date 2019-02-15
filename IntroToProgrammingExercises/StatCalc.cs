using System;

namespace IntroToProgrammingExercises
{
    public class StatCalc
    {

        public int count { get; private set; } = 0;  // Number of numbers that have been entered.
        public double sum { get; private set; }  // The sum of all the items that have been entered.
        private double squareSum;  // The sum of the squares of all the items.
        private double max;
        private double min;
   
        /**
         * Add a number to the dataset.  The statistics will be computed for all
         * the numbers that have been added to the dataset using this method.
         */
        public void Enter(double num) {
            count++;
            sum += num;
            squareSum += num*num;

            if (count == 1)
            {
                max = num;
                min = num;
            }

            if (count > 1)
            {
                if (num > max)
                {
                    max = num;
                }

                if (num < min)
                {
                    min = num;
                }
            }
        }
   
        /**
         * Return the average of all the items that have been entered.
         * The returnvalue is Double.NaN if no numbers have been entered.
         */
        public double getMean() {
            return sum / count;  
        }
   
        /**
         * Return the standard deviation of all the items that have been entered.
         * The returnvalue is Double.NaN if no numbers have been entered.
         */
        public double getStandardDeviation() {  
            double mean = getMean();
            return Math.Sqrt( squareSum/count - mean*mean );
        }

        public double GetMax()
        {
            return max;
        }
        
        public double GetMMin()
        {
            return min;
        }
      
    }  // end class StatCalc
}