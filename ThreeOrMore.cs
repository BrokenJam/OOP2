using CMP1903_A1_2324;
using System;
using System.Data;

public class ThreeOrMore
{
    public Die[] Dice = new Die[5];
    public int sumOfDie; // Initialises a new integer variable to store the total value of 3 dice
    public int currentRoll; // Initialises a new integer variable to store the value of the currently rolled dice in an iterative loop
    public int[] diceTotal = new int[7]; // Initialises a new integer array with 2 empty elements
    public int streak = 0; // Counts how many dice are of a kind.
    public int streakNumber = 0; // Stores the number of a kind.
    public int kindNumber; // Stores which number to look for
    public int player1Points;
    public int player2Points;
    public string currentPlayer = "P1";
    public bool winCondition = false;
    public bool rolledATwo = false;
    public string playerRollAgain = "";
    public int timesRolled = 0;
    List<int> stats = new List<int>() { 0,0 }; // Stores Stats


    public List<int> ThreeOrMorePVE()
    {
        while (winCondition == false)
        {
            diceTotal = new int[7];
            for (int i = 0; i < 5; i++)
            {
                Dice[i] = new Die();
                int currentRoll = Dice[i].Roll();
                diceTotal[currentRoll]++;
            }
            timesRolled++;
            for (int i = 1; i <= 6; i++)
            {
                if (diceTotal[i] > streak)
                {
                    streak = diceTotal[i];
                }
            }

            if (currentPlayer == "P1")
            {
                switch (streak)
                {
                    case 0:
                        Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which 0 were matching.");
                        player1Points += 0;
                        break;
                    case 1:
                        Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which 0 were matching.");
                        player1Points += 0;
                        break;
                    case 2:
                        while (playerRollAgain != "N" && playerRollAgain != "Y")
                        {
                            Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which 2 were matching.\nAs you have 2 matching dice, you may choose to roll again. Will you roll again? (Input \"Y\" if yes, or \"N\" if not)");
                            playerRollAgain = Console.ReadLine();
                        }
                        if (playerRollAgain == "Y")
                        {
                            rolledATwo = true;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which 3 were matching! +3 points!");
                        player1Points += 3;
                        break;
                    case 4:
                        Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which 4 were matching! +6 points!");
                        player1Points += 6;
                        break;
                    case 5:
                        Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which all were matching! +12 points!");
                        player1Points += 12;
                        break;
                }
                if (player1Points >= 20)
                {
                    Console.WriteLine("Player 1 wins!");
                    winCondition = true;
                    stats[0] = timesRolled; // Stores amount of times the 5 dice were rolled during the game
                    stats[1] = player2Points + player1Points; // Stores total of points accumulated during the game
                }
                if (rolledATwo == false)
                {
                    currentPlayer = "CPU";
                }
                rolledATwo = false;
            }

            else if (currentPlayer == "CPU")
            {
                switch (streak)
                {
                    case 0:
                        Console.WriteLine("The Computer rolled five dice, of which 0 were matching.");
                        player2Points += 0;
                        break;
                    case 1:
                        Console.WriteLine("The Computer rolled five dice, of which 0 were matching.");
                        player2Points += 0;
                        break;
                    case 2:
                        Console.WriteLine("The Computer rolled five dice, of which 2 were matching. As The Computer has rolled two matching dice, The Computer rolls again.");
                        player2Points += 0;
                        break;
                    case 3:
                        Console.WriteLine("The Computer rolled five dice, of which 3 were matching! +3 points!");
                        player2Points += 3;
                        break;
                    case 4:
                        Console.WriteLine("The Computer rolled five dice, of which 4 were matching! +6 points!");
                        player2Points += 6;
                        break;
                    case 5:
                        Console.WriteLine("The Computer rolled five dice, of which all were matching! +12 points!");
                        player2Points += 12;
                        break;
                }
                if (player2Points >= 20)
                {
                    Console.WriteLine("Computer wins");
                    winCondition = true;
                    stats[0] = timesRolled; // Stores amount of times the 5 dice were rolled during the game
                    stats[1] = player2Points + player1Points; // Stores total of points accumulated during the game
                }
                currentPlayer = "P1";
            }
        }
        return stats;
    }
    public List<int> ThreeOrMorePVP()
    {
            while (winCondition == false)
            {
                diceTotal = new int[7];
                for (int i = 0; i < 5; i++)
                {
                    Dice[i] = new Die();
                    int currentRoll = Dice[i].Roll();
                    diceTotal[currentRoll]++;
                }

                for (int i = 1; i <= 6; i++)
                {
                    if (diceTotal[i] > streak)
                    {
                        streak = diceTotal[i];
                    }
                }

                if (currentPlayer == "P1")
                {
                    switch (streak)
                    {
                        case 0:
                            Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which 0 were matching.");
                            player1Points += 0;
                            break;
                        case 1:
                            Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which 0 were matching.");
                            player1Points += 0;
                            break;
                        case 2:
                            while (playerRollAgain != "N" && playerRollAgain != "Y")
                            {
                                Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which 2 were matching.\nAs you have 2 matching dice, you may choose to roll again. Will you roll again? (Input \"Y\" if yes, or \"N\" if not)");
                                playerRollAgain = Console.ReadLine();
                            }
                            if (playerRollAgain == "Y")
                            {
                                rolledATwo = true;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which 3 were matching! +3 points!");
                            player1Points += 3;
                            break;
                        case 4:
                            Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which 4 were matching! +6 points!");
                            player1Points += 6;
                            break;
                        case 5:
                            Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which all were matching! +12 points!");
                            player1Points += 12;
                            break;
                    }
                    if (player1Points >= 20)
                    {
                        Console.WriteLine("Player 1 wins!");
                        winCondition = true;
                        stats[0] = timesRolled; // Stores amount of times the 5 dice were rolled during the game
                        stats[1] = player2Points + player1Points; // Stores total of points accumulated during the game
                    }
                    if (rolledATwo == false)
                    {
                        currentPlayer = "P2";
                    }
                    rolledATwo = false;
                }

                else if (currentPlayer == "P2")
                {
                    switch (streak)
                    {
                        case 0:
                            Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which 0 were matching.");
                            player1Points += 0;
                            break;
                        case 1:
                            Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which 0 were matching.");
                            player1Points += 0;
                            break;
                        case 2:
                            while (playerRollAgain != "N" && playerRollAgain != "Y")
                            {
                                Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which 2 were matching.\nAs you have 2 matching dice, you may choose to roll again. Will you roll again? (Input \"Y\" if yes, or \"N\" if not)");
                                playerRollAgain = Console.ReadLine();
                            }
                            if (playerRollAgain == "Y")
                            {
                                rolledATwo = true;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which 3 were matching! +3 points!");
                            player1Points += 3;
                            break;
                        case 4:
                            Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which 4 were matching! +6 points!");
                            player1Points += 6;
                            break;
                        case 5:
                            Console.WriteLine("Player " + currentPlayer + " rolled five dice, of which all were matching! +12 points!");
                            player1Points += 12;
                            break;
                    }
                    if (player1Points >= 20)
                    {
                        Console.WriteLine("Player 2 wins!");
                        winCondition = true;
                        stats[0] = timesRolled; // Stores amount of times the 5 dice were rolled during the game
                        stats[1] = player2Points + player1Points; // Stores total of points accumulated during the game
                    }
                    if (rolledATwo == false)
                    {
                        currentPlayer = "P1";
                    }
                    rolledATwo = false;
                }
            }
        return stats;
    }
}
