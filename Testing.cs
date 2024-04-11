using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace CMP1903_A1_2324
{
    // Class instantiates a Game object to roll 3 dice, using Debug.Assert() for error handling.
    class Testing
    {
        public void TestingMethod()
        {
            Game GameObject = new Game(); // Instantiates a new Game object
            int[] diceTotal = new int[3]; // Initialises a new integer array variable for containing the dice roll values.
            diceTotal = GameObject.GameMethod(); // Calls "GameMethod" within the Game object to return 3 dice values.

            // Loop checks each element of the "diceTotal" array to see if the roll is between 1 and 6 inclusive.
            for (int i = 0; i < 3; i++)
            {
                Debug.Assert(diceTotal[i] >= 1 && diceTotal[i] <= 6, "Error found: Roll is not within range");
            }

            int sumOfDice = diceTotal[0] + diceTotal[1] + diceTotal[2]; // Initialises a new integer variable to add up the dice rolls
            Debug.Assert(sumOfDice >= 3 && sumOfDice <= 18, "Error found: Incorrect total"); // Checks that the total of the dice rolls are between 3 and 18 inclusive.
        }
    }
}