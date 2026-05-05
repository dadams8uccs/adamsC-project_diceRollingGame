using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project
{
    //Inherits from the Die class
    //TwoDice can reuse the Roll() method
    internal class TwoDice : Die
    {
        //stores the value of the first die after rolling
        public int Die1 { get; private set; }
        //stores the second value of the second die
        public int Die2 { get; private set; }
        //rolls the two diece and returns the total of the two
        public int RollTwoDice()
        {
            //inherieted roll method
            Die1 = Roll();
            Die2 = Roll();

            return Die1 + Die2;
        }
    }
}
