using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project
{
    //This class is the logic for rolling a dice
    internal class Die
    {
            //Random funciton to generate number for dice roll
            //protected, so that child classes can use it
            protected Random random;

            //constructor for when a die object is created
            public Die()
            {
                random = new Random();
            }

            //Roll generates and returns a random number 1-6
            //virtual methodso child classes can overrride if necessary
            public virtual int Roll()
            {
                return random.Next(1, 7);
            }
        
    }
}
