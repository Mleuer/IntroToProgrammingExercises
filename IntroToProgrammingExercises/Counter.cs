using System.Runtime.Serialization;
using System;
using static System.Math;

namespace IntroToProgrammingExercises
{
    public class Counter
    {
        
        
//        For this problem, you should write a very simple but complete class. 
//        The class represents a counter that counts 0, 1, 2, 3, 4, . . . . 
//        The name of the class should be Counter. 
//        It has one private instance variable representing the value of the counter. 
//        It has two instance methods: increment() adds one to the counter value, and getValue() 
//        returns the current counter value.
//        Write a complete definition for the class, Counter.

        private int value = 0;

        public int GetValue
        {
            get => value;
            set => this.value = value;
        }

        public void Increment()
        {
            value++;
        }
        
    }
}
    
