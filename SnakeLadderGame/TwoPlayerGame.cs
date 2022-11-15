using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SnakeLadderGame
{
    public class TwoPlayerGame
    {
        int P1_Position = 0;
        int P2_Position = 0;
            int PlayerPlay = 1;
        
        const int Ladder = 1;
        const int Snake = 2;
        const int NoPlay = 0;
        

        public void WhichPlayerThrowDice()
        {
            Random random = new Random();
            int PlayerPlay = random.Next(2);
            if (PlayerPlay == 1)
            {
                this.P1_Position += PositionOfDice.Dice();  // from class PositionOfdDice
            }
            else
            {
                this.P2_Position += PositionOfDice.Dice();
            }
        }
        public void GameWinning()
        {
            while (P1_Position != 100 && P2_Position !=100)
            {
                Random random = new Random();
                int Option = random.Next(3);
                switch (Option)
                {
                    case NoPlay:
                        break;
                    case Ladder:
                        //int dice = Dice();

                        if (PlayerPlay == 1)
                        {
                            this.P1_Position += PositionOfDice.Dice();
                            if (P1_Position > 100)
                            {
                                this.P1_Position -= PositionOfDice.Dice();
                            }
                               
                        }
                        else
                        {
                            this.P2_Position += PositionOfDice.Dice();
                            if (P2_Position > 100)
                            {
                                this.P2_Position -= PositionOfDice.Dice();
                            }
                                
                        }

                        break;

                    case Snake:
                        //int die1 = DieRoll();
                        if (PlayerPlay  == 1)
                        {
                            this.P1_Position -= PositionOfDice.Dice();
                            if (P1_Position < 0)
                            {
                                this.P1_Position = 0;
                            }
                                
                        }
                        else
                        {
                            this.P2_Position -= PositionOfDice.Dice();
                            if (P2_Position < 0)
                            {
                                this.P2_Position = 0;
                            }
                                
                        }
                        WhichPlayerThrowDice();
                        break;
                }
                Console.WriteLine("position of player1 is  " +P1_Position);
                Console.WriteLine("position of player2 is  "+P2_Position);
            }
            if (P1_Position == 10)
            {
                Console.WriteLine("Player 1 won the snake and ladder game with score:{0} ", P1_Position);
            }
            else
            {
                Console.WriteLine("Player 2 won the snake and ladder game with score:{0} ", P2_Position);
            }
               
           
               
        }

    }
}





    

