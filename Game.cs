using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    // Class instantiates 3 dice objects, rolling them and outputting their values and total value to the user
    class Game
    {
        private Die[] Dice = new Die[3]; // Instantiates 3 new Dice objects as an array
        private int[] diceTotal = new int[3]; // Initialises a new integer array with 3 empty elements
        private int sumOfDie; // Initialises a new integer variable to store the total value of 3 dice
        private int currentRoll; // Initialises a new integer variable to store the value of the currently rolled dice in an iterative loop

        static void Main(string[] args)
        {
            Game GameObject = new Game(); // Instantiates new Game object
            GameObject.GameMethod(); // Accesses the method within the Game object to output 3 dice values and their total to the user
            Testing TestingObject = new Testing(); // Instantiates new Testing object
            TestingObject.TestingMethod(); // Accesses the method within the Testing object to check that dice values are within a valid range.
        }

        public int[] GameMethod()
        {
            // Loop goes through each of the 3 dice objects, calls the method to roll them, stores each roll, and outputs each roll to user.
            for (int i = 0; i < 3; i++)
            {
                Dice[i] = new Die();
                currentRoll = Dice[i].Roll();
                diceTotal[i] = currentRoll;
                Console.WriteLine("Die " + i + " rolled a " + currentRoll + "!");
            }

            sumOfDie = diceTotal[0] + diceTotal[1] + diceTotal[2]; // Variable stores the sum total of the 3 dice roll values.
            Console.WriteLine("The total of the three dice is " + sumOfDie + "!");
            return diceTotal; // Returns the dice values to a Testing object
        }


    }
}
