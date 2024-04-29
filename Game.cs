using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    // Class instantiates 3 dice objects, rolling them and outputting their values and total value to the user
    public class Game
    {
        public int statThreeOrMorePlayed = 0;
        public int statSevenOutPlayed = 0;
        public int statSevenOutRolls = 0;
        public static List<int> statThreeOrMore = new List<int>(2) { 0, 0 };

        public static bool exit = false;
        public static string playerOption = "";

        static void Main(string[] args)
        {
            Game GameObject = new Game(); // Instantiates new Game object
            while (exit == false)
            {
                while (playerOption != "1" && playerOption != "2" && playerOption != "3" && playerOption != "4" && playerOption != "5")
                {
                    Console.WriteLine("Type the number associated with the option to select: \n1 - Three Or More \n2 - Sevens Out\n3 - Statistics \n4 - Testing Mode \n5 -  Quit");
                    try
                    {
                        playerOption = Console.ReadLine();
                    }
                    catch (FormatException) // Catches if an error occurs where the user somehow does not input a string value.
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                if (playerOption == "1")
                {
                    GameObject.GameThreeOrMore(); // Starts ThreeOrMore
                    playerOption = "";
                }
                else if (playerOption == "2")
                {
                    GameObject.GameSevensOut(); // Starts SevensOut
                    playerOption = "";
                }
                else if (playerOption == "3")
                {
                    GameObject.GameStatistics(); // Show Statistics
                    playerOption = "";
                }
                else if (playerOption == "4")
                {
                    Testing TestingObject = new Testing(); // Testing instantiation
                    TestingObject.TestingMethod(); // Accesses testing method
                    playerOption = "";
                }
                else if (playerOption == "5")
                {
                    exit = true; // Exits Program
                    playerOption = "";
                }
            }
        }
        public void GameThreeOrMore() // Three Or More Function
        {
            ThreeOrMore threeOrMore = new ThreeOrMore();
            playerOption = ""; // Resets player input for next input
            while (playerOption != "1" && playerOption != "2") // Takes Player input
            {
                Console.WriteLine("Type the number associated with the gamemode to play: \n1 - Player Versus Computer \n2 -  Player Versus Player");
                try
                {
                    playerOption = Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input");
                }
            }
            if (playerOption == "1") // PVE Mode
            {
                statThreeOrMore = threeOrMore.ThreeOrMorePVE();
                statThreeOrMorePlayed++;
                playerOption = "";
            }
            else if (playerOption == "2") // PVP Mode
            {
                statThreeOrMore = threeOrMore.ThreeOrMorePVP();
                statThreeOrMorePlayed++;
                playerOption = "";
            }
        }

        public void GameSevensOut() // Sevens Out Function
        {
            playerOption = "";
            SevensOut sevensOut = new SevensOut();
            while (playerOption != "1" && playerOption != "2")
            {
                Console.WriteLine("Type the number associated with the gamemode to play: \n1 - Player Versus Computer \n2 -  Player Versus Player");
                try
                {
                    playerOption = Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input");
                }
            }
            if (playerOption == "1")
            {
                statSevenOutRolls += sevensOut.SevensOutPVE();
                statSevenOutPlayed++;
                playerOption = "";
            }
            else if (playerOption == "2")
            {
                statSevenOutRolls += sevensOut.SevensOutPVP();
                statSevenOutPlayed++;
                playerOption = "";
            }
        }
        public void GameStatistics()
        {
            Statistics statistics = new Statistics();
            statistics.StatisticsMethod(statSevenOutPlayed, statSevenOutRolls, statThreeOrMorePlayed, statThreeOrMore);
        }
    }
}


