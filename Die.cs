using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    // Class rolls a die upon object instantiation and contains a method to return it.
    public class Die
    {
        private int currentRoll = randomObject.Next(1, 7);  //Rolls die
        private static Random randomObject = new Random(); //Instantiates a new random object

        internal int Roll() // Returns the value of the rolled die.
        {
            return currentRoll;
        }
    }
}