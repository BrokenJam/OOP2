using CMP1903_A1_2324;
using System;
using System.Diagnostics;

public class SevensOut
{
    public Die[] Dice = new Die[2];
    public int sumOfDie; // Initialises a new integer variable to store the total value of 3 dice
    public int currentRoll; // Initialises a new integer variable to store the value of the currently rolled dice in an iterative loop
    public int[] diceTotal = new int[2]; // Initialises a new integer array with 2 empty elements
    public string currentPlayer = "";
    List<int> allRolls = new List<int>(); // Initialises a new integer generic collection to store all rolls for Player 1

    public int SevensOutPVE()
	{
        currentPlayer = "P1";
        while (sumOfDie != 7)
        {
            // Loop goes through each of the 2 dice objects, calls the method to roll them, stores each roll, and outputs each roll to user.
            for (int i = 0; i < 2; i++)
            {
                Dice[i] = new Die();
                currentRoll = Dice[i].Roll();
                diceTotal[i] = currentRoll;
            }
            sumOfDie = diceTotal[0] + diceTotal[1];
            Console.WriteLine("Player " + currentPlayer + "'s 2 dice rolled a total of " + sumOfDie + "!");

            // Checks which player's move it currently is, switches the current player for the next move, and checks if the current player has rolled a 7
            if (currentPlayer == "P1")
            {
                allRolls.Add(sumOfDie);
                currentPlayer = "CPU";
                if (sumOfDie == 7)
                {
                    Console.WriteLine("Player wins!");
                }
            }
            else if (currentPlayer == "CPU")
            {
                currentPlayer = "P1";
                if (sumOfDie == 7)
                {
                        Console.WriteLine("Computer wins!");
                    Debug.Assert(sumOfDie == 7 , "Error found: Incorrect total"); // Checks that the total of the dice is 7.
                }
            }
        }
        return allRolls.Count();
    }

    public int SevensOutPVP()
    {
        currentPlayer = "P1";
        while (sumOfDie != 7)
        {
            // Loop goes through each of the 2 dice objects, calls the method to roll them, stores each roll, and outputs each roll to user.
            for (int i = 0; i < 2; i++)
            {
                Dice[i] = new Die();
                currentRoll = Dice[i].Roll();
                diceTotal[i] = currentRoll;
            }
            sumOfDie = diceTotal[0] + diceTotal[1];
            Console.WriteLine("Player " + currentPlayer + "'s 2 dice rolled a total of " + sumOfDie + "!");

            // Checks which player's move it currently is, switches the current player for the next move, and checks if the current player has rolled a 7
            if (currentPlayer == "P1")
            {
                allRolls.Add(sumOfDie);
                currentPlayer = "P2";
                if (sumOfDie == 7)
                {
                    Console.WriteLine("Player 1 wins!");
                    Debug.Assert(sumOfDie == 7, "Error found: Incorrect total"); // Checks that the total of the dice is 7.
                }
            }
            else if (currentPlayer == "P2")
            {
                currentPlayer = "P1";
                if (sumOfDie == 7)
                {
                    Console.WriteLine("Player 2 wins!");
                }
            }
        }
        return allRolls.Count;
    }
}
