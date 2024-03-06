using System;

namespace CMP1903_A1_2324 //defines the namespace
{
    internal class Game //declares the game class
    {
        //declares and initialises private fields for each die
        private Die die1 = new Die();
        private Die die2 = new Die();
        private Die die3 = new Die();

        public void PlayGame() //declares the PlayGame method
        {
            //rolls the dice three times and stores the results
            int roll1 = die1.Roll();
            int roll2 = die2.Roll();
            int roll3 = die3.Roll();
            //prints the results of the dice rolls
            Console.WriteLine("Die 1 rolled: " + roll1);
            Console.WriteLine("Die 2 rolled: " + roll2);
            Console.WriteLine("Die 3 rolled: " + roll3);

            int total = roll1 + roll2 + roll3; //calculates the total of the dice rolls
            Console.WriteLine("Total of three rolls: " + total);//prints the total of the dice rolls
        }

        public int GetTotal() //method to get the total of the three dice rolls
        {
            return die1.FaceValue + die2.FaceValue + die3.FaceValue; //returns the sum of the face values of all three dice
        }
    }
}
