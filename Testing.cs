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
            GameObject.GameSevensOut();
            GameObject.GameThreeOrMore();
        }
    }
}