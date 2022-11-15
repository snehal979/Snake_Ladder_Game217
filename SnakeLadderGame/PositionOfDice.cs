using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class PositionOfDice
    {
        public static void Position()
        {
            int position = 0;
            Console.WriteLine(" Startin position of player at position "+position);
        }
        public static int Dice()
        {
           
            Random random = new Random();
            int diceRoll = random.Next(1, 6);
            Console.WriteLine(diceRoll);
            return diceRoll;
            
          
        }
    }
        
}
