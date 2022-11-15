using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class CheckOption 
    {
        int position = 0;
        const int Ladder = 1;
        const int Snake = 2;
        const int NoPlay = 0;
        public void CheckPosition()
        {
            while (this.position != 100 )
            {

                Random random = new Random();
                int Option = random.Next(3);
                switch (Option)
                {
                    case Ladder:
                        this.position += PositionOfDice.Dice();
                        Console.WriteLine("ladder");
                        if (position > 100)
                        {
                            this.position -= PositionOfDice.Dice();
                        }
                        break;
                    case Snake:
                        this.position -= PositionOfDice.Dice();
                        Console.WriteLine("Snake");
                        if (position < 0)
                        {
                            this.position = 0;
                        }
                        break;
                    case NoPlay:
                        break;

                }
                Console.WriteLine("player position is " +this.position);
            }
           
            
        }
    }
      
    
}
