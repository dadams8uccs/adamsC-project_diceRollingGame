using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project
{
    //this class stores and managees the game statistics
    //tracks rolls, points, average roll, and roll history
    internal class DiceGame
    {
       
        private int totalRolls;
        private int totalPoints;

        //Stores the history of each roll
        private List<string> history;

        public DiceGame()
        {
            totalRolls = 0;
            totalPoints = 0;
            history = new List<string>();
        }

        public int TotalRolls
        {
            get { return totalRolls; }
        }

        public double AverageRoll
        {
            get
            {
                if (totalRolls == 0)
                {
                    return 0;
                }

                return (double)totalPoints / totalRolls;
            }
        }
        
        public List<string> History
        {
            get { return history; }
        }
        //updates the statistics after each roll
        public void AddRoll(int total, string rollDescription)
        {
            totalRolls++;
            totalPoints += total;
            history.Add("Roll " + totalRolls + ": " + rollDescription);
        }

        public void Reset()
        {
            totalRolls = 0;
            totalPoints = 0;
            history.Clear();
        }
    }
}
